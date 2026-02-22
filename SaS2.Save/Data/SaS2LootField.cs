namespace SaS2.Save
{
    public class SaS2LootField
    {
        public enum SaS2LootFieldDataType
        {
            DATA_TYPE_FLOAT = 0,
            DATA_TYPE_STRING = 1,
            DATA_TYPE_INT = 2,
            DATA_TYPE_BOOLEAN = 3,
            DATA_TYPE_LOOT = 4,
            DATA_TYPE_MAGIC = 5,
            DATA_TYPE_MAGIC_IDX = 6,
            DATA_TYPE_ANIMATION = 7
        }

        public int ID;
        public int dataType;

        public string strData;
        public float fData;
        public int iData;
        public bool bData;

        public SaS2LootField(int ID, int dataType)
        {
            this.ID = ID;
            this.dataType = dataType;
        }

        public SaS2LootField(BinaryReader reader)
        {
            Read(reader);
        }

        public void Read(BinaryReader reader)
        {
            ID = reader.ReadInt32();
            dataType = reader.ReadInt32();

            switch (dataType)
            {
                case (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT:
                    fData = reader.ReadSingle();
                    break;
                case (int)SaS2LootFieldDataType.DATA_TYPE_INT:
                case (int)SaS2LootFieldDataType.DATA_TYPE_MAGIC_IDX:
                    iData = reader.ReadInt32();
                    break;
                case (int)SaS2LootFieldDataType.DATA_TYPE_STRING:
                case (int)SaS2LootFieldDataType.DATA_TYPE_LOOT:
                case (int)SaS2LootFieldDataType.DATA_TYPE_MAGIC:
                case (int)SaS2LootFieldDataType.DATA_TYPE_ANIMATION:
                    strData = reader.ReadString();
                    break;
                case (int)SaS2LootFieldDataType.DATA_TYPE_BOOLEAN:
                    iData = (reader.ReadBoolean() ? 1 : 0);
                    bData = iData == 1;
                    break;
            }
        }
    }
}
