using System.Numerics;

namespace SaS2.Save
{
    public class SaS2Stats
    {
        public enum PlayerStat
        {
            Strength = 0,
            Dexterity = 1,
            Vitality = 2,
            Will = 3,
            Endurance = 4,
            Arcana = 5,
            Conviction = 6,
            Resolve = 7,
            Luck = 8,

            StatsCount
        }

        public const int MAX_LEVEL = 1000;
        public const int MAX_TREE_UNLOCKS = 500;
        public const int TOTAL_ITEM_CLASSES = 40;
        public const int TOTAL_CLASS_UNLOCKS = 3;

        public int level;
        public int[] stats;
        public long xp;
        public long silver;
        public long droppedXP;
        public int droppedXPArea;
        public Vector2 droppedXPVec;
        public double timePlayed;
        public bool hazeburnt;
        public int[] treeUnlocks;
        public int[] classUnlocks;
        public int[] itemClass;

        public SaS2Stats()
        {
            Reset();
        }

        public void Reset()
        {
            level = 0;
            stats = new int[(int)PlayerStat.StatsCount];
            xp = 0;
            silver = 0;
            droppedXP = 0L;
            droppedXPArea = -1;
            droppedXPVec = new Vector2();
            timePlayed = 0.0;
            hazeburnt = false;
            treeUnlocks = new int[MAX_TREE_UNLOCKS];
            classUnlocks = new int[TOTAL_CLASS_UNLOCKS];
            itemClass = new int[TOTAL_ITEM_CLASSES];
        }

        public void Read(BinaryReader reader)
        {
            level = Math.Min(reader.ReadInt32(), 999);

            for (int i = 0; i < stats.Length; i++)
            {
                stats[i] = reader.ReadInt32();
            }

            xp = reader.ReadInt64();
            silver = reader.ReadInt64();
            droppedXP = reader.ReadInt64();
            droppedXPArea = reader.ReadInt32();
            droppedXPVec = new Vector2(reader.ReadSingle(), reader.ReadSingle());
            timePlayed = reader.ReadDouble();
            hazeburnt = reader.ReadBoolean();

            for (int j = 0; j < TOTAL_ITEM_CLASSES; j++)
            {
                itemClass[j] = reader.ReadInt32();
            }

            for (int k = 0; k < MAX_TREE_UNLOCKS; k++)
            {
                treeUnlocks[k] = reader.ReadInt32();
            }

            for (int l = 0; l < TOTAL_CLASS_UNLOCKS; l++)
            {
                classUnlocks[l] = reader.ReadInt32();
            }

            // The game recalculats stats after loading
            //RecalculateStats();
        }

        protected void RecalculateStats()
        {
            for (int i = 0; i < stats.Length; i++)
            {
                stats[i] = 5;
            }

            for (int j = 0; j < itemClass.Length; j++)
            {
                itemClass[j] = 0;
            }

            for (int k = 0; k < SaS2SkillTree.nodes.Length; k++)
            {
                if (treeUnlocks[k] <= 0 && classUnlocks[0] != k && classUnlocks[1] != k && classUnlocks[2] != k)
                {
                    continue;
                }

                SaS2SkillNode skillNode = SaS2SkillTree.nodes[k];

                if (skillNode.type <= -1)
                {
                    continue;
                }

                switch (skillNode.type)
                {
                    case 0:
                        stats[0] += ((skillNode.value > 1) ? skillNode.value : ((treeUnlocks[k] <= 0) ? 1 : treeUnlocks[k]));
                        break;
                    case 1:
                        stats[1] += ((skillNode.value > 1) ? skillNode.value : ((treeUnlocks[k] <= 0) ? 1 : treeUnlocks[k]));
                        break;
                    case 2:
                        stats[2] += ((skillNode.value > 1) ? skillNode.value : ((treeUnlocks[k] <= 0) ? 1 : treeUnlocks[k]));
                        break;
                    case 3:
                        stats[3] += ((skillNode.value > 1) ? skillNode.value : ((treeUnlocks[k] <= 0) ? 1 : treeUnlocks[k]));
                        break;
                    case 4:
                        stats[4] += ((skillNode.value > 1) ? skillNode.value : ((treeUnlocks[k] <= 0) ? 1 : treeUnlocks[k]));
                        break;
                    case 6:
                        stats[6] += ((skillNode.value > 1) ? skillNode.value : ((treeUnlocks[k] <= 0) ? 1 : treeUnlocks[k]));
                        break;
                    case 5:
                        stats[5] += ((skillNode.value > 1) ? skillNode.value : ((treeUnlocks[k] <= 0) ? 1 : treeUnlocks[k]));
                        break;
                    case 7:
                        stats[7] += ((skillNode.value > 1) ? skillNode.value : ((treeUnlocks[k] <= 0) ? 1 : treeUnlocks[k]));
                        break;
                    case 8:
                        stats[8] += ((skillNode.value > 1) ? skillNode.value : ((treeUnlocks[k] <= 0) ? 1 : treeUnlocks[k]));
                        break;
                    case 9:
                    case 10:
                    case 11:
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                    case 16:
                    case 17:
                    case 18:
                    case 19:
                    case 20:
                    case 21:
                    case 22:
                    case 23:
                    case 24:
                    case 25:
                    case 26:
                    case 27:
                    case 28:
                    case 29:
                    case 30:
                    case 31:
                        if (skillNode.value > itemClass[skillNode.type])
                        {
                            itemClass[skillNode.type] = skillNode.value;
                        }
                        switch (skillNode.type)
                        {
                            case 9:
                            case 20:
                            case 23:
                            case 29:
                                stats[0] += skillNode.cost;
                                break;
                            case 10:
                            case 22:
                            case 30:
                                stats[3] += skillNode.cost;
                                break;
                            case 11:
                            case 16:
                                stats[2] += skillNode.cost;
                                break;
                            case 12:
                            case 13:
                            case 15:
                            case 19:
                                stats[1] += skillNode.cost;
                                break;
                            case 18:
                            case 25:
                            case 26:
                                stats[4] += skillNode.cost;
                                break;
                            case 14:
                            case 28:
                                stats[6] += skillNode.cost;
                                break;
                            case 17:
                            case 27:
                                stats[5] += skillNode.cost;
                                break;
                            case 21:
                                stats[7] += skillNode.cost;
                                break;
                            case 24:
                            case 31:
                                stats[8] += skillNode.cost;
                                break;
                        }
                        break;
                }
            }
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(level);

            for (int i = 0; i < stats.Length; i++)
            {
                writer.Write(stats[i]);
            }

            writer.Write(xp);
            writer.Write(silver);
            writer.Write(droppedXP);
            writer.Write(droppedXPArea);
            writer.Write(droppedXPVec.X);
            writer.Write(droppedXPVec.Y);
            writer.Write(timePlayed);
            writer.Write(hazeburnt);

            for (int j = 0; j < TOTAL_ITEM_CLASSES; j++)
            {
                writer.Write(itemClass[j]);
            }

            for (int k = 0; k < MAX_TREE_UNLOCKS; k++)
            {
                writer.Write(treeUnlocks[k]);
            }

            for (int l = 0; l < TOTAL_CLASS_UNLOCKS; l++)
            {
                writer.Write(classUnlocks[l]);
            }
        }

        public static string GetTimePlayedAsString(double timePlayed)
        {
            int seconds = (int)((long)timePlayed % 60);
            int hoursAndMinutes = (int)((long)timePlayed / 60);
            int hours = hoursAndMinutes / 60;
            int minutes = hoursAndMinutes % 60;

            return $"{hours}:{minutes:D2}:{seconds:D2}";
        }
    }
}
