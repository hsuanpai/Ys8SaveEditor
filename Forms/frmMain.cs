using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Reflection;

using MaterialSkin;
using MaterialSkin.Controls;

namespace Save_Editor
{
    public partial class frmMain : MaterialForm
    {
        #region Fields
        static readonly object m_lock = new object();
        private Ys8Data m_database;
        private Ys8Save m_save;
        #endregion

        #region Properties
        public Ys8Data Data
        {
            get
            {
                lock (m_lock)
                    return m_database;
            }
            internal set
            {
                lock (m_lock)
                    m_database = value;
            }
        }
        #endregion

        #region Constructors/Destructors
        public frmMain()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red500, Primary.Red700, Primary.Red100, Accent.Indigo200, TextShade.WHITE);
        }
        #endregion

        #region Helper Methods
        private void ClearCharacterDataBindings()
        {
            nudAdolLvl.DataBindings.Clear();
            nudSahadLvl.DataBindings.Clear();
            nudHummLvl.DataBindings.Clear();
            nudLaxiaLvl.DataBindings.Clear();
            nudRicoLvl.DataBindings.Clear();
            nudDanaLvl.DataBindings.Clear();

            foreach (ComboBox cmbObject in tabAdolInfoContainer.TabPages[1].Controls.OfType<ComboBox>())
            {
                cmbObject.DataBindings.Clear();
            }
            foreach (ComboBox cmbObject in tabSahadInfoContainer.TabPages[1].Controls.OfType<ComboBox>())
            {
                cmbObject.DataBindings.Clear();
            }
            foreach (ComboBox cmbObject in tabHummInfoContainer.TabPages[1].Controls.OfType<ComboBox>())
            {
                cmbObject.DataBindings.Clear();
            }
            foreach (ComboBox cmbObject in tabLaxiaInfoContainer.TabPages[1].Controls.OfType<ComboBox>())
            {
                cmbObject.DataBindings.Clear();
            }
            foreach (ComboBox cmbObject in tabRicoInfoContainer.TabPages[1].Controls.OfType<ComboBox>())
            {
                cmbObject.DataBindings.Clear();
            }
            foreach (ComboBox cmbObject in tabDanaInfoContainer.TabPages[1].Controls.OfType<ComboBox>())
            {
                cmbObject.DataBindings.Clear();
            }
        }
        private void ClearLabels()
        {
            lblCurrentItemName.Text = string.Empty;
            lblCurrentItemId.Text = string.Empty;
            lblCurrentItemType.Text = string.Empty;
            lblCurrentItemRank.Text = string.Empty;
            lblCurrentItemEffect.Text = string.Empty;
            lblCurrentItemDescription.Text = string.Empty;

            lblPrevItemName.Text = string.Empty;
            lblPrevItemId.Text = string.Empty;
            lblPrevItemType.Text = string.Empty;
            lblPrevItemRank.Text = string.Empty;
            lblPrevItemEffect.Text = string.Empty;
            lblPrevItemDescription.Text = string.Empty;
        }
        // Move to a splash screen
        private void GetItemData()
        {
            m_database = Ys8Data.DeserializeFromString(Properties.Resources.Items);
        }
        private string GetNodeKey(Ys8ItemType itemType)
        {
            string key = string.Empty;

            if (itemType == Ys8ItemType.Unknown)
            {
                key = "UNKNOWN";
            }
            else if (itemType == Ys8ItemType.DLC)
            {
                key = "DLC";
            }
            else if (Ys8Item.WeaponTypes.Contains(itemType))
            {
                key = "WEAPONS";
            }
            else if (Ys8Item.OutfitTypes.Contains(itemType))
            {
                key = "OUTFITS";
            }
            else if (Ys8Item.AttachmentTypes.Contains(itemType))
            {
                key = "ATTACHMENTS";
            }
            else if (Ys8Item.AccessoryTypes.Contains(itemType))
            {
                key = "ACCESSORIES";
            }
            else if (Ys8Item.ArmorTypes.Contains(itemType))
            {
                key = "ARMOR";
            }
            else if (Ys8Item.ArmTypes.Contains(itemType))
            {
                key = "ARM";
            }
            else if (Ys8Item.MaterialTypes.Contains(itemType))
            {
                key = "MATERIALS";
            }
            else if (Ys8Item.RareMaterialTypes.Contains(itemType))
            {
                key = "RARE_MATERIALS";
            }
            else if (Ys8Item.ConsumableTypes.Contains(itemType))
            {
                key = "CONSUMABLES";
            }
            else if (Ys8Item.BookTypes.Contains(itemType))
            {
                key = "BOOKS";
            }
            else if (Ys8Item.IngredientTypes.Contains(itemType))
            {
                key = "INGREDIENTS";
            }
            else if (Ys8Item.InventoryTypes.Contains(itemType))
            {
                key = "INVENTORY";
            }
            else if (Ys8Item.FishTypes.Contains(itemType))
            {
                key = "FISH";
            }
            else if (Ys8Item.InstantTypes.Contains(itemType))
            {
                key = "INSTANT";
            }
            else if (Ys8Item.EquipmentTypes.Contains(itemType))
            {
                key = "EQUIPMENT";
            }

            return key;
        }
        private void SetInventories(Ys8Save save)
        {
            FillTreeView(save.CurrentInventory, trvCurrentInventory);
            FillTreeView(save.PreviousInventory, trvPreviousInventory);
        }
        private void FillTreeView(Ys8Inventory inventory, TreeView treeViewObject)
        {
            TreeNode parentNode;
            TreeNode childNode;

            treeViewObject.Nodes.Clear();
            foreach (Ys8ItemType itemType in Enum.GetValues(typeof(Ys8ItemType)))
            {
                string key = GetNodeKey(itemType);
                if (!treeViewObject.Nodes.ContainsKey(key))
                {
                    parentNode = treeViewObject.Nodes.Add(key, key);
                }
                else
                {
                    int parentIndex = treeViewObject.Nodes.IndexOfKey(key);
                    parentNode = treeViewObject.Nodes[parentIndex];
                }

                foreach (KeyValuePair<int, Ys8SaveItem> saveItem in inventory.Items.ToList().FindAll(item => item.Value.Type == itemType))
                {
                    childNode = new TreeNode(saveItem.Value.Parent.Name)
                    {
                        Tag = saveItem.Value,
                        Name = saveItem.Value.Name
                    };
                    parentNode.Nodes.Add(childNode);
                }
            }

#if DEBUG
            parentNode = treeViewObject.Nodes.Add("DEBUG_UNKNOWN");

            foreach(KeyValuePair<int, int> saveItem in inventory.Unknown)
            {
                Ys8Item tempItem = m_database.Ys8Items.Find(item => item.ID == saveItem.Key);
                childNode = new TreeNode(tempItem.Name)
                {
                    Tag = tempItem,
                    Name = tempItem.Name
                };
                parentNode.Nodes.Add(childNode);
            }
#endif
        }
        private bool AddInventoryItem(Ys8SaveItem item, bool isPreviousInventory)
        {
            Ys8Inventory inventory;

            if (!isPreviousInventory)
                inventory = m_save.CurrentInventory;
            else
                inventory = m_save.PreviousInventory;

            if (!inventory.Items.ContainsKey(item.ID))
            {
                inventory.Items.Add(item.ID, item);
                return true;
            }
            else
                return false;
        }
        private void AddTreeViewItem(TreeView treeViewObject, Ys8SaveItem item)
        {

            string key = GetNodeKey(item.Type);

            TreeNode selectedNode = treeViewObject.Nodes[treeViewObject.Nodes.IndexOfKey(key)];

            if (!selectedNode.Nodes.ContainsKey(item.Parent.Name))
            {
                TreeNode childNode = new TreeNode(item.Parent.Name)
                {
                    Tag = item,
                    Name = item.Name
                };
                selectedNode.Nodes.Add(childNode);
            }
        }
        private void SetCharacters(Ys8Save save)
        {
            foreach (Ys8Character character in save.Characters)
                SetCharacterControls(character);
        }
        private void SetItemValues(Ys8SaveItem saveItem, bool previousInventory)
        {
            Ys8Item parentItem = saveItem.Parent;
            MaterialLabel lblItemName, lblItemId, lblItemType, lblItemRank, lblItemEffect, lblItemDescription, lblItemCount;
            NumericUpDown nudItemCount;

            if (!previousInventory)
            {
                lblItemName = lblCurrentItemName;
                lblItemId = lblCurrentItemId;
                lblItemType = lblCurrentItemType;
                lblItemRank = lblCurrentItemRank;
                lblItemEffect = lblCurrentItemEffect;
                lblItemDescription = lblCurrentItemDescription;
                lblItemCount = lblCurrentItemCount;

                nudItemCount = nudCurrentItemCount;
            }
            else
            {
                lblItemName = lblPrevItemName;
                lblItemId = lblPrevItemId;
                lblItemType = lblPrevItemType;
                lblItemRank = lblPrevItemRank;
                lblItemEffect = lblPrevItemEffect;
                lblItemDescription = lblPrevItemDescription;
                lblItemCount = lblPrevItemDescription;

                nudItemCount = nudPrevItemCount;
            }

            lblItemName.Text = parentItem.Name;
            lblItemId.Text = parentItem.ID.ToString() + string.Format(" (0x{0:X8}h)", parentItem.ID);
            lblItemType.Text = Enum.GetName(typeof(Ys8ItemType), parentItem.Type);
            lblItemRank.Text = parentItem.Rank.ToString();
            lblItemEffect.Text = parentItem.EffectDescription;
            lblItemDescription.Text = parentItem.Description;

            if (Ys8Item.WeaponTypes.Contains(parentItem.Type) || parentItem.Type == Ys8ItemType.DLC)
            //if (Ys8Item.WeaponTypes.Contains(parentItem.Type) || Ys8Item.EquipmentTypes.Contains(parentItem.Type) || parentItem.Type == Ys8ItemType.DLC)
            {
                lblItemCount.Visible = false;
                nudItemCount.Visible = false;

            }
            else
            {
                lblItemCount.Visible = true;
                nudItemCount.Visible = true;

                nudItemCount.DataBindings.Clear();
                nudItemCount.DataBindings.Add("Value", saveItem, "Count");
            }
        }
        private void SetPreviousItemLabels(Ys8SaveItem saveItem)
        {
            Ys8Item parentItem = saveItem.Parent;

            lblCurrentItemName.Text = parentItem.Name;
            lblCurrentItemId.Text = parentItem.ID.ToString() + string.Format(" (0x{0:X8}h)", parentItem.ID);
            lblCurrentItemType.Text = Enum.GetName(typeof(Ys8ItemType), parentItem.Type);
            lblCurrentItemRank.Text = parentItem.Rank.ToString();
            lblCurrentItemEffect.Text = parentItem.EffectDescription;
            lblCurrentItemDescription.Text = parentItem.Description;

            if (Ys8Item.WeaponTypes.Contains(parentItem.Type) || Ys8Item.EquipmentTypes.Contains(parentItem.Type) || parentItem.Type == Ys8ItemType.DLC)
            {
                lblCurrentItemCount.Visible = false;
                nudCurrentItemCount.Visible = false;

            }
            else
            {
                lblCurrentItemCount.Visible = true;
                nudCurrentItemCount.Visible = true;

                nudCurrentItemCount.DataBindings.Clear();
                nudCurrentItemCount.DataBindings.Add("Value", saveItem, "Count");
            }
        }
        private void AddEmptyItems()
        {
            Ys8Item emptyItem = m_database.Ys8Items[0];
            cmbAdolWeaponEq.Items.Add(emptyItem);
            cmbAdolBodyEq.Items.Add(emptyItem);
            cmbAdolArmEq.Items.Add(emptyItem);
            cmbAdolAccessory1Eq.Items.Add(emptyItem);
            cmbAdolAccessory2Eq.Items.Add(emptyItem);

            cmbSahadWeaponEq.Items.Add(emptyItem);
            cmbSahadBodyEq.Items.Add(emptyItem);
            cmbSahadArmEq.Items.Add(emptyItem);
            cmbSahadAccessory1Eq.Items.Add(emptyItem);
            cmbSahadAccessory2Eq.Items.Add(emptyItem);

            cmbHummWeaponEq.Items.Add(emptyItem);
            cmbHummBodyEq.Items.Add(emptyItem);
            cmbHummArmEq.Items.Add(emptyItem);
            cmbHummAccessory1Eq.Items.Add(emptyItem);
            cmbHummAccessory2Eq.Items.Add(emptyItem);

            cmbLaxiaWeaponEq.Items.Add(emptyItem);
            cmbLaxiaBodyEq.Items.Add(emptyItem);
            cmbLaxiaArmEq.Items.Add(emptyItem);
            cmbLaxiaAccessory1Eq.Items.Add(emptyItem);
            cmbLaxiaAccessory2Eq.Items.Add(emptyItem);

            cmbRicoWeaponEq.Items.Add(emptyItem);
            cmbRicoBodyEq.Items.Add(emptyItem);
            cmbRicoArmEq.Items.Add(emptyItem);
            cmbRicoAccessory1Eq.Items.Add(emptyItem);
            cmbRicoAccessory2Eq.Items.Add(emptyItem);

            cmbDanaWeaponEq.Items.Add(emptyItem);
            cmbDanaBodyEq.Items.Add(emptyItem);
            cmbDanaArmEq.Items.Add(emptyItem);
            cmbDanaAccessory1Eq.Items.Add(emptyItem);
            cmbDanaAccessory2Eq.Items.Add(emptyItem);
        }
        private void SetComboBoxData()
        { 
            AddEmptyItems();
            foreach (Ys8ItemType itemType in Enum.GetValues(typeof(Ys8ItemType)))
            {
                Ys8Item[] items = m_database.Ys8Items.FindAll(item => item.Type == itemType).ToArray();

                switch (itemType)
                {
                    case Ys8ItemType.EQ_WP_ANCHOR:
                        {
                            cmbSahadWeaponEq.Items.AddRange(items);
                            break;
                        }
                    case Ys8ItemType.EQ_WP_HALBERT:
                        {
                            cmbDanaWeaponEq.Items.AddRange(items);
                            break;
                        }
                    case Ys8ItemType.EQ_WP_MACE:
                        {
                            cmbRicoWeaponEq.Items.AddRange(items);
                            break;
                        }
                    case Ys8ItemType.EQ_WP_RAPIER:
                        {
                            cmbLaxiaWeaponEq.Items.AddRange(items);
                            break;
                        }
                    case Ys8ItemType.EQ_WP_SPEAR:
                        {
                            cmbHummWeaponEq.Items.AddRange(items);
                            break;
                        }
                    case Ys8ItemType.EQ_WP_SWORD:
                        {
                            cmbAdolWeaponEq.Items.AddRange(items);
                            break;
                        }
                    case Ys8ItemType.EQ_AM_ARMOR:
                        {
                            cmbAdolBodyEq.Items.AddRange(items);
                            cmbSahadBodyEq.Items.AddRange(items);
                            cmbHummBodyEq.Items.AddRange(items);
                            cmbLaxiaBodyEq.Items.AddRange(items);
                            cmbRicoBodyEq.Items.AddRange(items);
                            cmbDanaBodyEq.Items.AddRange(items);
                            break;
                        }
                    case Ys8ItemType.EQ_MAM_ARMOR:
                        {
                            cmbAdolBodyEq.Items.AddRange(items);
                            cmbSahadBodyEq.Items.AddRange(items);
                            cmbHummBodyEq.Items.AddRange(items);
                            break;
                        }
                    case Ys8ItemType.EQ_FAM_ARMOR:
                        {
                            cmbLaxiaBodyEq.Items.AddRange(items);
                            cmbRicoBodyEq.Items.AddRange(items);
                            cmbDanaBodyEq.Items.AddRange(items);
                            break;
                        }
                    case Ys8ItemType.EQ_ARM_BRACELET:
                        {
                            cmbAdolArmEq.Items.AddRange(items);
                            cmbSahadArmEq.Items.AddRange(items);
                            cmbHummArmEq.Items.AddRange(items);
                            cmbLaxiaArmEq.Items.AddRange(items);
                            cmbRicoArmEq.Items.AddRange(items);
                            cmbDanaArmEq.Items.AddRange(items);
                            break;
                        }
                    case Ys8ItemType.EQ_COMMON_ACCESSORY:
                        {
                            cmbAdolAccessory1Eq.Items.AddRange(items);
                            cmbAdolAccessory2Eq.Items.AddRange(items);
                            cmbSahadAccessory1Eq.Items.AddRange(items);
                            cmbSahadAccessory2Eq.Items.AddRange(items);
                            cmbHummAccessory1Eq.Items.AddRange(items);
                            cmbHummAccessory2Eq.Items.AddRange(items);
                            cmbLaxiaAccessory1Eq.Items.AddRange(items);
                            cmbLaxiaAccessory2Eq.Items.AddRange(items);
                            cmbRicoAccessory1Eq.Items.AddRange(items);
                            cmbRicoAccessory2Eq.Items.AddRange(items);
                            cmbDanaAccessory1Eq.Items.AddRange(items);
                            cmbDanaAccessory2Eq.Items.AddRange(items);
                            break;
                        }
                }
            }
        }
        private void SetCharacterControls(Ys8Character character)
        {
            if (character.Name == "Adol")
            {
                nudAdolLvl.DataBindings.Add("Value", character, "Level");

                cmbAdolWeaponEq.DataBindings.Add("SelectedItem", character, "Weapon", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbAdolBodyEq.DataBindings.Add("SelectedItem", character, "Body", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbAdolArmEq.DataBindings.Add("SelectedItem", character, "Arm", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbAdolAccessory1Eq.DataBindings.Add("SelectedItem", character, "Accessory1", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbAdolAccessory2Eq.DataBindings.Add("SelectedItem", character, "Accessory2", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            else if (character.Name == "Sahad")
            {
                nudSahadLvl.DataBindings.Add("Value", character, "Level");

                cmbSahadWeaponEq.DataBindings.Add("SelectedItem", character, "Weapon", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbSahadBodyEq.DataBindings.Add("SelectedItem", character, "Body", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbSahadArmEq.DataBindings.Add("SelectedItem", character, "Arm", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbSahadAccessory1Eq.DataBindings.Add("SelectedItem", character, "Accessory1", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbSahadAccessory2Eq.DataBindings.Add("SelectedItem", character, "Accessory2", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            else if (character.Name == "Hummel")
            {
                nudHummLvl.DataBindings.Add("Value", character, "Level");

                cmbHummWeaponEq.DataBindings.Add("SelectedItem", character, "Weapon", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbHummBodyEq.DataBindings.Add("SelectedItem", character, "Body", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbHummArmEq.DataBindings.Add("SelectedItem", character, "Arm", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbHummAccessory1Eq.DataBindings.Add("SelectedItem", character, "Accessory1", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbHummAccessory2Eq.DataBindings.Add("SelectedItem", character, "Accessory2", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            else if (character.Name == "Laxia")
            {
                nudLaxiaLvl.DataBindings.Add("Value", character, "Level");

                cmbLaxiaWeaponEq.DataBindings.Add("SelectedItem", character, "Weapon", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbLaxiaBodyEq.DataBindings.Add("SelectedItem", character, "Body", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbLaxiaArmEq.DataBindings.Add("SelectedItem", character, "Arm", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbLaxiaAccessory1Eq.DataBindings.Add("SelectedItem", character, "Accessory1", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbLaxiaAccessory2Eq.DataBindings.Add("SelectedItem", character, "Accessory2", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            else if (character.Name == "Ricotta")
            {
                nudRicoLvl.DataBindings.Add("Value", character, "Level");

                cmbRicoWeaponEq.DataBindings.Add("SelectedItem", character, "Weapon", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbRicoBodyEq.DataBindings.Add("SelectedItem", character, "Body", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbRicoArmEq.DataBindings.Add("SelectedItem", character, "Arm", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbRicoAccessory1Eq.DataBindings.Add("SelectedItem", character, "Accessory1", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbRicoAccessory2Eq.DataBindings.Add("SelectedItem", character, "Accessory2", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            else if (character.Name == "Dana")
            {
                nudDanaLvl.DataBindings.Add("Value", character, "Level");

                cmbDanaWeaponEq.DataBindings.Add("SelectedItem", character, "Weapon", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbDanaBodyEq.DataBindings.Add("SelectedItem", character, "Body", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbDanaArmEq.DataBindings.Add("SelectedItem", character, "Arm", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbDanaAccessory1Eq.DataBindings.Add("SelectedItem", character, "Accessory1", false, DataSourceUpdateMode.OnPropertyChanged);
                cmbDanaAccessory2Eq.DataBindings.Add("SelectedItem", character, "Accessory2", false, DataSourceUpdateMode.OnPropertyChanged);
            }
        }
#endregion

#region Methods
        public Ys8Save LoadSave(string path)
        {
            Ys8Save tempSave = new Ys8Save(m_database, path);

            try
            {
                tempSave = new Ys8Save(m_database, path);
                return tempSave;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void SetSave(Ys8Save save)
        {
            ClearCharacterDataBindings();

            //SetComboBoxData();
            SetInventories(save);
            SetCharacters(save);

            m_save = save;
        }
#endregion

#region Control Methods
        private void frmMain_Load(object sender, EventArgs e)
        {
            ClearLabels();

            this.Visible = false;

            frmLoadSave loadSave = new frmLoadSave(this);

            if (loadSave.ShowDialog() == DialogResult.Cancel)
                this.Close();
            else
            {
                SetComboBoxData();
                tabMainContainer.SelectedIndex = 1;
                this.Visible = true;
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (sfdSaveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    m_save.Save(sfdSaveFile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeView focusedTreeView;
            TreeNode selectedNode;
            Ys8Inventory inventory;

            if (trvCurrentInventory.Focused)
            {
                focusedTreeView = trvCurrentInventory;
                inventory = m_save.CurrentInventory;
            }
            else
            {
                focusedTreeView = trvPreviousInventory;
                inventory = m_save.PreviousInventory;
            }

            selectedNode = focusedTreeView.SelectedNode;
            if (selectedNode != null)
            {
                if (selectedNode.Parent != null)
                {
                    Ys8SaveItem saveItem = (Ys8SaveItem)selectedNode.Tag;
                    inventory.Items.Remove(saveItem.Parent.ID);
                    focusedTreeView.Nodes.Remove(selectedNode);
                }
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            frmLoadSave loadSave = new frmLoadSave(this);
            this.Visible = false;

            if (loadSave.ShowDialog() == DialogResult.OK)
            {
                tabMainContainer.SelectedIndex = 1;
            }

            this.Visible = true;
        }

        private void TreeViewObject_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeView trvObject = (TreeView)sender;

            TreeNode selectedNode = trvObject.SelectedNode;

            if (selectedNode != null)
            {
                if (selectedNode.Parent != null)
                {
                    Ys8SaveItem saveItem;

#if DEBUG
                    if (selectedNode.Tag is Ys8Item)
                        saveItem = new Ys8SaveItem((Ys8Item)selectedNode.Tag);
                    else
                        saveItem = (Ys8SaveItem)selectedNode.Tag;
#else
                    saveItem = (Ys8SaveItem)selectedNode.Tag;
#endif
                    SetItemValues(saveItem, (string)trvObject.Tag == "previous");
                }
            }
        }

        private void mnuiCurrAddItem_Click(object sender, EventArgs e)
        {
            frmAddItem addItem = new frmAddItem(m_database);
            if (addItem.ShowDialog() == DialogResult.OK)
            {
                if (addItem.AddedItem != null)
                {
                    if (AddInventoryItem(addItem.AddedItem, false))
                    {
                        AddTreeViewItem(trvCurrentInventory, addItem.AddedItem);
                    }
                }
            }
        }

        private void mnuiPrevAddItem_Click(object sender, EventArgs e)
        {
            frmAddItem addItem = new frmAddItem(m_database);
            if (addItem.ShowDialog() == DialogResult.OK)
            {
                if (addItem.AddedItem != null)
                {
                    if (AddInventoryItem(addItem.AddedItem, true))
                    {
                        AddTreeViewItem(trvPreviousInventory, addItem.AddedItem);
                    }
                }
            }
        }

        private void trvObjectInventory_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeView trvObject = sender as TreeView;

            trvObject.SelectedNode = e.Node;
        }

        private void btnApplyCheats_Click(object sender, EventArgs e)
        {
            List<Ys8Inventory> inventories = new List<Ys8Inventory>();

            if (radCurrentInventory.Checked)
                inventories.Add(m_save.CurrentInventory);
            else if (radPreviousInventory.Checked)
                inventories.Add(m_save.PreviousInventory);
            else if (radBothInventories.Checked)
            {
                inventories.Add(m_save.CurrentInventory);
                inventories.Add(m_save.PreviousInventory);
            }

            if (chkAllInventoryItems.Checked)
            {
                Ys8Cheats.AddAllItems(m_database, inventories.ToArray());
                SetInventories(m_save);
            }
            if (chkMaxItemValue.Checked)
            {
                Ys8Cheats.MaxAllValues(inventories.ToArray());
            }
            MessageBox.Show("Cheats applied", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void EquippedItemToolTip_MouseHover(object sender, EventArgs e)
        {
            if (sender is ComboBox)
            {
                ComboBox cmbObject = (ComboBox)sender;

                if (cmbObject.SelectedItem != null)
                {
                    Ys8Item item = (Ys8Item)cmbObject.SelectedItem;
                    tipEquippedItem.Show($"Effect: {item.EffectDescription}{Environment.NewLine}Description: {item.Description}", cmbObject);
                }
            }
        }
#endregion
    }
}
