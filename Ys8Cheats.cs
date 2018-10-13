using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Save_Editor
{
    public static class Ys8Cheats
    {
        #region Fields
        private const int m_maxCount = 999;
        private static readonly int[] m_restrictedIds =
        {
            656, 657, 658, 659, 660, 661, 662, 663, 664, 665, 666, 667, 668, 669, 685, 686, 698, 
            750, 751, 752, 753, 754, 755, 760, 761, 762, 763, 770, 771, 772, 773, 774, 775, 776, 777, 778, 779, 780, 781,782, 783, 784, 785, 786, 787, 788, 789, 790,
            800, 801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818, 819, 820, 821, 822, 823, 824, 825, 826, 827, 828, 829, 830,
            932, 933, 934, 935, 936,  937, 938, 939, 940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967
        };
        #endregion

        #region Methods
        public static void AddAllItems(Ys8Data database, params Ys8Inventory[] inventories)
        {
            foreach (Ys8Item item in database.Ys8Items)
            {
                for (int i = 0; i < inventories.Length; ++i)
                {
                    if (item.Type != Ys8ItemType.DLC || item.Type != Ys8ItemType.Unknown)
                    {
                        if (!inventories[i].Items.ContainsKey(item.ID))
                            inventories[i].Items.Add(item.ID, new Ys8SaveItem(item));
                    }
                }
            }
        }
        public static void MaxAllValues(params Ys8Inventory[] inventories)
        {
            for (int i = 0; i < inventories.Length; ++i)
            {
                foreach (KeyValuePair<int, Ys8SaveItem> item in inventories[i].Items)
                {
                    if (!Ys8Item.WeaponTypes.Contains(item.Value.Type) || !m_restrictedIds.Contains(item.Value.ID))
                    {
                            item.Value.Count = m_maxCount;
                    }
                }
            }
        }
        #endregion
    }
}
