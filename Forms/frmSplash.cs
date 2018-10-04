using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Save_Editor
{
    public partial class frmSplash : Form
    {
        #region Fields
        private frmMain m_parent;
        #endregion

        #region Properties
        #endregion

        public frmSplash(frmMain parent)
        {
            m_parent = parent;

            InitializeComponent();
        }

        private void bgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            m_parent.Data = Ys8Data.DeserializeFromString(Properties.Resources.Items);
            System.Threading.Thread.Sleep(2000);
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            bgwLoad.RunWorkerAsync();
            //m_parent.Data = Ys8Data.DeserializeFromString(Properties.Resources.Items);
        }

        private void bgwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }
    }
}
