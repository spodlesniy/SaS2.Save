
using System.Security.Cryptography;

namespace SaS2.Save
{
    public class SaS2Save
    {
        internal const int MIN_SAVE_VERSION = 17;
        internal const int PREVIOUS_SAVE_VERSION = 18;
        internal const int CURRENT_SAVE_VERSION = 19;

        internal const int HASH_DATA_LENGTH = 16;
        internal const int COSMETICS_COUNT = 11;

        public int version = -1;

        public string name;
        public SaS2Stats stats;
        public SaS2Equipment equipment;
        public Sas2Bestiary bestiary;
        public int[] cosmetic;
        public SaS2PlayerFlags flags;

        public string hashData;

        public SaS2Save()
        {
            version = -1;

            name = "";
            stats = new SaS2Stats();
            equipment = new SaS2Equipment();
            flags = new SaS2PlayerFlags();
            bestiary = new Sas2Bestiary();
            cosmetic = new int[COSMETICS_COUNT];

            hashData = "";
        }

        public void Read(string fileName)
        {
            if (!Path.Exists(fileName))
            {
                throw new Exception($"SaveReader: file {fileName} doesn't exist");
            }

            Read(File.ReadAllBytes(fileName));
        }

        public void Read(byte[] binaryData)
        {
            int saveVersion = BitConverter.ToInt32(binaryData, 0);
            version = saveVersion;

            // I've no idea about this check ¯\_(ツ)_/¯
            if (saveVersion == 0 && binaryData.Length == 4)
            {
                return;
            }

            switch (saveVersion)
            {
                case PREVIOUS_SAVE_VERSION:
                case CURRENT_SAVE_VERSION:
                    {
                        for (int i = 0; i < binaryData.Length - HASH_DATA_LENGTH; i++)
                        {
                            binaryData[i] = (byte)(binaryData[i] ^ saveVersion);
                        }
                        break;
                    }
                case MIN_SAVE_VERSION:
                    break;

                default:
                    throw new InvalidDataException($"SaveReader: Unsupported save version: {saveVersion}");
            }

            using var binaryReader = new BinaryReader(new MemoryStream(binaryData));

            // Omit version
            binaryReader.ReadInt32();

            name = binaryReader.ReadString();
            stats.Read(binaryReader);
            equipment.Read(binaryReader);
            flags.Read(binaryReader);

            if (saveVersion < CURRENT_SAVE_VERSION)
            {
                for (int j = 0; j < 10; j++)
                {
                    binaryReader.ReadInt32();
                }
            }

            bestiary.Read(binaryReader);

            for (int k = 0; k < cosmetic.Length; k++)
            {
                cosmetic[k] = binaryReader.ReadInt32();
            }

            if (saveVersion >= PREVIOUS_SAVE_VERSION)
            {
                int saveHashSize = (int)binaryReader.BaseStream.Position - 4;
                byte[] saveHashData = new byte[saveHashSize];

                for (int l = 0; l < saveHashSize; l++)
                {
                    saveHashData[l] = binaryData[l + 4];
                }

                var calculatedHashData = MD5.HashData(saveHashData);

                byte[] hashDataFromSave = binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position));

                if (hashDataFromSave.Length != HASH_DATA_LENGTH)
                {
                    throw new InvalidDataException("SaveReader: File hash invalid length");
                }

                if (hashDataFromSave.Length != calculatedHashData.Length)
                {
                    throw new InvalidDataException("SaveReader: File hash mismatch.");
                }

                for (int k = 0; k < hashDataFromSave.Length; k++)
                {
                    if (hashDataFromSave[k] != calculatedHashData[k])
                    {
                        throw new InvalidDataException("SaveReader: File hash mismatch.");
                    }
                }

                hashData = BitConverter.ToString(hashDataFromSave);
            }
        }

        public void Write(BinaryWriter fileWriter)
        {
            using BinaryWriter binaryWriter = new BinaryWriter(new MemoryStream());

            binaryWriter.Write(name);

            stats.Write(binaryWriter);
            equipment.Write(binaryWriter);
            flags.Write(binaryWriter);
            bestiary.Write(binaryWriter);

            for (int i = 0; i < cosmetic.Length; i++)
            {
                binaryWriter.Write(cosmetic[i]);
            }

            byte[] array = ((MemoryStream)binaryWriter.BaseStream).ToArray();

            var calculatedHashData = MD5.HashData(array);

            for (int j = 0; j < array.Length; j++)
            {
                array[j] ^= 0x13;
            }

            fileWriter.Write(CURRENT_SAVE_VERSION);
            fileWriter.Write(array);
            fileWriter.Write(calculatedHashData);

            hashData = BitConverter.ToString(calculatedHashData);
        }
    }
}
