namespace SaS2.Save
{
    public static class SaS2SkillTree
    {
        public static SaS2SkillNode[] nodes = [];

        internal static void Read(BinaryReader reader)
        {
            int counter = reader.ReadInt32();

            nodes = new SaS2SkillNode[counter];
            for (int i = 0; i < counter; i++)
            {
                nodes[i] = new SaS2SkillNode(reader, i);
            }

            //counter = reader.ReadInt32();

            //imgs = new SkillImg[counter];
            //for (int j = 0; j < counter; j++)
            //{
            //    imgs[j] = new SkillImg(reader);
            //}
        }
    }
}
