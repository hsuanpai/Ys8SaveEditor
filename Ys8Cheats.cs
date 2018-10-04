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
                    if (!Ys8Item.WeaponTypes.Contains(item.Value.Type))
                    {
                        item.Value.Count = m_maxCount;
                    }
                }
            }
        }
        #endregion
    }
}
