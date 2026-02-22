using System.Numerics;
using System.Text;

namespace SaS2.Save
{
    public class SaS2SkillNode
    {
        private const int MAX_UPGRADES_PER_STAT_NODE = 5;
        private const int MAX_PARENTS = 2;


        public int index;
        public string name;
        public string[] title;
        public StringBuilder titleStr;
        public string[] desc;
        public string[] baseDesc;
        public int type;
        public int value;
        public int cost;
        public int[] parent;

        public Vector2 loc;
        public int max;

        public SaS2SkillNode(BinaryReader reader, int index)
        {
            name = reader.ReadString();

            title = new string[13];
            for (int i = 0; i < 13; i++)
            {
                title[i] = reader.ReadString();
            }

            this.index = index;
            titleStr = new StringBuilder(title[(int)SaS2Environment.currentLanguage]);

            desc = new string[13];
            for (int j = 0; j < 13; j++)
            {
                desc[j] = reader.ReadString();
            }

            baseDesc = new string[13];
            for (int k = 0; k < 13; k++)
            {
                baseDesc[k] = reader.ReadString();
            }

            type = reader.ReadInt32();
            value = reader.ReadInt32();
            cost = reader.ReadInt32();

            parent = new int[MAX_PARENTS];
            for (int l = 0; l < MAX_PARENTS; l++)
            {
                parent[l] = reader.ReadInt32();
            }

            loc = new Vector2(reader.ReadSingle(), reader.ReadSingle());
            max = GetMaxTreeUnlock();
        }

        protected int GetMaxTreeUnlock()
        {
            if (cost > 1)
            {
                return 1;
            }

            int num = type;
            if ((uint)num <= 8u)
            {
                return MAX_UPGRADES_PER_STAT_NODE;
            }

            return 1;
        }
    }
}
