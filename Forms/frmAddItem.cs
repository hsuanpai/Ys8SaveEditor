using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace Save_Editor
{
    public partial class frmAddItem : MaterialForm
    {
        #region Fields
        private Ys8Data m_data;
        #endregion

        #region Properties
        #endregion

        #region Constructors/Destructors
        public frmAddItem(Ys8Data data)
        {
            m_data = data;

            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red500, Primary.Red700, Primary.Red100, Accent.Indigo200, TextShade.WHITE);
        }
        #endregion

        #region Helper Methods
        private void ClearLabels()
        {
            lblItemName.Text = string.Empty;
            lblItemId.Text = string.Empty;
            lblItemType.Text = string.Empty;
            lblItemRank.Text = string.Empty;
            lblItemDescription.Text = string.Empty;
            lblItemEffect.Text = string.Empty;

        }
        private void SetLabels (Ys8Item item)
        {
            lblItemName.Text = item.Name;
            lblItemId.Text = $"{item.ID} (0x{item.ID:X8}h)";
            lblItemType.Text = Enum.GetName(typeof(Ys8ItemType), item.Type);
            lblItemRank.Text = item.Rank.ToString();
            lblItemEffect.Text = item.EffectDescription;
            lblItemDescription.Text = item.Description;
        }
        private void FillItemTree()
        {
            foreach (Ys8ItemType itemType in Enum.GetValues(typeof(Ys8ItemType)))
            {
                if (Ys8Item.WeaponTypes.Contains(itemType))
                    continue;

                TreeNode parentNode = new TreeNode(Enum.GetName(typeof(Ys8ItemType), itemType));

                List<Ys8Item> results = m_data.Ys8Items.FindAll(item => item.Type == itemType);

                foreach(Ys8Item item in results)
                {
                    TreeNode childNode = new TreeNode(item.ToString())
                    {
                        Tag = item
                    };

                    parentNode.Nodes.Add(childNode);
                }
                trvItem.Nodes.Add(parentNode);
            }
        }
        private void GetSaveItems(TreeNodeCollection parentNode, List<Ys8SaveItem> saveItems)
        {
            foreach (TreeNode childNode in parentNode)
            {
                if (childNode.Checked)
                    saveItems.Add(new Ys8SaveItem((Ys8Item)childNode.Tag));
                if (childNode.Nodes.Count > 0)
                    GetSaveItems(childNode.Nodes, saveItems);
            }
        }
        private void CheckAllNodes(TreeNode node, bool isChecked)
        {
            foreach (TreeNode childNode in node.Nodes)
            {
                childNode.Checked = isChecked;
                if (childNode.Nodes.Count > 0)
                    CheckAllNodes(childNode, isChecked);
            }
        }
        #endregion

        #region Methods
        public List<Ys8SaveItem> GetAddedItems()
        {
            List<Ys8SaveItem> saveItems = new List<Ys8SaveItem>();

            foreach (TreeNode node in trvItem.Nodes)
            {
                GetSaveItems(node.Nodes, saveItems);
            }

            return saveItems;
        }
        #endregion

        #region Control Methods
        private void frmAddItem_Load(object sender, EventArgs e)
        {
            ClearLabels();
            FillItemTree();
        }

        private void trvItem_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (trvItem.SelectedNode != null)
            {
                if (trvItem.SelectedNode.Parent != null)
                {
                    Ys8Item item = (Ys8Item)trvItem.SelectedNode.Tag;
                    SetLabels(item);
                }
            }
            else
            {
                ClearLabels();
            }
        }
        #endregion

        private void trvItem_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                    CheckAllNodes(e.Node, e.Node.Checked);
            }
        }
    }
}
