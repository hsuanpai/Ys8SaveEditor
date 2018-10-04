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
        private Ys8ItemType[] m_weaponTypes = new Ys8ItemType[]
            {
                Ys8ItemType.EQ_WP_ANCHOR,
                Ys8ItemType.EQ_WP_HALBERT,
                Ys8ItemType.EQ_WP_MACE,
                Ys8ItemType.EQ_WP_RAPIER,
                Ys8ItemType.EQ_WP_SPEAR,
                Ys8ItemType.EQ_WP_SWORD
            };
        #endregion

        #region Properties
        public Ys8SaveItem AddedItem
        {
            get;
            private set;
        }
        #endregion


        public frmAddItem(Ys8Data data)
        {
            m_data = data;
            AddedItem = null;

            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red500, Primary.Red700, Primary.Red100, Accent.Indigo200, TextShade.WHITE);
        }

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
            lblItemId.Text = item.ID.ToString() + string.Format(" (0x{0:X8}h)", item.ID);
            lblItemType.Text = Enum.GetName(typeof(Ys8ItemType), item.Type);
            lblItemRank.Text = item.Rank.ToString();
            lblItemEffect.Text = item.EffectDescription;
            lblItemDescription.Text = item.Description;
        }
        private void FillItemTree()
        {
            foreach (Ys8ItemType itemType in Enum.GetValues(typeof(Ys8ItemType)))
            {
                if (m_weaponTypes.Contains(itemType))
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
        #endregion

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            FillItemTree();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (trvItem.SelectedNode != null)
            {
                if (trvItem.SelectedNode.Parent != null)
                {
                    Ys8Item selectedItem = (Ys8Item)trvItem.SelectedNode.Tag;
                    AddedItem = new Ys8SaveItem(selectedItem);
                }
            }
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
    }
}
