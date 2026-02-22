namespace SaS2.Save
{
    public class SaS2PlayerFlags
    {
        public List<string> flags;

        public int bountySeed;
        public int bountiesComplete;
        public int ngLevel;

        public SaS2PlayerFlags()
        {
            Reset();
        }
        public void Reset()
        {
            flags = [];
            bountySeed = 0;
            bountiesComplete = 0;
            ngLevel = 0;
        }

        public void Read(BinaryReader reader)
        {
            int flagCount = reader.ReadInt32();

            flags = [];
            for (int i = 0; i < flagCount; i++)
            {
                string item = reader.ReadString();
                flags.Add(item);
            }

            bountySeed = reader.ReadInt32();
            bountiesComplete = reader.ReadInt32();

            UpdateNG();

            if (ngLevel > 0 && !flags.Contains("$1ntr0"))
            {
                flags.Add("$1ntr0");
            }
        }

        protected void UpdateNG()
        {
            ngLevel = 0;
            foreach (string flag in flags)
            {
                if (flag.StartsWith("$&ng_") && flag.Length > "$&ng_".Length)
                {
                    if (int.TryParse(flag.AsSpan("$&ng_".Length), out var result) && result > ngLevel)
                    {
                        ngLevel = result;

                        // no break here because there can be several "$&ng_" flags with different values
                    }
                }
            }
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(flags.Count);

            for (int i = 0; i < flags.Count; i++)
            {
                writer.Write(flags[i]);
            }

            writer.Write(bountySeed);
            writer.Write(bountiesComplete);
        }
    }
}
