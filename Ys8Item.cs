using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace Save_Editor
{
    public enum Ys8ItemType
    {
        Unknown,
        EQ_WP_SWORD,
        EQ_WP_HALBERT,
        EQ_WP_RAPIER,
        EQ_WP_ANCHOR,
        EQ_WP_SPEAR,
        EQ_WP_MACE,
        EQ_MC_ADOL_ONLY,
        EQ_MC_LAXIA_ONLY,
        EQ_MC_SAHAD_ONLY,
        EQ_MC_HUMMEL_ONLY,
        EQ_MC_RICOTTA_ONLY,
        EQ_MC_DANA_ONLY,
        EQ_SC_ADOL_ONLY,
        EQ_SC_LAXIA_ONLY,
        EQ_COMMON_SUBCOSTUME,
        EQ_COMMON_ACCESSORY,
        EQ_AM_ARMOR,
        EQ_MAM_ARMOR,
        EQ_FAM_ARMOR,
        EQ_ARM_BRACELET,
        ITEM_TYPE_MATERIAL_BONE,
        ITEM_TYPE_MATERIAL_LEATHER,
        ITEM_TYPE_MATERIAL_LIQUID,
        ITEM_TYPE_MATERIAL_WOOD,
        ITEM_TYPE_MATERIAL_FLOWER,
        ITEM_TYPE_MATERIAL_STONE,
        ITEM_TYPE_R_MATERIAL,
        ITEM_TYPE_R_MATERIAL_FLOWER,
        ITEM_TYPE_R_MATERIAL_WOOD,
        ITEM_TYPE_R_MATERIAL_STONE,
        ITEM_TYPE_USEDRUG_BOTTLE_99,
        ITEM_TYPE_USEDRUG_99,
        ITEM_TYPE_USESPDRUG_99,
        ITEM_TYPE_USEFRUIT_99,
        ITEM_TYPE_USEDRINK_99,
        ITEM_TYPE_USECOOK_9,
        ITEM_TYPE_USEBOOK_9,
        ITEM_TYPE_USEEVENT_99,
        ITEM_TYPE_COOKSTUFF,
        ITEM_TYPE_INVENTORY,
        ITEM_TYPE_FISH,
        ITEM_TYPE_INSTANT,
        ITEM_TYPE_EQUIP,
        DLC = 254
    }
    [XmlRoot("Item")]
    public class Ys8Item
    {
        #region Fields   
        private static readonly Ys8ItemType[] m_weaponTypes =
        {
            Ys8ItemType.EQ_WP_ANCHOR,
            Ys8ItemType.EQ_WP_HALBERT,
            Ys8ItemType.EQ_WP_MACE,
            Ys8ItemType.EQ_WP_RAPIER,
            Ys8ItemType.EQ_WP_SPEAR,
            Ys8ItemType.EQ_WP_SWORD
        };
        private static readonly Ys8ItemType[] m_outfitTypes =
        {
            Ys8ItemType.EQ_MC_ADOL_ONLY,
            Ys8ItemType.EQ_MC_LAXIA_ONLY,
            Ys8ItemType.EQ_MC_RICOTTA_ONLY,
            Ys8ItemType.EQ_MC_SAHAD_ONLY,
            Ys8ItemType.EQ_MC_HUMMEL_ONLY,
            Ys8ItemType.EQ_MC_DANA_ONLY
        };
        private static readonly Ys8ItemType[] m_attachmentTypes =
        {
            Ys8ItemType.EQ_SC_ADOL_ONLY,
            Ys8ItemType.EQ_SC_LAXIA_ONLY,
            Ys8ItemType.EQ_COMMON_SUBCOSTUME
        };
        private static readonly Ys8ItemType[] m_accessoryTypes =
        {
            Ys8ItemType.EQ_COMMON_ACCESSORY
        };
        private static readonly Ys8ItemType[] m_armorTypes =
        {
            Ys8ItemType.EQ_AM_ARMOR,
            Ys8ItemType.EQ_MAM_ARMOR,
            Ys8ItemType.EQ_FAM_ARMOR
        };
        private static readonly Ys8ItemType[] m_armTypes =
        {
            Ys8ItemType.EQ_ARM_BRACELET
        };
        private static readonly Ys8ItemType[] m_materialTypes =
        {
            Ys8ItemType.ITEM_TYPE_MATERIAL_BONE,
            Ys8ItemType.ITEM_TYPE_MATERIAL_FLOWER,
            Ys8ItemType.ITEM_TYPE_MATERIAL_LEATHER,
            Ys8ItemType.ITEM_TYPE_MATERIAL_LIQUID,
            Ys8ItemType.ITEM_TYPE_MATERIAL_STONE,
            Ys8ItemType.ITEM_TYPE_MATERIAL_WOOD
        };
        private static readonly Ys8ItemType[] m_rareMaterialTypes =
        {
            Ys8ItemType.ITEM_TYPE_R_MATERIAL,
            Ys8ItemType.ITEM_TYPE_R_MATERIAL_FLOWER,
            Ys8ItemType.ITEM_TYPE_R_MATERIAL_STONE,
            Ys8ItemType.ITEM_TYPE_R_MATERIAL_WOOD
        };
        private static readonly Ys8ItemType[] m_consumableTypes =
        {
            Ys8ItemType.ITEM_TYPE_USEDRUG_BOTTLE_99,
            Ys8ItemType.ITEM_TYPE_USEDRINK_99,
            Ys8ItemType.ITEM_TYPE_USEDRUG_99,
            Ys8ItemType.ITEM_TYPE_USESPDRUG_99,
            Ys8ItemType.ITEM_TYPE_USEFRUIT_99,
            Ys8ItemType.ITEM_TYPE_USECOOK_9,
            Ys8ItemType.ITEM_TYPE_USEEVENT_99
        };
        private static readonly Ys8ItemType[] m_bookTypes =
        {
            Ys8ItemType.ITEM_TYPE_USEBOOK_9
        };
        private static readonly Ys8ItemType[] m_ingredientTypes =
        {
            Ys8ItemType.ITEM_TYPE_COOKSTUFF
        };
        private static readonly Ys8ItemType[] m_inventoryTypes =
        {
            Ys8ItemType.ITEM_TYPE_INVENTORY
        };
        private static readonly Ys8ItemType[] m_fishTypes =
        {
            Ys8ItemType.ITEM_TYPE_FISH
        };
        private static readonly Ys8ItemType[] m_instantTypes =
        {
            Ys8ItemType.ITEM_TYPE_INSTANT
        };
        private static readonly Ys8ItemType[] m_equipmentTypes =
        {
            Ys8ItemType.ITEM_TYPE_EQUIP
        };
        #endregion

        #region Properties
        [XmlElementAttribute("id", typeof(int))]
        public int ID
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string EffectDescription
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }
        [XmlElementAttribute("type", typeof(Ys8ItemType))]
        public Ys8ItemType Type
        {
            get; set;
        }
        [XmlElementAttribute("rank", typeof(int))]
        public int Rank
        {
            get; set;
        }
        [XmlIgnore]
        public static Ys8ItemType[] WeaponTypes
        {
            get { return m_weaponTypes; }
        }
        [XmlIgnore]
        public static Ys8ItemType[] OutfitTypes
        {
            get { return m_outfitTypes; }
        }
        [XmlIgnore]
        public static Ys8ItemType[] AttachmentTypes
        {
            get { return m_attachmentTypes; }
        }
        [XmlIgnore]
        public static Ys8ItemType[] AccessoryTypes
        {
            get { return m_accessoryTypes; }
        }
        [XmlIgnore]
        public static Ys8ItemType[] ArmorTypes
        {
            get { return m_armorTypes; }
        }
        [XmlIgnore]
        public static Ys8ItemType[] ArmTypes
        {
            get { return m_armTypes; }
        }
        [XmlIgnore]
        public static Ys8ItemType[] MaterialTypes
        {
            get { return m_materialTypes; }
        }
        [XmlIgnore]
        public static Ys8ItemType[] RareMaterialTypes
        {
            get { return m_rareMaterialTypes; }
        }
        [XmlIgnore]
        public static Ys8ItemType[] ConsumableTypes
        {
            get { return m_consumableTypes; }
        }
        [XmlIgnore]
        public static Ys8ItemType[] BookTypes
        {
            get { return m_bookTypes; }
        }
        [XmlIgnore]
        public static Ys8ItemType[] IngredientTypes
        {
            get { return m_ingredientTypes; }
        }
        [XmlIgnore]
        public static Ys8ItemType[] InventoryTypes
        {
            get { return m_inventoryTypes; }
        }
        [XmlIgnore]
        public static Ys8ItemType[] FishTypes
        {
            get { return m_fishTypes; }
        }
        [XmlIgnore]
        public static Ys8ItemType[] InstantTypes
        {
            get { return m_instantTypes; }
        }
        [XmlIgnore]
        public static Ys8ItemType[] EquipmentTypes
        {
            get { return m_equipmentTypes; }
        }
        #endregion

        #region Constructors/Destructors
        #endregion

        #region Methods
        public override string ToString()
        {
            return Name;
        }
        #endregion
    }
}
