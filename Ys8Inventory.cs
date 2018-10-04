using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Save_Editor
{
    public class Ys8Inventory : ISaveOffset
    {
        #region Fields
        private Ys8Data m_database;
        #endregion

        #region Properties
        public Dictionary<string, long> Offsets
        {
            get;
            set;
        } = new Dictionary<string, long>();

        public Dictionary<int, Ys8SaveItem> Items
        {
            get;
            private set;
        } = new Dictionary<int, Ys8SaveItem>();
        public Dictionary<int, int> Unknown
        {
            get;
            private set;
        } = new Dictionary<int, int>();
        #endregion

        #region Constructors/Destructors
        public Ys8Inventory(Ys8Data database)
        {
            m_database = database ?? throw new ArgumentNullException("itemData");
        }
        #endregion

        #region Helper Methods
        private void AddItemsObtained(byte[] data)
        {
            long itemsObtainedOffset = Offsets["obtained"];

            int id = 0;
            int i = 0;
            byte bitValue = 0;
            while (id <= m_database.Ys8Items.Count)
            {
                for (int x = 0; x < 8; x += 2)
                {
                    Ys8SaveItem tempItem;
                    string idString;
                    bitValue = (byte)((data[itemsObtainedOffset + i] >> x) & 3);

                    if (bitValue != 0)
                    {
                        tempItem = new Ys8SaveItem(m_database.Ys8Items[id]);
                        idString = id.ToString();

                        switch (bitValue)
                        {
                            case 3:
                                {
                                    Items.Add(id, tempItem);
                                    Unknown.Add(id, 1);
                                    break;
                                }
                            case 2:
                                {
                                    Unknown.Add(id, 1);
                                    break;
                                }
                            case 1:
                                {
                                    Items.Add(id, tempItem);
                                    break;
                                }
                        }
                    }
                    ++id;
                }
                ++i;
            }
        }
        private void AddItemsCount(byte[] data)
        {
            long countOffset = Offsets["count"];
            foreach (KeyValuePair<int, Ys8SaveItem> item in Items)
            {
                if (item.Value.Parent.ID > 130)
                    item.Value.Count = BitConverter.ToInt16(data, (int)countOffset + (item.Value.ID - 130) * 2);
            }
        }
        private void SaveItemData(byte[] data)
        {
            long itemsObtainedOffset = Offsets["obtained"];
            long itemsCountOffset = Offsets["count"];

            for (int i = 0; i < m_database.Ys8Items.Count / 4; ++i)
            {
                data[itemsObtainedOffset + i] = 0;
            }

            foreach (KeyValuePair<int, Ys8SaveItem> item in Items)
            {
                int bytePosition = item.Value.Parent.ID / 4;
                int bitPosition = (item.Value.Parent.ID % 4) * 2;

                data[itemsObtainedOffset + bytePosition] = (byte)(data[itemsObtainedOffset + bytePosition] | (byte)(1 << bitPosition));

                byte[] countBytes = BitConverter.GetBytes(item.Value.Count);
                countBytes.CopyTo(data, (int)itemsCountOffset + (item.Value.ID - 131) * 2);
            }

            foreach (KeyValuePair<int, int> unknownValue in Unknown)
            {
                int bytePosition = unknownValue.Key / 4;
                int bitPosition = (unknownValue.Key % 4) * 2;

                data[itemsObtainedOffset + bytePosition] = (byte)(data[itemsObtainedOffset + bytePosition] | (byte)(1 << (bitPosition + 1)));
            }
        }
        #endregion

        #region Methods
        public void SetItems(byte[] data)
        {
            AddItemsObtained(data);
            AddItemsCount(data);
        }
        public void Save(byte[] data)
        {
            SaveItemData(data);
        }
        public bool AddItem(Ys8SaveItem item)
        {
            if (Items.ContainsKey(item.ID))
                return false;
            Items[item.ID] = item;

            return true;
        }
        public bool RemoveItem(Ys8SaveItem item)
        {
            return Items.Remove(item.ID);
        }
        #endregion
    }
}
