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

using MaterialSkin;
using MaterialSkin.Controls;

namespace Save_Editor
{
    public partial class frmLoadSave : MaterialForm
    {
        #region Fields
        private const string m_historyPath = "history.txt";
        private frmMain m_parent;
        #endregion

        #region Constructors/Destructors
        public frmLoadSave(frmMain parent)
        {
            m_parent = parent;
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red500, Primary.Red700, Primary.Red100, Accent.Indigo200, TextShade.WHITE);
        }
        #endregion

        #region Helper Methods
        private void LoadHistory()
        {
            if (!File.Exists(m_historyPath))
            {
                return;
            }

            foreach(string file in File.ReadAllLines(m_historyPath))
            {
                lstSaves.Items.Add(file);
            }
        }
        private void SaveHistory()
        {
            StreamWriter stream = new StreamWriter(File.Create(m_historyPath));

            foreach (ListViewItem item in lstSaves.Items)
            {
                stream.WriteLine(item.Text);
            }

            stream.Close();
        }
        #endregion

        #region Control Methods
        private void frmLoadSave_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ofdSaveFile.ShowDialog() == DialogResult.OK)
            {
                Ys8Save tempSave = m_parent.LoadSave(ofdSaveFile.FileName);

                if (tempSave != null)
                {
                    m_parent.SetSave(tempSave);
                    lstSaves.Items.Add(ofdSaveFile.FileName);
                    SaveHistory();
                }
                else
                {
                    MessageBox.Show("Could not load save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void lstSaves_DoubleClick(object sender, EventArgs e)
        {
            if (lstSaves.SelectedItems != null)
            {
                if (!string.IsNullOrEmpty(lstSaves.SelectedItems[0].Text))
                {
                    Ys8Save tempSave = m_parent.LoadSave(lstSaves.SelectedItems[0].Text);

                    if (tempSave != null)
                    {
                        m_parent.SetSave(tempSave);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Could not load save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.None;
                    }
                }
            }
        }
        #endregion
    }
}
