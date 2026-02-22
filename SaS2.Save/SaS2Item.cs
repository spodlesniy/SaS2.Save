using SaS2.Save.Data;

namespace SaS2.Save
{
    public class SaS2Item
    {
        public bool isNew = true;

        public int lootIdx;
        public int count;
        public int upgrade;
        public bool stockPiled;

        public SaS2ArtifactData artifactData;

        public SaS2Item(int lootIdx)
        {
            isNew = true;

            this.lootIdx = lootIdx;
            count = 1;
            upgrade = SaS2LootCatalog.GetBaseUpgrade(lootIdx);
            stockPiled = false;

            //SetArtifactData();
        }

        public SaS2Item(BinaryReader reader)
        {
            Read(reader);
        }

        public void Read(BinaryReader reader)
        {
            isNew = false;

            lootIdx = reader.ReadInt32();
            count = reader.ReadInt32();
            upgrade = reader.ReadInt32();
            stockPiled = reader.ReadBoolean();

            //SetArtifactData();
        }

        internal void SetArtifactData()
        {
            if (lootIdx >= SaS2LootCatalog.lootDefs.Count || SaS2LootCatalog.lootDefs[lootIdx].type != 6)
            {
                return;
            }

            int subType = SaS2LootCatalog.lootDefs[lootIdx].subType;

            if ((uint)(subType - 3) <= 2u)
            {
                if (artifactData == null)
                {
                    artifactData = new SaS2ArtifactData();
                }

                //artifactData.Populate(this, Rand);
            }
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(lootIdx);
            writer.Write(count);
            writer.Write(upgrade);
            writer.Write(stockPiled);

            isNew = false;
        }
    }
}
