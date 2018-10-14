using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Save_Editor
{
    public enum Ys8CharacterEnum
    {
        Unknown,
        Adol,
        Laxia,
        Sahad,
        Hummel,
        Ricotta,
        Dana
    }
    public class Ys8Character : ISaveOffset
    {
        #region Fields
        private const int m_sizeOfCharacterData = 0x19c;
        private const int m_numberOfSkills = 12;
        private const int m_skillDataSize = 12;
        private int m_level = 1;
        private float m_hp;
        #endregion

        #region Properties
        public Dictionary<string, long> Offsets
        {
            get;
            set;
        }
        public Ys8CharacterEnum Character
        {
            get; set;
        }
        public string Name
        {
            get { return Enum.GetName(typeof(Ys8CharacterEnum), Character); }
        }
        public int Level
        {
            get { return m_level; }
            set
            {
                if (value > 0 || value <= MaxLevelValue)
                    m_level = value;
            }
        }
        public static int MaxLevelValue
        {
            get { return 99; }
        }
        public float MaxHp
        {
            get { return m_hp; }
            set
            {
                if (value > -1f || value <= MaxHpValue)
                    m_hp = value;
            }
        }
        public static float MaxHpValue
        {
            get { return 9999f; }
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
        public List<Ys8SaveSkill> Skills
        {
            get;
            private set;
        } = new List<Ys8SaveSkill>();
        #endregion

        #region Constructors/Destructors
        public Ys8Character(Ys8CharacterEnum character)
        {
            Character = character;
        }
        #endregion

        #region Helper Methods        
        private void SetLevel(byte[] data)
        {
            Level = BitConverter.ToInt32(data, (int)Offsets["level"]);
        }
        private void SetMaxHp(byte[] data)
        {
            MaxHp = BitConverter.ToSingle(data, (int)Offsets["max_hp"]);
        }
        private void SetSkills(byte[] data, Ys8Data database)
        {
            int skillsOffset = (int)Offsets["skills"];
            int id = 0;
            Ys8SaveSkill skill;

            for (int i = 0; i < m_numberOfSkills; ++i, skillsOffset += m_skillDataSize)
            {

                id = BitConverter.ToInt16(data, skillsOffset);
                Skills.Add(new Ys8SaveSkill(database.Ys8Skills.Find(skillObject => skillObject.ID1 == id)));

                skill = Skills[Skills.Count - 1];
                skill.Unlocked = BitConverter.ToBoolean(data, 2 + skillsOffset);
                skill.Rank = BitConverter.ToInt16(data, 4 + skillsOffset);
            }
        }
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
        private void SaveMaxHp(byte[] data)
        {
            Array.Copy(BitConverter.GetBytes(MaxHp), 0, data, Offsets["max_hp"], 4);
        }
        private void SaveSkills(byte[] data)
        {
            int skillsOffset = (int)Offsets["skills"];
            Ys8SaveSkill skill;

            for (int i = 0; i < m_numberOfSkills; ++i, skillsOffset += m_skillDataSize)
            {
                skill = Skills[i];
                Array.Copy(BitConverter.GetBytes(Convert.ToInt16(skill.Unlocked)), 0, data, skillsOffset + 2, 2);

                if (!skill.Unlocked)
                {
                    Array.Copy(BitConverter.GetBytes(0), 0, data, skillsOffset + 4, 2);
                    Array.Copy(BitConverter.GetBytes(0xffffffff), 0, data, skillsOffset + 8, 4);
                }
                else
                    Array.Copy(BitConverter.GetBytes(skill.Rank), 0, data, skillsOffset + 4, 2);

            }
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
        #endregion

        #region Methods        
        public void SetCharacterData(byte[] data, Ys8Data database)
        {
            SetLevel(data);
            SetMaxHp(data);
            SetSkills(data, database);
            SetEquippedItems(data, database);
        }
        public void Save(byte[] data, Ys8Data database)
        {
            SaveLevel(data);
            SaveMaxHp(data);
            SaveSkills(data);
            SaveEquippedItems(data);
        }
        #endregion
    }
}
