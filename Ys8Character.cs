using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Save_Editor
{
    public class Ys8Character : ISaveOffset
    {
        #region Fields
        private const int m_sizeOfCharacterData = 0x19c;
        #endregion

        #region Properties
        public Dictionary<string, long> Offsets
        {
            get;
            set;
        }
        public string Name
        {
            get;
            private set;
        }
        public int Level
        {
            get;
            set;
        }
        public Ys8Item Weapon
        {
            get;
            set;
        }
        public Ys8Item Body
        {
            get;
            set;
        }
        public Ys8Item Arm
        {
            get;
            set;
        }
        public Ys8Item Accessory1
        {
            get;
            set;
        }
        public Ys8Item Accessory2
        {
            get;
            set;
        }
        #endregion

        #region Constructors/Destructors
        public Ys8Character(string name)
        {
            Name = name;
        }
        #endregion

        #region Helper Methods
        private void SetEquippedItems(byte[] data, Ys8Data database)
        {
            int equippedItemsOffset = (int)Offsets["equipped"];

            ushort[] values = new ushort[5];

            for (int i = 0; i < values.Length; ++i)
            {
                ushort value = (ushort)BitConverter.ToInt16(data, equippedItemsOffset + i * 2);

                if (value == 0xffff)
                    values[i] = 0;
                else
                    values[i] = value;
            }

            Weapon = database.Ys8Items[values[0]];
            Body = database.Ys8Items[values[1]];
            Arm = database.Ys8Items[values[2]];
            Accessory1 = database.Ys8Items[values[3]];
            Accessory2 = database.Ys8Items[values[4]];
        }
        private void SaveLevel(byte[] data)
        {
            Array.Copy(BitConverter.GetBytes(Level), 0, data, Offsets["level"], 4);
        }
        private void SaveEquippedItems(byte[] data)
        {
            int equippedItemsOffset = (int)Offsets["equipped"];

            Array.Copy(BitConverter.GetBytes((short)Weapon.ID == 0 ? -1 : Weapon.ID), 0, data, equippedItemsOffset, 2);
            Array.Copy(BitConverter.GetBytes((short)Body.ID == 0 ? -1 : Body.ID), 0, data, equippedItemsOffset + 2, 2);
            Array.Copy(BitConverter.GetBytes((short)Arm.ID == 0 ? -1 : Arm.ID), 0, data, equippedItemsOffset + 4, 2);
            Array.Copy(BitConverter.GetBytes((short)Accessory1.ID == 0 ? -1 : Accessory1.ID), 0, data, equippedItemsOffset + 6, 2);
            Array.Copy(BitConverter.GetBytes((short)Accessory2.ID == 0 ? -1 : Accessory2.ID), 0, data, equippedItemsOffset + 8, 2);
        }
        private void SetLevel(byte[] data)
        {
            Level = BitConverter.ToInt32(data, (int)Offsets["level"]);
        }
        #endregion

        #region Methods
        
        public void SetCharacterData(byte[] data, Ys8Data database)
        {
            SetLevel(data);
            SetEquippedItems(data, database);
        }
        public void Save(byte[] data, Ys8Data database)
        {
            SaveLevel(data);
            SaveEquippedItems(data);
        }
        #endregion
    }
}
