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
    public partial class frmEditItem : MaterialForm
    {
        #region Fields
        private Ys8SaveItem m_saveItem;
        #endregion


        #region Constructors/Destructors
        public frmEditItem( Ys8SaveItem saveItem)
        {
            m_saveItem = saveItem;

            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red500, Primary.Red700, Primary.Red100, Accent.Indigo200, TextShade.WHITE);
        }
        #endregion

        #region Helper Methods
        #endregion

        private void frmEditItem_Load(object sender, EventArgs e)
        {
            txtName.Text = m_saveItem.Parent.Name;
            nudValue.Value = m_saveItem.Count;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            m_saveItem.Count = (int)nudValue.Value;
        }
    }
}
