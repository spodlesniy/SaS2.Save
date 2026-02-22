namespace SaS2.Save
{
    public class Sas2Bestiary
    {
        public const int TOTAL_DROPS = 5;

        public struct Sas2Beast
        {
            public int kills;
            public int deaths;
            public bool[] drops;

            public void Read(BinaryReader reader)
            {
                kills = reader.ReadInt32();
                deaths = reader.ReadInt32();

                drops = new bool[TOTAL_DROPS];
                for (int i = 0; i < drops.Length; i++)
                {
                    drops[i] = reader.ReadBoolean();
                }
            }

            public void Write(BinaryWriter writer)
            {
                writer.Write(kills);
                writer.Write(deaths);

                drops ??= new bool[TOTAL_DROPS];

                for (int i = 0; i < drops.Length; i++)
                {
                    writer.Write(drops[i]);
                }
            }
        }

        public Sas2Beast[] beasts;

        public Sas2Bestiary()
        {
            beasts = new Sas2Beast[1]; // MonsterCatalog.monsterDef.Count
            for (int i = 0; i < beasts.Length; i++)
            {
                beasts[i].drops = new bool[TOTAL_DROPS];
            }

            Reset();
        }

        public void Reset()
        {
            for (int i = 0; i < beasts.Length; i++)
            {
                beasts[i].kills = 0;
                beasts[i].deaths = 0;

                for (int j = 0; j < beasts[i].drops.Length; j++)
                {
                    beasts[i].drops[j] = false;
                }
            }
        }
        public void Read(BinaryReader reader)
        {
            int bestiaryCount = reader.ReadInt32();

            for (int i = 0; i < bestiaryCount; i++)
            {
                if (i < beasts.Length)
                {
                    beasts[i].Read(reader);
                }
                else
                {
                    default(Sas2Beast).Read(reader);
                }
            }
        }
        public void Write(BinaryWriter writer)
        {
            writer.Write(beasts.Length);
            for (int i = 0; i < beasts.Length; i++)
            {
                beasts[i].Write(writer);
            }
        }
    }
}
