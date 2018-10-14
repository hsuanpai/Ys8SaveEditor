namespace Save_Editor
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmsCurrentItems = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.mnuiCurrAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.tabMainContainer = new MaterialSkin.Controls.MaterialTabControl();
            this.tabFile = new System.Windows.Forms.TabPage();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.materialTabSelector4 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabInventoryContainer = new MaterialSkin.Controls.MaterialTabControl();
            this.tabCurrentInventory = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvCurrentInventory = new System.Windows.Forms.TreeView();
            this.lblCurrentItemRank = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.nudCurrentItemCount = new System.Windows.Forms.NumericUpDown();
            this.lblCurrentItemCount = new MaterialSkin.Controls.MaterialLabel();
            this.lblCurrentItemName = new MaterialSkin.Controls.MaterialLabel();
            this.lblCurrentItemId = new MaterialSkin.Controls.MaterialLabel();
            this.lblCurrentItemType = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblCurrentItemDescription = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblCurrentItemEffect = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPreviousInventory = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.trvPreviousInventory = new System.Windows.Forms.TreeView();
            this.cmsPreviousItems = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.mnuiPrevAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPrevItemRank = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel33 = new MaterialSkin.Controls.MaterialLabel();
            this.nudPrevItemCount = new System.Windows.Forms.NumericUpDown();
            this.lblPrevItemCount = new MaterialSkin.Controls.MaterialLabel();
            this.lblPrevItemName = new MaterialSkin.Controls.MaterialLabel();
            this.lblPrevItemId = new MaterialSkin.Controls.MaterialLabel();
            this.lblPrevItemType = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel38 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel39 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel40 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPrevItemDescription = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel42 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPrevItemEffect = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel44 = new MaterialSkin.Controls.MaterialLabel();
            this.tabCharacter = new System.Windows.Forms.TabPage();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabCharacterContainer = new MaterialSkin.Controls.MaterialTabControl();
            this.tabAdol = new System.Windows.Forms.TabPage();
            this.selCharacterInformation = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabAdolInfoContainer = new MaterialSkin.Controls.MaterialTabControl();
            this.tabIAdalInfo = new System.Windows.Forms.TabPage();
            this.chkAdolHp = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel62 = new MaterialSkin.Controls.MaterialLabel();
            this.nudAdolMaxHp = new System.Windows.Forms.NumericUpDown();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.nudAdolLvl = new System.Windows.Forms.NumericUpDown();
            this.lblCharacterName = new MaterialSkin.Controls.MaterialLabel();
            this.tabAdolEquipped = new System.Windows.Forms.TabPage();
            this.cmbAdolArmEq = new System.Windows.Forms.ComboBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbAdolAccessory2Eq = new System.Windows.Forms.ComboBox();
            this.cmbAdolAccessory1Eq = new System.Windows.Forms.ComboBox();
            this.materialLabel29 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel28 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbAdolBodyEq = new System.Windows.Forms.ComboBox();
            this.materialLabel27 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbAdolWeaponEq = new System.Windows.Forms.ComboBox();
            this.materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            this.tabAdolSkills = new System.Windows.Forms.TabPage();
            this.chkAdolSkillUnlocked = new MaterialSkin.Controls.MaterialCheckBox();
            this.nudAdolSkillRank = new System.Windows.Forms.NumericUpDown();
            this.materialLabel68 = new MaterialSkin.Controls.MaterialLabel();
            this.lstAdolSkills = new System.Windows.Forms.ListBox();
            this.picAdol = new System.Windows.Forms.PictureBox();
            this.tabLaxia = new System.Windows.Forms.TabPage();
            this.materialTabSelector3 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabLaxiaInfoContainer = new MaterialSkin.Controls.MaterialTabControl();
            this.tabLaxiaInfo = new System.Windows.Forms.TabPage();
            this.chkLaxiaHp = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel63 = new MaterialSkin.Controls.MaterialLabel();
            this.nudLaxiaMaxHp = new System.Windows.Forms.NumericUpDown();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.nudLaxiaLvl = new System.Windows.Forms.NumericUpDown();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.tabLaxiaEquipped = new System.Windows.Forms.TabPage();
            this.cmbLaxiaArmEq = new System.Windows.Forms.ComboBox();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbLaxiaAccessory2Eq = new System.Windows.Forms.ComboBox();
            this.cmbLaxiaAccessory1Eq = new System.Windows.Forms.ComboBox();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbLaxiaBodyEq = new System.Windows.Forms.ComboBox();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbLaxiaWeaponEq = new System.Windows.Forms.ComboBox();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.tabLaxiaSkills = new System.Windows.Forms.TabPage();
            this.picLaxia = new System.Windows.Forms.PictureBox();
            this.tabSahad = new System.Windows.Forms.TabPage();
            this.materialTabSelector5 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabSahadInfoContainer = new MaterialSkin.Controls.MaterialTabControl();
            this.tabSahadInfo = new System.Windows.Forms.TabPage();
            this.chkSahadHp = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel64 = new MaterialSkin.Controls.MaterialLabel();
            this.nudSahadMaxHp = new System.Windows.Forms.NumericUpDown();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.nudSahadLvl = new System.Windows.Forms.NumericUpDown();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.tabSahadEquipped = new System.Windows.Forms.TabPage();
            this.cmbSahadArmEq = new System.Windows.Forms.ComboBox();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbSahadAccessory2Eq = new System.Windows.Forms.ComboBox();
            this.cmbSahadAccessory1Eq = new System.Windows.Forms.ComboBox();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel23 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbSahadBodyEq = new System.Windows.Forms.ComboBox();
            this.materialLabel24 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbSahadWeaponEq = new System.Windows.Forms.ComboBox();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.tabSahadSkills = new System.Windows.Forms.TabPage();
            this.picSahad = new System.Windows.Forms.PictureBox();
            this.tabHummel = new System.Windows.Forms.TabPage();
            this.materialTabSelector6 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabHummInfoContainer = new MaterialSkin.Controls.MaterialTabControl();
            this.tabHummInfo = new System.Windows.Forms.TabPage();
            this.chkHummHp = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel65 = new MaterialSkin.Controls.MaterialLabel();
            this.nudHummMaxHp = new System.Windows.Forms.NumericUpDown();
            this.materialLabel30 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel31 = new MaterialSkin.Controls.MaterialLabel();
            this.nudHummLvl = new System.Windows.Forms.NumericUpDown();
            this.materialLabel32 = new MaterialSkin.Controls.MaterialLabel();
            this.tabHummEquipped = new System.Windows.Forms.TabPage();
            this.cmbHummArmEq = new System.Windows.Forms.ComboBox();
            this.materialLabel34 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbHummAccessory2Eq = new System.Windows.Forms.ComboBox();
            this.cmbHummAccessory1Eq = new System.Windows.Forms.ComboBox();
            this.materialLabel35 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel36 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbHummBodyEq = new System.Windows.Forms.ComboBox();
            this.materialLabel37 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbHummWeaponEq = new System.Windows.Forms.ComboBox();
            this.materialLabel41 = new MaterialSkin.Controls.MaterialLabel();
            this.tabHummSkills = new System.Windows.Forms.TabPage();
            this.picHummel = new System.Windows.Forms.PictureBox();
            this.tabRicotta = new System.Windows.Forms.TabPage();
            this.materialTabSelector7 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabRicoInfoContainer = new MaterialSkin.Controls.MaterialTabControl();
            this.tabRicoInfo = new System.Windows.Forms.TabPage();
            this.chkRicoHp = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel66 = new MaterialSkin.Controls.MaterialLabel();
            this.nudRicoMaxHp = new System.Windows.Forms.NumericUpDown();
            this.materialLabel43 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel45 = new MaterialSkin.Controls.MaterialLabel();
            this.nudRicoLvl = new System.Windows.Forms.NumericUpDown();
            this.materialLabel46 = new MaterialSkin.Controls.MaterialLabel();
            this.tabRicoEquppied = new System.Windows.Forms.TabPage();
            this.cmbRicoArmEq = new System.Windows.Forms.ComboBox();
            this.materialLabel47 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbRicoAccessory2Eq = new System.Windows.Forms.ComboBox();
            this.cmbRicoAccessory1Eq = new System.Windows.Forms.ComboBox();
            this.materialLabel48 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel49 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbRicoBodyEq = new System.Windows.Forms.ComboBox();
            this.materialLabel50 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbRicoWeaponEq = new System.Windows.Forms.ComboBox();
            this.materialLabel51 = new MaterialSkin.Controls.MaterialLabel();
            this.tabRicoSkills = new System.Windows.Forms.TabPage();
            this.picRicotta = new System.Windows.Forms.PictureBox();
            this.tabDana = new System.Windows.Forms.TabPage();
            this.materialTabSelector8 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabDanaInfoContainer = new MaterialSkin.Controls.MaterialTabControl();
            this.tabDanaInfo = new System.Windows.Forms.TabPage();
            this.chkDanaHp = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel67 = new MaterialSkin.Controls.MaterialLabel();
            this.nudDanaMaxHp = new System.Windows.Forms.NumericUpDown();
            this.materialLabel52 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel53 = new MaterialSkin.Controls.MaterialLabel();
            this.nudDanaLvl = new System.Windows.Forms.NumericUpDown();
            this.materialLabel54 = new MaterialSkin.Controls.MaterialLabel();
            this.tabDanaEquipped = new System.Windows.Forms.TabPage();
            this.cmbDanaArmEq = new System.Windows.Forms.ComboBox();
            this.materialLabel55 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbDanaAccessory2Eq = new System.Windows.Forms.ComboBox();
            this.cmbDanaAccessory1Eq = new System.Windows.Forms.ComboBox();
            this.materialLabel56 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel57 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbDanaBodyEq = new System.Windows.Forms.ComboBox();
            this.materialLabel58 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbDanaWeaponEq = new System.Windows.Forms.ComboBox();
            this.materialLabel59 = new MaterialSkin.Controls.MaterialLabel();
            this.tabDanaSkills = new System.Windows.Forms.TabPage();
            this.picDana = new System.Windows.Forms.PictureBox();
            this.tabCheats = new System.Windows.Forms.TabPage();
            this.materialLabel61 = new MaterialSkin.Controls.MaterialLabel();
            this.radBothInventories = new MaterialSkin.Controls.MaterialRadioButton();
            this.radPreviousInventory = new MaterialSkin.Controls.MaterialRadioButton();
            this.radCurrentInventory = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnApplyCheats = new MaterialSkin.Controls.MaterialRaisedButton();
            this.chkMaxItemValue = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkAllInventoryItems = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel60 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tipEquippedItem = new System.Windows.Forms.ToolTip(this.components);
            this.ys8CharacterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ys8CharacterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chkLaxiaSkillUnlocked = new MaterialSkin.Controls.MaterialCheckBox();
            this.nudLaxiaSkillRank = new System.Windows.Forms.NumericUpDown();
            this.materialLabel69 = new MaterialSkin.Controls.MaterialLabel();
            this.lstLaxiaSkills = new System.Windows.Forms.ListBox();
            this.chkSahadSkillUnlocked = new MaterialSkin.Controls.MaterialCheckBox();
            this.nudSahadSkillRank = new System.Windows.Forms.NumericUpDown();
            this.materialLabel70 = new MaterialSkin.Controls.MaterialLabel();
            this.lstSahadSkills = new System.Windows.Forms.ListBox();
            this.chkHummSkillUnlocked = new MaterialSkin.Controls.MaterialCheckBox();
            this.nudHummSkillRank = new System.Windows.Forms.NumericUpDown();
            this.materialLabel71 = new MaterialSkin.Controls.MaterialLabel();
            this.lstHummSkills = new System.Windows.Forms.ListBox();
            this.chkRicoSkillUnlocked = new MaterialSkin.Controls.MaterialCheckBox();
            this.nudRicoSkillRank = new System.Windows.Forms.NumericUpDown();
            this.materialLabel72 = new MaterialSkin.Controls.MaterialLabel();
            this.lstRicoSkills = new System.Windows.Forms.ListBox();
            this.chkDanaSkillUnlocked = new MaterialSkin.Controls.MaterialCheckBox();
            this.nudDanaSkillRank = new System.Windows.Forms.NumericUpDown();
            this.materialLabel73 = new MaterialSkin.Controls.MaterialLabel();
            this.lstDanaSkills = new System.Windows.Forms.ListBox();
            this.cmsCurrentItems.SuspendLayout();
            this.tabMainContainer.SuspendLayout();
            this.tabFile.SuspendLayout();
            this.tabInventory.SuspendLayout();
            this.tabInventoryContainer.SuspendLayout();
            this.tabCurrentInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentItemCount)).BeginInit();
            this.tabPreviousInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.cmsPreviousItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrevItemCount)).BeginInit();
            this.tabCharacter.SuspendLayout();
            this.tabCharacterContainer.SuspendLayout();
            this.tabAdol.SuspendLayout();
            this.tabAdolInfoContainer.SuspendLayout();
            this.tabIAdalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdolMaxHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdolLvl)).BeginInit();
            this.tabAdolEquipped.SuspendLayout();
            this.tabAdolSkills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdolSkillRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdol)).BeginInit();
            this.tabLaxia.SuspendLayout();
            this.tabLaxiaInfoContainer.SuspendLayout();
            this.tabLaxiaInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLaxiaMaxHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLaxiaLvl)).BeginInit();
            this.tabLaxiaEquipped.SuspendLayout();
            this.tabLaxiaSkills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLaxia)).BeginInit();
            this.tabSahad.SuspendLayout();
            this.tabSahadInfoContainer.SuspendLayout();
            this.tabSahadInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSahadMaxHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSahadLvl)).BeginInit();
            this.tabSahadEquipped.SuspendLayout();
            this.tabSahadSkills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSahad)).BeginInit();
            this.tabHummel.SuspendLayout();
            this.tabHummInfoContainer.SuspendLayout();
            this.tabHummInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHummMaxHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHummLvl)).BeginInit();
            this.tabHummEquipped.SuspendLayout();
            this.tabHummSkills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHummel)).BeginInit();
            this.tabRicotta.SuspendLayout();
            this.tabRicoInfoContainer.SuspendLayout();
            this.tabRicoInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRicoMaxHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRicoLvl)).BeginInit();
            this.tabRicoEquppied.SuspendLayout();
            this.tabRicoSkills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRicotta)).BeginInit();
            this.tabDana.SuspendLayout();
            this.tabDanaInfoContainer.SuspendLayout();
            this.tabDanaInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDanaMaxHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDanaLvl)).BeginInit();
            this.tabDanaEquipped.SuspendLayout();
            this.tabDanaSkills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDana)).BeginInit();
            this.tabCheats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ys8CharacterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ys8CharacterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLaxiaSkillRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSahadSkillRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHummSkillRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRicoSkillRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDanaSkillRank)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsCurrentItems
            // 
            this.cmsCurrentItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmsCurrentItems.Depth = 0;
            this.cmsCurrentItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiCurrAddItem,
            this.removeItemToolStripMenuItem});
            this.cmsCurrentItems.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmsCurrentItems.Name = "cmsSaveItems";
            this.cmsCurrentItems.Size = new System.Drawing.Size(145, 48);
            this.cmsCurrentItems.Tag = "current";
            // 
            // mnuiCurrAddItem
            // 
            this.mnuiCurrAddItem.Name = "mnuiCurrAddItem";
            this.mnuiCurrAddItem.Size = new System.Drawing.Size(144, 22);
            this.mnuiCurrAddItem.Text = "Add Item";
            this.mnuiCurrAddItem.Click += new System.EventHandler(this.mnuiCurrAddItem_Click);
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.removeItemToolStripMenuItem.Text = "Remove Item";
            this.removeItemToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // sfdSaveFile
            // 
            this.sfdSaveFile.Filter = "Ys8 Save File | *.dat";
            // 
            // tabMainContainer
            // 
            this.tabMainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMainContainer.Controls.Add(this.tabFile);
            this.tabMainContainer.Controls.Add(this.tabInventory);
            this.tabMainContainer.Controls.Add(this.tabCharacter);
            this.tabMainContainer.Controls.Add(this.tabCheats);
            this.tabMainContainer.Depth = 0;
            this.tabMainContainer.Location = new System.Drawing.Point(12, 78);
            this.tabMainContainer.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabMainContainer.Name = "tabMainContainer";
            this.tabMainContainer.SelectedIndex = 0;
            this.tabMainContainer.Size = new System.Drawing.Size(626, 450);
            this.tabMainContainer.TabIndex = 1;
            // 
            // tabFile
            // 
            this.tabFile.Controls.Add(this.materialRaisedButton2);
            this.tabFile.Controls.Add(this.materialRaisedButton1);
            this.tabFile.Controls.Add(this.btnSave);
            this.tabFile.Location = new System.Drawing.Point(4, 22);
            this.tabFile.Name = "tabFile";
            this.tabFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabFile.Size = new System.Drawing.Size(618, 424);
            this.tabFile.TabIndex = 0;
            this.tabFile.Text = "File";
            this.tabFile.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(6, 116);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(606, 23);
            this.materialRaisedButton2.TabIndex = 3;
            this.materialRaisedButton2.Text = "Load";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(6, 174);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(606, 23);
            this.materialRaisedButton1.TabIndex = 2;
            this.materialRaisedButton1.Text = "Exit";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(6, 145);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(606, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.materialTabSelector4);
            this.tabInventory.Controls.Add(this.tabInventoryContainer);
            this.tabInventory.Location = new System.Drawing.Point(4, 22);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(618, 424);
            this.tabInventory.TabIndex = 1;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector4
            // 
            this.materialTabSelector4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector4.BaseTabControl = this.tabInventoryContainer;
            this.materialTabSelector4.Depth = 0;
            this.materialTabSelector4.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector4.Name = "materialTabSelector4";
            this.materialTabSelector4.Size = new System.Drawing.Size(622, 23);
            this.materialTabSelector4.TabIndex = 3;
            this.materialTabSelector4.Text = "materialTabSelector4";
            // 
            // tabInventoryContainer
            // 
            this.tabInventoryContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabInventoryContainer.ContextMenuStrip = this.cmsCurrentItems;
            this.tabInventoryContainer.Controls.Add(this.tabCurrentInventory);
            this.tabInventoryContainer.Controls.Add(this.tabPreviousInventory);
            this.tabInventoryContainer.Depth = 0;
            this.tabInventoryContainer.Location = new System.Drawing.Point(0, 29);
            this.tabInventoryContainer.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabInventoryContainer.Name = "tabInventoryContainer";
            this.tabInventoryContainer.SelectedIndex = 0;
            this.tabInventoryContainer.Size = new System.Drawing.Size(622, 399);
            this.tabInventoryContainer.TabIndex = 1;
            // 
            // tabCurrentInventory
            // 
            this.tabCurrentInventory.Controls.Add(this.splitContainer1);
            this.tabCurrentInventory.Location = new System.Drawing.Point(4, 22);
            this.tabCurrentInventory.Name = "tabCurrentInventory";
            this.tabCurrentInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabCurrentInventory.Size = new System.Drawing.Size(614, 373);
            this.tabCurrentInventory.TabIndex = 0;
            this.tabCurrentInventory.Text = "Current";
            this.tabCurrentInventory.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvCurrentInventory);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblCurrentItemRank);
            this.splitContainer1.Panel2.Controls.Add(this.materialLabel6);
            this.splitContainer1.Panel2.Controls.Add(this.nudCurrentItemCount);
            this.splitContainer1.Panel2.Controls.Add(this.lblCurrentItemCount);
            this.splitContainer1.Panel2.Controls.Add(this.lblCurrentItemName);
            this.splitContainer1.Panel2.Controls.Add(this.lblCurrentItemId);
            this.splitContainer1.Panel2.Controls.Add(this.lblCurrentItemType);
            this.splitContainer1.Panel2.Controls.Add(this.materialLabel5);
            this.splitContainer1.Panel2.Controls.Add(this.materialLabel4);
            this.splitContainer1.Panel2.Controls.Add(this.materialLabel3);
            this.splitContainer1.Panel2.Controls.Add(this.lblCurrentItemDescription);
            this.splitContainer1.Panel2.Controls.Add(this.materialLabel2);
            this.splitContainer1.Panel2.Controls.Add(this.lblCurrentItemEffect);
            this.splitContainer1.Panel2.Controls.Add(this.materialLabel1);
            this.splitContainer1.Size = new System.Drawing.Size(608, 367);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 2;
            // 
            // trvCurrentInventory
            // 
            this.trvCurrentInventory.ContextMenuStrip = this.cmsCurrentItems;
            this.trvCurrentInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvCurrentInventory.Location = new System.Drawing.Point(0, 0);
            this.trvCurrentInventory.Name = "trvCurrentInventory";
            this.trvCurrentInventory.Size = new System.Drawing.Size(200, 367);
            this.trvCurrentInventory.TabIndex = 0;
            this.trvCurrentInventory.Tag = "current";
            this.trvCurrentInventory.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvObjectInventory_NodeMouseClick);
            this.trvCurrentInventory.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewObject_NodeMouseDoubleClick);
            // 
            // lblCurrentItemRank
            // 
            this.lblCurrentItemRank.AutoSize = true;
            this.lblCurrentItemRank.Depth = 0;
            this.lblCurrentItemRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCurrentItemRank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCurrentItemRank.Location = new System.Drawing.Point(102, 73);
            this.lblCurrentItemRank.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentItemRank.Name = "lblCurrentItemRank";
            this.lblCurrentItemRank.Size = new System.Drawing.Size(64, 18);
            this.lblCurrentItemRank.TabIndex = 14;
            this.lblCurrentItemRank.Tag = "current";
            this.lblCurrentItemRank.Text = "<Temp>";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(8, 73);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(43, 18);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = "Rank";
            // 
            // nudCurrentItemCount
            // 
            this.nudCurrentItemCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCurrentItemCount.Location = new System.Drawing.Point(12, 149);
            this.nudCurrentItemCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudCurrentItemCount.Name = "nudCurrentItemCount";
            this.nudCurrentItemCount.Size = new System.Drawing.Size(393, 20);
            this.nudCurrentItemCount.TabIndex = 12;
            this.nudCurrentItemCount.Tag = "current";
            this.nudCurrentItemCount.Visible = false;
            // 
            // lblCurrentItemCount
            // 
            this.lblCurrentItemCount.AutoSize = true;
            this.lblCurrentItemCount.Depth = 0;
            this.lblCurrentItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCurrentItemCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCurrentItemCount.Location = new System.Drawing.Point(9, 128);
            this.lblCurrentItemCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentItemCount.Name = "lblCurrentItemCount";
            this.lblCurrentItemCount.Size = new System.Drawing.Size(48, 18);
            this.lblCurrentItemCount.TabIndex = 11;
            this.lblCurrentItemCount.Text = "Count";
            this.lblCurrentItemCount.Visible = false;
            // 
            // lblCurrentItemName
            // 
            this.lblCurrentItemName.AutoSize = true;
            this.lblCurrentItemName.Depth = 0;
            this.lblCurrentItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCurrentItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCurrentItemName.Location = new System.Drawing.Point(103, 17);
            this.lblCurrentItemName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentItemName.Name = "lblCurrentItemName";
            this.lblCurrentItemName.Size = new System.Drawing.Size(64, 18);
            this.lblCurrentItemName.TabIndex = 10;
            this.lblCurrentItemName.Tag = "curr_item_name";
            this.lblCurrentItemName.Text = "<Temp>";
            // 
            // lblCurrentItemId
            // 
            this.lblCurrentItemId.AutoSize = true;
            this.lblCurrentItemId.Depth = 0;
            this.lblCurrentItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCurrentItemId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCurrentItemId.Location = new System.Drawing.Point(103, 36);
            this.lblCurrentItemId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentItemId.Name = "lblCurrentItemId";
            this.lblCurrentItemId.Size = new System.Drawing.Size(64, 18);
            this.lblCurrentItemId.TabIndex = 9;
            this.lblCurrentItemId.Tag = "curr_item_id";
            this.lblCurrentItemId.Text = "<Temp>";
            // 
            // lblCurrentItemType
            // 
            this.lblCurrentItemType.AutoSize = true;
            this.lblCurrentItemType.Depth = 0;
            this.lblCurrentItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCurrentItemType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCurrentItemType.Location = new System.Drawing.Point(103, 55);
            this.lblCurrentItemType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentItemType.Name = "lblCurrentItemType";
            this.lblCurrentItemType.Size = new System.Drawing.Size(64, 18);
            this.lblCurrentItemType.TabIndex = 8;
            this.lblCurrentItemType.Tag = "curr_item_type";
            this.lblCurrentItemType.Text = "<Temp>";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(9, 36);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(22, 18);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "ID";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(9, 55);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(40, 18);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Type";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(9, 17);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(48, 18);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Name";
            // 
            // lblCurrentItemDescription
            // 
            this.lblCurrentItemDescription.AutoSize = true;
            this.lblCurrentItemDescription.Depth = 0;
            this.lblCurrentItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCurrentItemDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCurrentItemDescription.Location = new System.Drawing.Point(103, 110);
            this.lblCurrentItemDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentItemDescription.Name = "lblCurrentItemDescription";
            this.lblCurrentItemDescription.Size = new System.Drawing.Size(64, 18);
            this.lblCurrentItemDescription.TabIndex = 4;
            this.lblCurrentItemDescription.Tag = "current";
            this.lblCurrentItemDescription.Text = "<Temp>";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(9, 110);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(83, 18);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Description";
            // 
            // lblCurrentItemEffect
            // 
            this.lblCurrentItemEffect.AutoSize = true;
            this.lblCurrentItemEffect.Depth = 0;
            this.lblCurrentItemEffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCurrentItemEffect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCurrentItemEffect.Location = new System.Drawing.Point(103, 92);
            this.lblCurrentItemEffect.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentItemEffect.Name = "lblCurrentItemEffect";
            this.lblCurrentItemEffect.Size = new System.Drawing.Size(64, 18);
            this.lblCurrentItemEffect.TabIndex = 2;
            this.lblCurrentItemEffect.Tag = "current";
            this.lblCurrentItemEffect.Text = "<Temp>";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(9, 92);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 18);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Effect";
            // 
            // tabPreviousInventory
            // 
            this.tabPreviousInventory.Controls.Add(this.splitContainer2);
            this.tabPreviousInventory.Location = new System.Drawing.Point(4, 22);
            this.tabPreviousInventory.Name = "tabPreviousInventory";
            this.tabPreviousInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPreviousInventory.Size = new System.Drawing.Size(614, 373);
            this.tabPreviousInventory.TabIndex = 1;
            this.tabPreviousInventory.Text = "Previous";
            this.tabPreviousInventory.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.trvPreviousInventory);
            this.splitContainer2.Panel1MinSize = 200;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lblPrevItemRank);
            this.splitContainer2.Panel2.Controls.Add(this.materialLabel33);
            this.splitContainer2.Panel2.Controls.Add(this.nudPrevItemCount);
            this.splitContainer2.Panel2.Controls.Add(this.lblPrevItemCount);
            this.splitContainer2.Panel2.Controls.Add(this.lblPrevItemName);
            this.splitContainer2.Panel2.Controls.Add(this.lblPrevItemId);
            this.splitContainer2.Panel2.Controls.Add(this.lblPrevItemType);
            this.splitContainer2.Panel2.Controls.Add(this.materialLabel38);
            this.splitContainer2.Panel2.Controls.Add(this.materialLabel39);
            this.splitContainer2.Panel2.Controls.Add(this.materialLabel40);
            this.splitContainer2.Panel2.Controls.Add(this.lblPrevItemDescription);
            this.splitContainer2.Panel2.Controls.Add(this.materialLabel42);
            this.splitContainer2.Panel2.Controls.Add(this.lblPrevItemEffect);
            this.splitContainer2.Panel2.Controls.Add(this.materialLabel44);
            this.splitContainer2.Size = new System.Drawing.Size(608, 367);
            this.splitContainer2.SplitterDistance = 200;
            this.splitContainer2.TabIndex = 3;
            // 
            // trvPreviousInventory
            // 
            this.trvPreviousInventory.ContextMenuStrip = this.cmsPreviousItems;
            this.trvPreviousInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvPreviousInventory.Location = new System.Drawing.Point(0, 0);
            this.trvPreviousInventory.Name = "trvPreviousInventory";
            this.trvPreviousInventory.Size = new System.Drawing.Size(200, 367);
            this.trvPreviousInventory.TabIndex = 0;
            this.trvPreviousInventory.Tag = "previous";
            this.trvPreviousInventory.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvObjectInventory_NodeMouseClick);
            this.trvPreviousInventory.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewObject_NodeMouseDoubleClick);
            // 
            // cmsPreviousItems
            // 
            this.cmsPreviousItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmsPreviousItems.Depth = 0;
            this.cmsPreviousItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiPrevAddItem,
            this.toolStripMenuItem2});
            this.cmsPreviousItems.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmsPreviousItems.Name = "cmsSaveItems";
            this.cmsPreviousItems.Size = new System.Drawing.Size(145, 48);
            this.cmsPreviousItems.Tag = "previous";
            // 
            // mnuiPrevAddItem
            // 
            this.mnuiPrevAddItem.Name = "mnuiPrevAddItem";
            this.mnuiPrevAddItem.Size = new System.Drawing.Size(144, 22);
            this.mnuiPrevAddItem.Text = "Add Item";
            this.mnuiPrevAddItem.Click += new System.EventHandler(this.mnuiPrevAddItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItem2.Text = "Remove Item";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // lblPrevItemRank
            // 
            this.lblPrevItemRank.AutoSize = true;
            this.lblPrevItemRank.Depth = 0;
            this.lblPrevItemRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPrevItemRank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrevItemRank.Location = new System.Drawing.Point(102, 73);
            this.lblPrevItemRank.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrevItemRank.Name = "lblPrevItemRank";
            this.lblPrevItemRank.Size = new System.Drawing.Size(64, 18);
            this.lblPrevItemRank.TabIndex = 14;
            this.lblPrevItemRank.Tag = "previous";
            this.lblPrevItemRank.Text = "<Temp>";
            // 
            // materialLabel33
            // 
            this.materialLabel33.AutoSize = true;
            this.materialLabel33.Depth = 0;
            this.materialLabel33.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel33.Location = new System.Drawing.Point(8, 73);
            this.materialLabel33.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel33.Name = "materialLabel33";
            this.materialLabel33.Size = new System.Drawing.Size(43, 18);
            this.materialLabel33.TabIndex = 13;
            this.materialLabel33.Text = "Rank";
            // 
            // nudPrevItemCount
            // 
            this.nudPrevItemCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPrevItemCount.Location = new System.Drawing.Point(12, 149);
            this.nudPrevItemCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudPrevItemCount.Name = "nudPrevItemCount";
            this.nudPrevItemCount.Size = new System.Drawing.Size(393, 20);
            this.nudPrevItemCount.TabIndex = 12;
            this.nudPrevItemCount.Tag = "previous";
            this.nudPrevItemCount.Visible = false;
            // 
            // lblPrevItemCount
            // 
            this.lblPrevItemCount.AutoSize = true;
            this.lblPrevItemCount.Depth = 0;
            this.lblPrevItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPrevItemCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrevItemCount.Location = new System.Drawing.Point(9, 128);
            this.lblPrevItemCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrevItemCount.Name = "lblPrevItemCount";
            this.lblPrevItemCount.Size = new System.Drawing.Size(48, 18);
            this.lblPrevItemCount.TabIndex = 11;
            this.lblPrevItemCount.Text = "Count";
            this.lblPrevItemCount.Visible = false;
            // 
            // lblPrevItemName
            // 
            this.lblPrevItemName.AutoSize = true;
            this.lblPrevItemName.Depth = 0;
            this.lblPrevItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPrevItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrevItemName.Location = new System.Drawing.Point(103, 17);
            this.lblPrevItemName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrevItemName.Name = "lblPrevItemName";
            this.lblPrevItemName.Size = new System.Drawing.Size(64, 18);
            this.lblPrevItemName.TabIndex = 10;
            this.lblPrevItemName.Tag = "previous";
            this.lblPrevItemName.Text = "<Temp>";
            // 
            // lblPrevItemId
            // 
            this.lblPrevItemId.AutoSize = true;
            this.lblPrevItemId.Depth = 0;
            this.lblPrevItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPrevItemId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrevItemId.Location = new System.Drawing.Point(103, 36);
            this.lblPrevItemId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrevItemId.Name = "lblPrevItemId";
            this.lblPrevItemId.Size = new System.Drawing.Size(64, 18);
            this.lblPrevItemId.TabIndex = 9;
            this.lblPrevItemId.Tag = "previous";
            this.lblPrevItemId.Text = "<Temp>";
            // 
            // lblPrevItemType
            // 
            this.lblPrevItemType.AutoSize = true;
            this.lblPrevItemType.Depth = 0;
            this.lblPrevItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPrevItemType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrevItemType.Location = new System.Drawing.Point(103, 55);
            this.lblPrevItemType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrevItemType.Name = "lblPrevItemType";
            this.lblPrevItemType.Size = new System.Drawing.Size(64, 18);
            this.lblPrevItemType.TabIndex = 8;
            this.lblPrevItemType.Tag = "previous";
            this.lblPrevItemType.Text = "<Temp>";
            // 
            // materialLabel38
            // 
            this.materialLabel38.AutoSize = true;
            this.materialLabel38.Depth = 0;
            this.materialLabel38.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel38.Location = new System.Drawing.Point(9, 36);
            this.materialLabel38.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel38.Name = "materialLabel38";
            this.materialLabel38.Size = new System.Drawing.Size(22, 18);
            this.materialLabel38.TabIndex = 7;
            this.materialLabel38.Text = "ID";
            // 
            // materialLabel39
            // 
            this.materialLabel39.AutoSize = true;
            this.materialLabel39.Depth = 0;
            this.materialLabel39.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel39.Location = new System.Drawing.Point(9, 55);
            this.materialLabel39.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel39.Name = "materialLabel39";
            this.materialLabel39.Size = new System.Drawing.Size(40, 18);
            this.materialLabel39.TabIndex = 6;
            this.materialLabel39.Text = "Type";
            // 
            // materialLabel40
            // 
            this.materialLabel40.AutoSize = true;
            this.materialLabel40.Depth = 0;
            this.materialLabel40.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel40.Location = new System.Drawing.Point(9, 17);
            this.materialLabel40.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel40.Name = "materialLabel40";
            this.materialLabel40.Size = new System.Drawing.Size(48, 18);
            this.materialLabel40.TabIndex = 5;
            this.materialLabel40.Text = "Name";
            // 
            // lblPrevItemDescription
            // 
            this.lblPrevItemDescription.AutoSize = true;
            this.lblPrevItemDescription.Depth = 0;
            this.lblPrevItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPrevItemDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrevItemDescription.Location = new System.Drawing.Point(103, 110);
            this.lblPrevItemDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrevItemDescription.Name = "lblPrevItemDescription";
            this.lblPrevItemDescription.Size = new System.Drawing.Size(64, 18);
            this.lblPrevItemDescription.TabIndex = 4;
            this.lblPrevItemDescription.Tag = "previous";
            this.lblPrevItemDescription.Text = "<Temp>";
            // 
            // materialLabel42
            // 
            this.materialLabel42.AutoSize = true;
            this.materialLabel42.Depth = 0;
            this.materialLabel42.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel42.Location = new System.Drawing.Point(9, 110);
            this.materialLabel42.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel42.Name = "materialLabel42";
            this.materialLabel42.Size = new System.Drawing.Size(83, 18);
            this.materialLabel42.TabIndex = 3;
            this.materialLabel42.Text = "Description";
            // 
            // lblPrevItemEffect
            // 
            this.lblPrevItemEffect.AutoSize = true;
            this.lblPrevItemEffect.Depth = 0;
            this.lblPrevItemEffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPrevItemEffect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrevItemEffect.Location = new System.Drawing.Point(103, 92);
            this.lblPrevItemEffect.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrevItemEffect.Name = "lblPrevItemEffect";
            this.lblPrevItemEffect.Size = new System.Drawing.Size(64, 18);
            this.lblPrevItemEffect.TabIndex = 2;
            this.lblPrevItemEffect.Tag = "previous";
            this.lblPrevItemEffect.Text = "<Temp>";
            // 
            // materialLabel44
            // 
            this.materialLabel44.AutoSize = true;
            this.materialLabel44.Depth = 0;
            this.materialLabel44.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel44.Location = new System.Drawing.Point(9, 92);
            this.materialLabel44.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel44.Name = "materialLabel44";
            this.materialLabel44.Size = new System.Drawing.Size(46, 18);
            this.materialLabel44.TabIndex = 1;
            this.materialLabel44.Text = "Effect";
            // 
            // tabCharacter
            // 
            this.tabCharacter.Controls.Add(this.materialTabSelector2);
            this.tabCharacter.Controls.Add(this.tabCharacterContainer);
            this.tabCharacter.Location = new System.Drawing.Point(4, 22);
            this.tabCharacter.Name = "tabCharacter";
            this.tabCharacter.Size = new System.Drawing.Size(618, 424);
            this.tabCharacter.TabIndex = 2;
            this.tabCharacter.Text = "Characters";
            this.tabCharacter.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector2.BaseTabControl = this.tabCharacterContainer;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(3, 0);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(604, 23);
            this.materialTabSelector2.TabIndex = 0;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // tabCharacterContainer
            // 
            this.tabCharacterContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCharacterContainer.Controls.Add(this.tabAdol);
            this.tabCharacterContainer.Controls.Add(this.tabLaxia);
            this.tabCharacterContainer.Controls.Add(this.tabSahad);
            this.tabCharacterContainer.Controls.Add(this.tabHummel);
            this.tabCharacterContainer.Controls.Add(this.tabRicotta);
            this.tabCharacterContainer.Controls.Add(this.tabDana);
            this.tabCharacterContainer.Depth = 0;
            this.tabCharacterContainer.Location = new System.Drawing.Point(3, 29);
            this.tabCharacterContainer.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabCharacterContainer.Name = "tabCharacterContainer";
            this.tabCharacterContainer.SelectedIndex = 0;
            this.tabCharacterContainer.Size = new System.Drawing.Size(608, 395);
            this.tabCharacterContainer.TabIndex = 0;
            this.tabCharacterContainer.Tag = "";
            // 
            // tabAdol
            // 
            this.tabAdol.Controls.Add(this.selCharacterInformation);
            this.tabAdol.Controls.Add(this.tabAdolInfoContainer);
            this.tabAdol.Controls.Add(this.picAdol);
            this.tabAdol.Location = new System.Drawing.Point(4, 22);
            this.tabAdol.Name = "tabAdol";
            this.tabAdol.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdol.Size = new System.Drawing.Size(600, 369);
            this.tabAdol.TabIndex = 0;
            this.tabAdol.Tag = "Adol";
            this.tabAdol.Text = "Adol";
            this.tabAdol.UseVisualStyleBackColor = true;
            // 
            // selCharacterInformation
            // 
            this.selCharacterInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selCharacterInformation.BaseTabControl = this.tabAdolInfoContainer;
            this.selCharacterInformation.Depth = 0;
            this.selCharacterInformation.Location = new System.Drawing.Point(191, 0);
            this.selCharacterInformation.MouseState = MaterialSkin.MouseState.HOVER;
            this.selCharacterInformation.Name = "selCharacterInformation";
            this.selCharacterInformation.Size = new System.Drawing.Size(403, 23);
            this.selCharacterInformation.TabIndex = 0;
            this.selCharacterInformation.Text = "materialTabSelector3";
            // 
            // tabAdolInfoContainer
            // 
            this.tabAdolInfoContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabAdolInfoContainer.Controls.Add(this.tabIAdalInfo);
            this.tabAdolInfoContainer.Controls.Add(this.tabAdolEquipped);
            this.tabAdolInfoContainer.Controls.Add(this.tabAdolSkills);
            this.tabAdolInfoContainer.Depth = 0;
            this.tabAdolInfoContainer.Location = new System.Drawing.Point(194, 29);
            this.tabAdolInfoContainer.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabAdolInfoContainer.Name = "tabAdolInfoContainer";
            this.tabAdolInfoContainer.SelectedIndex = 0;
            this.tabAdolInfoContainer.Size = new System.Drawing.Size(400, 344);
            this.tabAdolInfoContainer.TabIndex = 7;
            this.tabAdolInfoContainer.Tag = "adol";
            // 
            // tabIAdalInfo
            // 
            this.tabIAdalInfo.Controls.Add(this.chkAdolHp);
            this.tabIAdalInfo.Controls.Add(this.materialLabel62);
            this.tabIAdalInfo.Controls.Add(this.nudAdolMaxHp);
            this.tabIAdalInfo.Controls.Add(this.materialLabel7);
            this.tabIAdalInfo.Controls.Add(this.materialLabel8);
            this.tabIAdalInfo.Controls.Add(this.nudAdolLvl);
            this.tabIAdalInfo.Controls.Add(this.lblCharacterName);
            this.tabIAdalInfo.Location = new System.Drawing.Point(4, 22);
            this.tabIAdalInfo.Name = "tabIAdalInfo";
            this.tabIAdalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabIAdalInfo.Size = new System.Drawing.Size(392, 318);
            this.tabIAdalInfo.TabIndex = 0;
            this.tabIAdalInfo.Text = "Information";
            this.tabIAdalInfo.UseVisualStyleBackColor = true;
            // 
            // chkAdolHp
            // 
            this.chkAdolHp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAdolHp.AutoSize = true;
            this.chkAdolHp.Depth = 0;
            this.chkAdolHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkAdolHp.Location = new System.Drawing.Point(215, 45);
            this.chkAdolHp.Margin = new System.Windows.Forms.Padding(0);
            this.chkAdolHp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAdolHp.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAdolHp.Name = "chkAdolHp";
            this.chkAdolHp.Ripple = true;
            this.chkAdolHp.Size = new System.Drawing.Size(56, 30);
            this.chkAdolHp.TabIndex = 8;
            this.chkAdolHp.Tag = "adol";
            this.chkAdolHp.Text = "Max";
            this.chkAdolHp.UseVisualStyleBackColor = true;
            this.chkAdolHp.CheckedChanged += new System.EventHandler(this.chkCharacterMaxHp_CheckedChanged);
            // 
            // materialLabel62
            // 
            this.materialLabel62.AutoSize = true;
            this.materialLabel62.Depth = 0;
            this.materialLabel62.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel62.Location = new System.Drawing.Point(6, 49);
            this.materialLabel62.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel62.Name = "materialLabel62";
            this.materialLabel62.Size = new System.Drawing.Size(63, 18);
            this.materialLabel62.TabIndex = 6;
            this.materialLabel62.Text = "Max Hp:";
            // 
            // nudAdolMaxHp
            // 
            this.nudAdolMaxHp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAdolMaxHp.Location = new System.Drawing.Point(76, 51);
            this.nudAdolMaxHp.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudAdolMaxHp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdolMaxHp.Name = "nudAdolMaxHp";
            this.nudAdolMaxHp.Size = new System.Drawing.Size(136, 20);
            this.nudAdolMaxHp.TabIndex = 7;
            this.nudAdolMaxHp.Tag = "";
            this.nudAdolMaxHp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(6, 3);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(52, 18);
            this.materialLabel7.TabIndex = 2;
            this.materialLabel7.Text = "Name:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(6, 23);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(46, 18);
            this.materialLabel8.TabIndex = 3;
            this.materialLabel8.Text = "Level:";
            // 
            // nudAdolLvl
            // 
            this.nudAdolLvl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAdolLvl.Location = new System.Drawing.Point(76, 25);
            this.nudAdolLvl.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudAdolLvl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdolLvl.Name = "nudAdolLvl";
            this.nudAdolLvl.Size = new System.Drawing.Size(136, 20);
            this.nudAdolLvl.TabIndex = 5;
            this.nudAdolLvl.Tag = "adol";
            this.nudAdolLvl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Depth = 0;
            this.lblCharacterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCharacterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCharacterName.Location = new System.Drawing.Point(72, 3);
            this.lblCharacterName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(91, 18);
            this.lblCharacterName.TabIndex = 4;
            this.lblCharacterName.Text = "Adol Christin";
            // 
            // tabAdolEquipped
            // 
            this.tabAdolEquipped.Controls.Add(this.cmbAdolArmEq);
            this.tabAdolEquipped.Controls.Add(this.materialLabel9);
            this.tabAdolEquipped.Controls.Add(this.cmbAdolAccessory2Eq);
            this.tabAdolEquipped.Controls.Add(this.cmbAdolAccessory1Eq);
            this.tabAdolEquipped.Controls.Add(this.materialLabel29);
            this.tabAdolEquipped.Controls.Add(this.materialLabel28);
            this.tabAdolEquipped.Controls.Add(this.cmbAdolBodyEq);
            this.tabAdolEquipped.Controls.Add(this.materialLabel27);
            this.tabAdolEquipped.Controls.Add(this.cmbAdolWeaponEq);
            this.tabAdolEquipped.Controls.Add(this.materialLabel26);
            this.tabAdolEquipped.Location = new System.Drawing.Point(4, 22);
            this.tabAdolEquipped.Name = "tabAdolEquipped";
            this.tabAdolEquipped.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdolEquipped.Size = new System.Drawing.Size(392, 318);
            this.tabAdolEquipped.TabIndex = 1;
            this.tabAdolEquipped.Text = "Equipped";
            this.tabAdolEquipped.UseVisualStyleBackColor = true;
            // 
            // cmbAdolArmEq
            // 
            this.cmbAdolArmEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAdolArmEq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdolArmEq.FormattingEnabled = true;
            this.cmbAdolArmEq.Location = new System.Drawing.Point(108, 64);
            this.cmbAdolArmEq.Name = "cmbAdolArmEq";
            this.cmbAdolArmEq.Size = new System.Drawing.Size(275, 21);
            this.cmbAdolArmEq.TabIndex = 27;
            this.cmbAdolArmEq.Tag = "";
            this.cmbAdolArmEq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(3, 63);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(35, 18);
            this.materialLabel9.TabIndex = 26;
            this.materialLabel9.Text = "Arm";
            // 
            // cmbAdolAccessory2Eq
            // 
            this.cmbAdolAccessory2Eq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAdolAccessory2Eq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdolAccessory2Eq.FormattingEnabled = true;
            this.cmbAdolAccessory2Eq.Location = new System.Drawing.Point(108, 118);
            this.cmbAdolAccessory2Eq.Name = "cmbAdolAccessory2Eq";
            this.cmbAdolAccessory2Eq.Size = new System.Drawing.Size(275, 21);
            this.cmbAdolAccessory2Eq.TabIndex = 25;
            this.cmbAdolAccessory2Eq.Tag = "";
            this.cmbAdolAccessory2Eq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // cmbAdolAccessory1Eq
            // 
            this.cmbAdolAccessory1Eq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAdolAccessory1Eq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdolAccessory1Eq.FormattingEnabled = true;
            this.cmbAdolAccessory1Eq.Location = new System.Drawing.Point(108, 91);
            this.cmbAdolAccessory1Eq.Name = "cmbAdolAccessory1Eq";
            this.cmbAdolAccessory1Eq.Size = new System.Drawing.Size(275, 21);
            this.cmbAdolAccessory1Eq.TabIndex = 24;
            this.cmbAdolAccessory1Eq.Tag = "";
            this.cmbAdolAccessory1Eq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel29
            // 
            this.materialLabel29.AutoSize = true;
            this.materialLabel29.Depth = 0;
            this.materialLabel29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel29.Location = new System.Drawing.Point(3, 117);
            this.materialLabel29.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel29.Name = "materialLabel29";
            this.materialLabel29.Size = new System.Drawing.Size(90, 18);
            this.materialLabel29.TabIndex = 20;
            this.materialLabel29.Text = "Accessory 2";
            // 
            // materialLabel28
            // 
            this.materialLabel28.AutoSize = true;
            this.materialLabel28.Depth = 0;
            this.materialLabel28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel28.Location = new System.Drawing.Point(3, 90);
            this.materialLabel28.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel28.Name = "materialLabel28";
            this.materialLabel28.Size = new System.Drawing.Size(90, 18);
            this.materialLabel28.TabIndex = 19;
            this.materialLabel28.Text = "Accessory 1";
            // 
            // cmbAdolBodyEq
            // 
            this.cmbAdolBodyEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAdolBodyEq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdolBodyEq.FormattingEnabled = true;
            this.cmbAdolBodyEq.Location = new System.Drawing.Point(108, 37);
            this.cmbAdolBodyEq.Name = "cmbAdolBodyEq";
            this.cmbAdolBodyEq.Size = new System.Drawing.Size(275, 21);
            this.cmbAdolBodyEq.TabIndex = 18;
            this.cmbAdolBodyEq.Tag = "";
            this.cmbAdolBodyEq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel27
            // 
            this.materialLabel27.AutoSize = true;
            this.materialLabel27.Depth = 0;
            this.materialLabel27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel27.Location = new System.Drawing.Point(3, 36);
            this.materialLabel27.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel27.Name = "materialLabel27";
            this.materialLabel27.Size = new System.Drawing.Size(42, 18);
            this.materialLabel27.TabIndex = 17;
            this.materialLabel27.Text = "Body";
            // 
            // cmbAdolWeaponEq
            // 
            this.cmbAdolWeaponEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAdolWeaponEq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdolWeaponEq.FormattingEnabled = true;
            this.cmbAdolWeaponEq.Location = new System.Drawing.Point(108, 10);
            this.cmbAdolWeaponEq.Name = "cmbAdolWeaponEq";
            this.cmbAdolWeaponEq.Size = new System.Drawing.Size(275, 21);
            this.cmbAdolWeaponEq.TabIndex = 16;
            this.cmbAdolWeaponEq.Tag = "";
            this.cmbAdolWeaponEq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel26
            // 
            this.materialLabel26.AutoSize = true;
            this.materialLabel26.Depth = 0;
            this.materialLabel26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel26.Location = new System.Drawing.Point(3, 12);
            this.materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel26.Name = "materialLabel26";
            this.materialLabel26.Size = new System.Drawing.Size(64, 18);
            this.materialLabel26.TabIndex = 15;
            this.materialLabel26.Text = "Weapon";
            // 
            // tabAdolSkills
            // 
            this.tabAdolSkills.Controls.Add(this.chkAdolSkillUnlocked);
            this.tabAdolSkills.Controls.Add(this.nudAdolSkillRank);
            this.tabAdolSkills.Controls.Add(this.materialLabel68);
            this.tabAdolSkills.Controls.Add(this.lstAdolSkills);
            this.tabAdolSkills.Location = new System.Drawing.Point(4, 22);
            this.tabAdolSkills.Name = "tabAdolSkills";
            this.tabAdolSkills.Size = new System.Drawing.Size(392, 318);
            this.tabAdolSkills.TabIndex = 2;
            this.tabAdolSkills.Text = "Skills";
            this.tabAdolSkills.UseVisualStyleBackColor = true;
            // 
            // chkAdolSkillUnlocked
            // 
            this.chkAdolSkillUnlocked.AutoSize = true;
            this.chkAdolSkillUnlocked.Depth = 0;
            this.chkAdolSkillUnlocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkAdolSkillUnlocked.Location = new System.Drawing.Point(154, 29);
            this.chkAdolSkillUnlocked.Margin = new System.Windows.Forms.Padding(0);
            this.chkAdolSkillUnlocked.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAdolSkillUnlocked.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAdolSkillUnlocked.Name = "chkAdolSkillUnlocked";
            this.chkAdolSkillUnlocked.Ripple = true;
            this.chkAdolSkillUnlocked.Size = new System.Drawing.Size(87, 30);
            this.chkAdolSkillUnlocked.TabIndex = 3;
            this.chkAdolSkillUnlocked.Text = "Unlocked";
            this.chkAdolSkillUnlocked.UseVisualStyleBackColor = true;
            // 
            // nudAdolSkillRank
            // 
            this.nudAdolSkillRank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAdolSkillRank.Location = new System.Drawing.Point(201, 6);
            this.nudAdolSkillRank.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudAdolSkillRank.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdolSkillRank.Name = "nudAdolSkillRank";
            this.nudAdolSkillRank.Size = new System.Drawing.Size(188, 20);
            this.nudAdolSkillRank.TabIndex = 2;
            this.nudAdolSkillRank.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // materialLabel68
            // 
            this.materialLabel68.AutoSize = true;
            this.materialLabel68.Depth = 0;
            this.materialLabel68.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel68.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel68.Location = new System.Drawing.Point(151, 4);
            this.materialLabel68.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel68.Name = "materialLabel68";
            this.materialLabel68.Size = new System.Drawing.Size(43, 18);
            this.materialLabel68.TabIndex = 1;
            this.materialLabel68.Text = "Rank";
            // 
            // lstAdolSkills
            // 
            this.lstAdolSkills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstAdolSkills.FormattingEnabled = true;
            this.lstAdolSkills.Location = new System.Drawing.Point(3, 3);
            this.lstAdolSkills.Name = "lstAdolSkills";
            this.lstAdolSkills.Size = new System.Drawing.Size(142, 303);
            this.lstAdolSkills.TabIndex = 0;
            this.lstAdolSkills.SelectedValueChanged += new System.EventHandler(this.lstCharacterSkills_SelectedValueChanged);
            // 
            // picAdol
            // 
            this.picAdol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picAdol.Image = global::Save_Editor.Properties.Resources.adol_christin;
            this.picAdol.Location = new System.Drawing.Point(0, 0);
            this.picAdol.Name = "picAdol";
            this.picAdol.Size = new System.Drawing.Size(185, 366);
            this.picAdol.TabIndex = 1;
            this.picAdol.TabStop = false;
            // 
            // tabLaxia
            // 
            this.tabLaxia.Controls.Add(this.materialTabSelector3);
            this.tabLaxia.Controls.Add(this.tabLaxiaInfoContainer);
            this.tabLaxia.Controls.Add(this.picLaxia);
            this.tabLaxia.Location = new System.Drawing.Point(4, 22);
            this.tabLaxia.Name = "tabLaxia";
            this.tabLaxia.Padding = new System.Windows.Forms.Padding(3);
            this.tabLaxia.Size = new System.Drawing.Size(600, 369);
            this.tabLaxia.TabIndex = 1;
            this.tabLaxia.Tag = "Laxia";
            this.tabLaxia.Text = "Laxia";
            this.tabLaxia.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector3
            // 
            this.materialTabSelector3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector3.BaseTabControl = this.tabLaxiaInfoContainer;
            this.materialTabSelector3.Depth = 0;
            this.materialTabSelector3.Location = new System.Drawing.Point(191, 0);
            this.materialTabSelector3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector3.Name = "materialTabSelector3";
            this.materialTabSelector3.Size = new System.Drawing.Size(403, 23);
            this.materialTabSelector3.TabIndex = 8;
            this.materialTabSelector3.Text = "materialTabSelector3";
            // 
            // tabLaxiaInfoContainer
            // 
            this.tabLaxiaInfoContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLaxiaInfoContainer.Controls.Add(this.tabLaxiaInfo);
            this.tabLaxiaInfoContainer.Controls.Add(this.tabLaxiaEquipped);
            this.tabLaxiaInfoContainer.Controls.Add(this.tabLaxiaSkills);
            this.tabLaxiaInfoContainer.Depth = 0;
            this.tabLaxiaInfoContainer.Location = new System.Drawing.Point(194, 29);
            this.tabLaxiaInfoContainer.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabLaxiaInfoContainer.Name = "tabLaxiaInfoContainer";
            this.tabLaxiaInfoContainer.SelectedIndex = 0;
            this.tabLaxiaInfoContainer.Size = new System.Drawing.Size(400, 328);
            this.tabLaxiaInfoContainer.TabIndex = 9;
            this.tabLaxiaInfoContainer.Tag = "adol";
            // 
            // tabLaxiaInfo
            // 
            this.tabLaxiaInfo.Controls.Add(this.chkLaxiaHp);
            this.tabLaxiaInfo.Controls.Add(this.materialLabel63);
            this.tabLaxiaInfo.Controls.Add(this.nudLaxiaMaxHp);
            this.tabLaxiaInfo.Controls.Add(this.materialLabel10);
            this.tabLaxiaInfo.Controls.Add(this.materialLabel11);
            this.tabLaxiaInfo.Controls.Add(this.nudLaxiaLvl);
            this.tabLaxiaInfo.Controls.Add(this.materialLabel12);
            this.tabLaxiaInfo.Location = new System.Drawing.Point(4, 22);
            this.tabLaxiaInfo.Name = "tabLaxiaInfo";
            this.tabLaxiaInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabLaxiaInfo.Size = new System.Drawing.Size(392, 302);
            this.tabLaxiaInfo.TabIndex = 0;
            this.tabLaxiaInfo.Text = "Information";
            this.tabLaxiaInfo.UseVisualStyleBackColor = true;
            // 
            // chkLaxiaHp
            // 
            this.chkLaxiaHp.AutoSize = true;
            this.chkLaxiaHp.Depth = 0;
            this.chkLaxiaHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkLaxiaHp.Location = new System.Drawing.Point(215, 45);
            this.chkLaxiaHp.Margin = new System.Windows.Forms.Padding(0);
            this.chkLaxiaHp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkLaxiaHp.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkLaxiaHp.Name = "chkLaxiaHp";
            this.chkLaxiaHp.Ripple = true;
            this.chkLaxiaHp.Size = new System.Drawing.Size(56, 30);
            this.chkLaxiaHp.TabIndex = 10;
            this.chkLaxiaHp.Tag = "";
            this.chkLaxiaHp.Text = "Max";
            this.chkLaxiaHp.UseVisualStyleBackColor = true;
            this.chkLaxiaHp.CheckedChanged += new System.EventHandler(this.chkCharacterMaxHp_CheckedChanged);
            // 
            // materialLabel63
            // 
            this.materialLabel63.AutoSize = true;
            this.materialLabel63.Depth = 0;
            this.materialLabel63.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel63.Location = new System.Drawing.Point(6, 49);
            this.materialLabel63.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel63.Name = "materialLabel63";
            this.materialLabel63.Size = new System.Drawing.Size(63, 18);
            this.materialLabel63.TabIndex = 8;
            this.materialLabel63.Text = "Max Hp:";
            // 
            // nudLaxiaMaxHp
            // 
            this.nudLaxiaMaxHp.Location = new System.Drawing.Point(76, 51);
            this.nudLaxiaMaxHp.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudLaxiaMaxHp.Name = "nudLaxiaMaxHp";
            this.nudLaxiaMaxHp.Size = new System.Drawing.Size(136, 20);
            this.nudLaxiaMaxHp.TabIndex = 9;
            this.nudLaxiaMaxHp.Tag = "laxia";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(6, 3);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(52, 18);
            this.materialLabel10.TabIndex = 2;
            this.materialLabel10.Text = "Name:";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(6, 23);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(46, 18);
            this.materialLabel11.TabIndex = 3;
            this.materialLabel11.Text = "Level:";
            // 
            // nudLaxiaLvl
            // 
            this.nudLaxiaLvl.Location = new System.Drawing.Point(76, 25);
            this.nudLaxiaLvl.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudLaxiaLvl.Name = "nudLaxiaLvl";
            this.nudLaxiaLvl.Size = new System.Drawing.Size(136, 20);
            this.nudLaxiaLvl.TabIndex = 5;
            this.nudLaxiaLvl.Tag = "laxia";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(72, 3);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(127, 18);
            this.materialLabel12.TabIndex = 4;
            this.materialLabel12.Text = "Laxia von Roswell";
            // 
            // tabLaxiaEquipped
            // 
            this.tabLaxiaEquipped.Controls.Add(this.cmbLaxiaArmEq);
            this.tabLaxiaEquipped.Controls.Add(this.materialLabel13);
            this.tabLaxiaEquipped.Controls.Add(this.cmbLaxiaAccessory2Eq);
            this.tabLaxiaEquipped.Controls.Add(this.cmbLaxiaAccessory1Eq);
            this.tabLaxiaEquipped.Controls.Add(this.materialLabel14);
            this.tabLaxiaEquipped.Controls.Add(this.materialLabel15);
            this.tabLaxiaEquipped.Controls.Add(this.cmbLaxiaBodyEq);
            this.tabLaxiaEquipped.Controls.Add(this.materialLabel16);
            this.tabLaxiaEquipped.Controls.Add(this.cmbLaxiaWeaponEq);
            this.tabLaxiaEquipped.Controls.Add(this.materialLabel17);
            this.tabLaxiaEquipped.Location = new System.Drawing.Point(4, 22);
            this.tabLaxiaEquipped.Name = "tabLaxiaEquipped";
            this.tabLaxiaEquipped.Padding = new System.Windows.Forms.Padding(3);
            this.tabLaxiaEquipped.Size = new System.Drawing.Size(392, 302);
            this.tabLaxiaEquipped.TabIndex = 1;
            this.tabLaxiaEquipped.Text = "Equipped";
            this.tabLaxiaEquipped.UseVisualStyleBackColor = true;
            // 
            // cmbLaxiaArmEq
            // 
            this.cmbLaxiaArmEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLaxiaArmEq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLaxiaArmEq.FormattingEnabled = true;
            this.cmbLaxiaArmEq.Location = new System.Drawing.Point(108, 64);
            this.cmbLaxiaArmEq.Name = "cmbLaxiaArmEq";
            this.cmbLaxiaArmEq.Size = new System.Drawing.Size(275, 21);
            this.cmbLaxiaArmEq.TabIndex = 27;
            this.cmbLaxiaArmEq.Tag = "";
            this.cmbLaxiaArmEq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(3, 63);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(35, 18);
            this.materialLabel13.TabIndex = 26;
            this.materialLabel13.Text = "Arm";
            // 
            // cmbLaxiaAccessory2Eq
            // 
            this.cmbLaxiaAccessory2Eq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLaxiaAccessory2Eq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLaxiaAccessory2Eq.FormattingEnabled = true;
            this.cmbLaxiaAccessory2Eq.Location = new System.Drawing.Point(108, 118);
            this.cmbLaxiaAccessory2Eq.Name = "cmbLaxiaAccessory2Eq";
            this.cmbLaxiaAccessory2Eq.Size = new System.Drawing.Size(275, 21);
            this.cmbLaxiaAccessory2Eq.TabIndex = 25;
            this.cmbLaxiaAccessory2Eq.Tag = "";
            this.cmbLaxiaAccessory2Eq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // cmbLaxiaAccessory1Eq
            // 
            this.cmbLaxiaAccessory1Eq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLaxiaAccessory1Eq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLaxiaAccessory1Eq.FormattingEnabled = true;
            this.cmbLaxiaAccessory1Eq.Location = new System.Drawing.Point(108, 91);
            this.cmbLaxiaAccessory1Eq.Name = "cmbLaxiaAccessory1Eq";
            this.cmbLaxiaAccessory1Eq.Size = new System.Drawing.Size(275, 21);
            this.cmbLaxiaAccessory1Eq.TabIndex = 24;
            this.cmbLaxiaAccessory1Eq.Tag = "";
            this.cmbLaxiaAccessory1Eq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(3, 117);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(90, 18);
            this.materialLabel14.TabIndex = 20;
            this.materialLabel14.Text = "Accessory 2";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(3, 90);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(90, 18);
            this.materialLabel15.TabIndex = 19;
            this.materialLabel15.Text = "Accessory 1";
            // 
            // cmbLaxiaBodyEq
            // 
            this.cmbLaxiaBodyEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLaxiaBodyEq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLaxiaBodyEq.FormattingEnabled = true;
            this.cmbLaxiaBodyEq.Location = new System.Drawing.Point(108, 37);
            this.cmbLaxiaBodyEq.Name = "cmbLaxiaBodyEq";
            this.cmbLaxiaBodyEq.Size = new System.Drawing.Size(275, 21);
            this.cmbLaxiaBodyEq.TabIndex = 18;
            this.cmbLaxiaBodyEq.Tag = "";
            this.cmbLaxiaBodyEq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(3, 36);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(42, 18);
            this.materialLabel16.TabIndex = 17;
            this.materialLabel16.Text = "Body";
            // 
            // cmbLaxiaWeaponEq
            // 
            this.cmbLaxiaWeaponEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLaxiaWeaponEq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLaxiaWeaponEq.FormattingEnabled = true;
            this.cmbLaxiaWeaponEq.Location = new System.Drawing.Point(108, 10);
            this.cmbLaxiaWeaponEq.Name = "cmbLaxiaWeaponEq";
            this.cmbLaxiaWeaponEq.Size = new System.Drawing.Size(275, 21);
            this.cmbLaxiaWeaponEq.TabIndex = 16;
            this.cmbLaxiaWeaponEq.Tag = "";
            this.cmbLaxiaWeaponEq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(3, 12);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(64, 18);
            this.materialLabel17.TabIndex = 15;
            this.materialLabel17.Text = "Weapon";
            // 
            // tabLaxiaSkills
            // 
            this.tabLaxiaSkills.Controls.Add(this.chkLaxiaSkillUnlocked);
            this.tabLaxiaSkills.Controls.Add(this.nudLaxiaSkillRank);
            this.tabLaxiaSkills.Controls.Add(this.materialLabel69);
            this.tabLaxiaSkills.Controls.Add(this.lstLaxiaSkills);
            this.tabLaxiaSkills.Location = new System.Drawing.Point(4, 22);
            this.tabLaxiaSkills.Name = "tabLaxiaSkills";
            this.tabLaxiaSkills.Size = new System.Drawing.Size(392, 302);
            this.tabLaxiaSkills.TabIndex = 2;
            this.tabLaxiaSkills.Text = "Skills";
            this.tabLaxiaSkills.UseVisualStyleBackColor = true;
            // 
            // picLaxia
            // 
            this.picLaxia.Image = global::Save_Editor.Properties.Resources.laxia_von_roswell;
            this.picLaxia.Location = new System.Drawing.Point(0, 0);
            this.picLaxia.Name = "picLaxia";
            this.picLaxia.Size = new System.Drawing.Size(185, 350);
            this.picLaxia.TabIndex = 2;
            this.picLaxia.TabStop = false;
            // 
            // tabSahad
            // 
            this.tabSahad.Controls.Add(this.materialTabSelector5);
            this.tabSahad.Controls.Add(this.tabSahadInfoContainer);
            this.tabSahad.Controls.Add(this.picSahad);
            this.tabSahad.Location = new System.Drawing.Point(4, 22);
            this.tabSahad.Name = "tabSahad";
            this.tabSahad.Size = new System.Drawing.Size(600, 369);
            this.tabSahad.TabIndex = 2;
            this.tabSahad.Tag = "Sahad";
            this.tabSahad.Text = "Sahad";
            this.tabSahad.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector5
            // 
            this.materialTabSelector5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector5.BaseTabControl = this.tabSahadInfoContainer;
            this.materialTabSelector5.Depth = 0;
            this.materialTabSelector5.Location = new System.Drawing.Point(191, 0);
            this.materialTabSelector5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector5.Name = "materialTabSelector5";
            this.materialTabSelector5.Size = new System.Drawing.Size(403, 23);
            this.materialTabSelector5.TabIndex = 8;
            this.materialTabSelector5.Text = "materialTabSelector3";
            // 
            // tabSahadInfoContainer
            // 
            this.tabSahadInfoContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSahadInfoContainer.Controls.Add(this.tabSahadInfo);
            this.tabSahadInfoContainer.Controls.Add(this.tabSahadEquipped);
            this.tabSahadInfoContainer.Controls.Add(this.tabSahadSkills);
            this.tabSahadInfoContainer.Depth = 0;
            this.tabSahadInfoContainer.Location = new System.Drawing.Point(194, 29);
            this.tabSahadInfoContainer.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSahadInfoContainer.Name = "tabSahadInfoContainer";
            this.tabSahadInfoContainer.SelectedIndex = 0;
            this.tabSahadInfoContainer.Size = new System.Drawing.Size(400, 328);
            this.tabSahadInfoContainer.TabIndex = 9;
            this.tabSahadInfoContainer.Tag = "adol";
            // 
            // tabSahadInfo
            // 
            this.tabSahadInfo.Controls.Add(this.chkSahadHp);
            this.tabSahadInfo.Controls.Add(this.materialLabel64);
            this.tabSahadInfo.Controls.Add(this.nudSahadMaxHp);
            this.tabSahadInfo.Controls.Add(this.materialLabel18);
            this.tabSahadInfo.Controls.Add(this.materialLabel19);
            this.tabSahadInfo.Controls.Add(this.nudSahadLvl);
            this.tabSahadInfo.Controls.Add(this.materialLabel20);
            this.tabSahadInfo.Location = new System.Drawing.Point(4, 22);
            this.tabSahadInfo.Name = "tabSahadInfo";
            this.tabSahadInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabSahadInfo.Size = new System.Drawing.Size(392, 302);
            this.tabSahadInfo.TabIndex = 0;
            this.tabSahadInfo.Text = "Information";
            this.tabSahadInfo.UseVisualStyleBackColor = true;
            // 
            // chkSahadHp
            // 
            this.chkSahadHp.AutoSize = true;
            this.chkSahadHp.Depth = 0;
            this.chkSahadHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkSahadHp.Location = new System.Drawing.Point(215, 45);
            this.chkSahadHp.Margin = new System.Windows.Forms.Padding(0);
            this.chkSahadHp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkSahadHp.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkSahadHp.Name = "chkSahadHp";
            this.chkSahadHp.Ripple = true;
            this.chkSahadHp.Size = new System.Drawing.Size(56, 30);
            this.chkSahadHp.TabIndex = 10;
            this.chkSahadHp.Tag = "adol";
            this.chkSahadHp.Text = "Max";
            this.chkSahadHp.UseVisualStyleBackColor = true;
            this.chkSahadHp.CheckedChanged += new System.EventHandler(this.chkCharacterMaxHp_CheckedChanged);
            // 
            // materialLabel64
            // 
            this.materialLabel64.AutoSize = true;
            this.materialLabel64.Depth = 0;
            this.materialLabel64.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel64.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel64.Location = new System.Drawing.Point(6, 49);
            this.materialLabel64.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel64.Name = "materialLabel64";
            this.materialLabel64.Size = new System.Drawing.Size(63, 18);
            this.materialLabel64.TabIndex = 8;
            this.materialLabel64.Text = "Max Hp:";
            // 
            // nudSahadMaxHp
            // 
            this.nudSahadMaxHp.Location = new System.Drawing.Point(76, 51);
            this.nudSahadMaxHp.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudSahadMaxHp.Name = "nudSahadMaxHp";
            this.nudSahadMaxHp.Size = new System.Drawing.Size(136, 20);
            this.nudSahadMaxHp.TabIndex = 9;
            this.nudSahadMaxHp.Tag = "sahad";
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel18.Location = new System.Drawing.Point(6, 3);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(52, 18);
            this.materialLabel18.TabIndex = 2;
            this.materialLabel18.Text = "Name:";
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel19.Location = new System.Drawing.Point(6, 23);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(46, 18);
            this.materialLabel19.TabIndex = 3;
            this.materialLabel19.Text = "Level:";
            // 
            // nudSahadLvl
            // 
            this.nudSahadLvl.Location = new System.Drawing.Point(76, 25);
            this.nudSahadLvl.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudSahadLvl.Name = "nudSahadLvl";
            this.nudSahadLvl.Size = new System.Drawing.Size(136, 20);
            this.nudSahadLvl.TabIndex = 5;
            this.nudSahadLvl.Tag = "adol";
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel20.Location = new System.Drawing.Point(72, 3);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(107, 18);
            this.materialLabel20.TabIndex = 4;
            this.materialLabel20.Text = "Sahad Nautilus";
            // 
            // tabSahadEquipped
            // 
            this.tabSahadEquipped.Controls.Add(this.cmbSahadArmEq);
            this.tabSahadEquipped.Controls.Add(this.materialLabel21);
            this.tabSahadEquipped.Controls.Add(this.cmbSahadAccessory2Eq);
            this.tabSahadEquipped.Controls.Add(this.cmbSahadAccessory1Eq);
            this.tabSahadEquipped.Controls.Add(this.materialLabel22);
            this.tabSahadEquipped.Controls.Add(this.materialLabel23);
            this.tabSahadEquipped.Controls.Add(this.cmbSahadBodyEq);
            this.tabSahadEquipped.Controls.Add(this.materialLabel24);
            this.tabSahadEquipped.Controls.Add(this.cmbSahadWeaponEq);
            this.tabSahadEquipped.Controls.Add(this.materialLabel25);
            this.tabSahadEquipped.Location = new System.Drawing.Point(4, 22);
            this.tabSahadEquipped.Name = "tabSahadEquipped";
            this.tabSahadEquipped.Padding = new System.Windows.Forms.Padding(3);
            this.tabSahadEquipped.Size = new System.Drawing.Size(392, 302);
            this.tabSahadEquipped.TabIndex = 1;
            this.tabSahadEquipped.Text = "Equipped";
            this.tabSahadEquipped.UseVisualStyleBackColor = true;
            // 
            // cmbSahadArmEq
            // 
            this.cmbSahadArmEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSahadArmEq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSahadArmEq.FormattingEnabled = true;
            this.cmbSahadArmEq.Location = new System.Drawing.Point(108, 64);
            this.cmbSahadArmEq.Name = "cmbSahadArmEq";
            this.cmbSahadArmEq.Size = new System.Drawing.Size(275, 21);
            this.cmbSahadArmEq.TabIndex = 27;
            this.cmbSahadArmEq.Tag = "";
            this.cmbSahadArmEq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel21
            // 
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel21.Location = new System.Drawing.Point(3, 63);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(35, 18);
            this.materialLabel21.TabIndex = 26;
            this.materialLabel21.Text = "Arm";
            // 
            // cmbSahadAccessory2Eq
            // 
            this.cmbSahadAccessory2Eq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSahadAccessory2Eq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSahadAccessory2Eq.FormattingEnabled = true;
            this.cmbSahadAccessory2Eq.Location = new System.Drawing.Point(108, 118);
            this.cmbSahadAccessory2Eq.Name = "cmbSahadAccessory2Eq";
            this.cmbSahadAccessory2Eq.Size = new System.Drawing.Size(275, 21);
            this.cmbSahadAccessory2Eq.TabIndex = 25;
            this.cmbSahadAccessory2Eq.Tag = "";
            this.cmbSahadAccessory2Eq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // cmbSahadAccessory1Eq
            // 
            this.cmbSahadAccessory1Eq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSahadAccessory1Eq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSahadAccessory1Eq.FormattingEnabled = true;
            this.cmbSahadAccessory1Eq.Location = new System.Drawing.Point(108, 91);
            this.cmbSahadAccessory1Eq.Name = "cmbSahadAccessory1Eq";
            this.cmbSahadAccessory1Eq.Size = new System.Drawing.Size(275, 21);
            this.cmbSahadAccessory1Eq.TabIndex = 24;
            this.cmbSahadAccessory1Eq.Tag = "";
            this.cmbSahadAccessory1Eq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel22
            // 
            this.materialLabel22.AutoSize = true;
            this.materialLabel22.Depth = 0;
            this.materialLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel22.Location = new System.Drawing.Point(3, 117);
            this.materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel22.Name = "materialLabel22";
            this.materialLabel22.Size = new System.Drawing.Size(90, 18);
            this.materialLabel22.TabIndex = 20;
            this.materialLabel22.Text = "Accessory 2";
            // 
            // materialLabel23
            // 
            this.materialLabel23.AutoSize = true;
            this.materialLabel23.Depth = 0;
            this.materialLabel23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel23.Location = new System.Drawing.Point(3, 90);
            this.materialLabel23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel23.Name = "materialLabel23";
            this.materialLabel23.Size = new System.Drawing.Size(90, 18);
            this.materialLabel23.TabIndex = 19;
            this.materialLabel23.Text = "Accessory 1";
            // 
            // cmbSahadBodyEq
            // 
            this.cmbSahadBodyEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSahadBodyEq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSahadBodyEq.FormattingEnabled = true;
            this.cmbSahadBodyEq.Location = new System.Drawing.Point(108, 37);
            this.cmbSahadBodyEq.Name = "cmbSahadBodyEq";
            this.cmbSahadBodyEq.Size = new System.Drawing.Size(275, 21);
            this.cmbSahadBodyEq.TabIndex = 18;
            this.cmbSahadBodyEq.Tag = "";
            this.cmbSahadBodyEq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel24
            // 
            this.materialLabel24.AutoSize = true;
            this.materialLabel24.Depth = 0;
            this.materialLabel24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel24.Location = new System.Drawing.Point(3, 36);
            this.materialLabel24.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel24.Name = "materialLabel24";
            this.materialLabel24.Size = new System.Drawing.Size(42, 18);
            this.materialLabel24.TabIndex = 17;
            this.materialLabel24.Text = "Body";
            // 
            // cmbSahadWeaponEq
            // 
            this.cmbSahadWeaponEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSahadWeaponEq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSahadWeaponEq.FormattingEnabled = true;
            this.cmbSahadWeaponEq.Location = new System.Drawing.Point(108, 10);
            this.cmbSahadWeaponEq.Name = "cmbSahadWeaponEq";
            this.cmbSahadWeaponEq.Size = new System.Drawing.Size(275, 21);
            this.cmbSahadWeaponEq.TabIndex = 16;
            this.cmbSahadWeaponEq.Tag = "";
            this.cmbSahadWeaponEq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel25
            // 
            this.materialLabel25.AutoSize = true;
            this.materialLabel25.Depth = 0;
            this.materialLabel25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel25.Location = new System.Drawing.Point(3, 12);
            this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel25.Name = "materialLabel25";
            this.materialLabel25.Size = new System.Drawing.Size(64, 18);
            this.materialLabel25.TabIndex = 15;
            this.materialLabel25.Text = "Weapon";
            // 
            // tabSahadSkills
            // 
            this.tabSahadSkills.Controls.Add(this.chkSahadSkillUnlocked);
            this.tabSahadSkills.Controls.Add(this.nudSahadSkillRank);
            this.tabSahadSkills.Controls.Add(this.materialLabel70);
            this.tabSahadSkills.Controls.Add(this.lstSahadSkills);
            this.tabSahadSkills.Location = new System.Drawing.Point(4, 22);
            this.tabSahadSkills.Name = "tabSahadSkills";
            this.tabSahadSkills.Padding = new System.Windows.Forms.Padding(3);
            this.tabSahadSkills.Size = new System.Drawing.Size(392, 302);
            this.tabSahadSkills.TabIndex = 2;
            this.tabSahadSkills.Text = "Skills";
            this.tabSahadSkills.UseVisualStyleBackColor = true;
            // 
            // picSahad
            // 
            this.picSahad.Image = global::Save_Editor.Properties.Resources.sahad_noutilus;
            this.picSahad.Location = new System.Drawing.Point(0, 0);
            this.picSahad.Name = "picSahad";
            this.picSahad.Size = new System.Drawing.Size(185, 350);
            this.picSahad.TabIndex = 2;
            this.picSahad.TabStop = false;
            // 
            // tabHummel
            // 
            this.tabHummel.Controls.Add(this.materialTabSelector6);
            this.tabHummel.Controls.Add(this.tabHummInfoContainer);
            this.tabHummel.Controls.Add(this.picHummel);
            this.tabHummel.Location = new System.Drawing.Point(4, 22);
            this.tabHummel.Name = "tabHummel";
            this.tabHummel.Size = new System.Drawing.Size(600, 369);
            this.tabHummel.TabIndex = 3;
            this.tabHummel.Tag = "Hummel";
            this.tabHummel.Text = "Hummel";
            this.tabHummel.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector6
            // 
            this.materialTabSelector6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector6.BaseTabControl = this.tabHummInfoContainer;
            this.materialTabSelector6.Depth = 0;
            this.materialTabSelector6.Location = new System.Drawing.Point(191, 0);
            this.materialTabSelector6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector6.Name = "materialTabSelector6";
            this.materialTabSelector6.Size = new System.Drawing.Size(403, 23);
            this.materialTabSelector6.TabIndex = 8;
            this.materialTabSelector6.Text = "materialTabSelector3";
            // 
            // tabHummInfoContainer
            // 
            this.tabHummInfoContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabHummInfoContainer.Controls.Add(this.tabHummInfo);
            this.tabHummInfoContainer.Controls.Add(this.tabHummEquipped);
            this.tabHummInfoContainer.Controls.Add(this.tabHummSkills);
            this.tabHummInfoContainer.Depth = 0;
            this.tabHummInfoContainer.Location = new System.Drawing.Point(194, 29);
            this.tabHummInfoContainer.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabHummInfoContainer.Name = "tabHummInfoContainer";
            this.tabHummInfoContainer.SelectedIndex = 0;
            this.tabHummInfoContainer.Size = new System.Drawing.Size(400, 328);
            this.tabHummInfoContainer.TabIndex = 9;
            this.tabHummInfoContainer.Tag = "adol";
            // 
            // tabHummInfo
            // 
            this.tabHummInfo.Controls.Add(this.chkHummHp);
            this.tabHummInfo.Controls.Add(this.materialLabel65);
            this.tabHummInfo.Controls.Add(this.nudHummMaxHp);
            this.tabHummInfo.Controls.Add(this.materialLabel30);
            this.tabHummInfo.Controls.Add(this.materialLabel31);
            this.tabHummInfo.Controls.Add(this.nudHummLvl);
            this.tabHummInfo.Controls.Add(this.materialLabel32);
            this.tabHummInfo.Location = new System.Drawing.Point(4, 22);
            this.tabHummInfo.Name = "tabHummInfo";
            this.tabHummInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabHummInfo.Size = new System.Drawing.Size(392, 302);
            this.tabHummInfo.TabIndex = 0;
            this.tabHummInfo.Text = "Information";
            this.tabHummInfo.UseVisualStyleBackColor = true;
            // 
            // chkHummHp
            // 
            this.chkHummHp.AutoSize = true;
            this.chkHummHp.Depth = 0;
            this.chkHummHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkHummHp.Location = new System.Drawing.Point(215, 45);
            this.chkHummHp.Margin = new System.Windows.Forms.Padding(0);
            this.chkHummHp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkHummHp.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkHummHp.Name = "chkHummHp";
            this.chkHummHp.Ripple = true;
            this.chkHummHp.Size = new System.Drawing.Size(56, 30);
            this.chkHummHp.TabIndex = 10;
            this.chkHummHp.Tag = "adol";
            this.chkHummHp.Text = "Max";
            this.chkHummHp.UseVisualStyleBackColor = true;
            this.chkHummHp.CheckedChanged += new System.EventHandler(this.chkCharacterMaxHp_CheckedChanged);
            // 
            // materialLabel65
            // 
            this.materialLabel65.AutoSize = true;
            this.materialLabel65.Depth = 0;
            this.materialLabel65.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel65.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel65.Location = new System.Drawing.Point(6, 49);
            this.materialLabel65.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel65.Name = "materialLabel65";
            this.materialLabel65.Size = new System.Drawing.Size(63, 18);
            this.materialLabel65.TabIndex = 8;
            this.materialLabel65.Text = "Max Hp:";
            // 
            // nudHummMaxHp
            // 
            this.nudHummMaxHp.Location = new System.Drawing.Point(76, 51);
            this.nudHummMaxHp.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudHummMaxHp.Name = "nudHummMaxHp";
            this.nudHummMaxHp.Size = new System.Drawing.Size(136, 20);
            this.nudHummMaxHp.TabIndex = 9;
            this.nudHummMaxHp.Tag = "hummel";
            // 
            // materialLabel30
            // 
            this.materialLabel30.AutoSize = true;
            this.materialLabel30.Depth = 0;
            this.materialLabel30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel30.Location = new System.Drawing.Point(6, 3);
            this.materialLabel30.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel30.Name = "materialLabel30";
            this.materialLabel30.Size = new System.Drawing.Size(52, 18);
            this.materialLabel30.TabIndex = 2;
            this.materialLabel30.Text = "Name:";
            // 
            // materialLabel31
            // 
            this.materialLabel31.AutoSize = true;
            this.materialLabel31.Depth = 0;
            this.materialLabel31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel31.Location = new System.Drawing.Point(6, 23);
            this.materialLabel31.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel31.Name = "materialLabel31";
            this.materialLabel31.Size = new System.Drawing.Size(46, 18);
            this.materialLabel31.TabIndex = 3;
            this.materialLabel31.Text = "Level:";
            // 
            // nudHummLvl
            // 
            this.nudHummLvl.Location = new System.Drawing.Point(76, 25);
            this.nudHummLvl.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudHummLvl.Name = "nudHummLvl";
            this.nudHummLvl.Size = new System.Drawing.Size(136, 20);
            this.nudHummLvl.TabIndex = 5;
            this.nudHummLvl.Tag = "adol";
            // 
            // materialLabel32
            // 
            this.materialLabel32.AutoSize = true;
            this.materialLabel32.Depth = 0;
            this.materialLabel32.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel32.Location = new System.Drawing.Point(72, 3);
            this.materialLabel32.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel32.Name = "materialLabel32";
            this.materialLabel32.Size = new System.Drawing.Size(126, 18);
            this.materialLabel32.TabIndex = 4;
            this.materialLabel32.Text = "Hummel Trabaldo";
            // 
            // tabHummEquipped
            // 
            this.tabHummEquipped.Controls.Add(this.cmbHummArmEq);
            this.tabHummEquipped.Controls.Add(this.materialLabel34);
            this.tabHummEquipped.Controls.Add(this.cmbHummAccessory2Eq);
            this.tabHummEquipped.Controls.Add(this.cmbHummAccessory1Eq);
            this.tabHummEquipped.Controls.Add(this.materialLabel35);
            this.tabHummEquipped.Controls.Add(this.materialLabel36);
            this.tabHummEquipped.Controls.Add(this.cmbHummBodyEq);
            this.tabHummEquipped.Controls.Add(this.materialLabel37);
            this.tabHummEquipped.Controls.Add(this.cmbHummWeaponEq);
            this.tabHummEquipped.Controls.Add(this.materialLabel41);
            this.tabHummEquipped.Location = new System.Drawing.Point(4, 22);
            this.tabHummEquipped.Name = "tabHummEquipped";
            this.tabHummEquipped.Padding = new System.Windows.Forms.Padding(3);
            this.tabHummEquipped.Size = new System.Drawing.Size(392, 302);
            this.tabHummEquipped.TabIndex = 1;
            this.tabHummEquipped.Text = "Equipped";
            this.tabHummEquipped.UseVisualStyleBackColor = true;
            // 
            // cmbHummArmEq
            // 
            this.cmbHummArmEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbHummArmEq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHummArmEq.FormattingEnabled = true;
            this.cmbHummArmEq.Location = new System.Drawing.Point(108, 64);
            this.cmbHummArmEq.Name = "cmbHummArmEq";
            this.cmbHummArmEq.Size = new System.Drawing.Size(275, 21);
            this.cmbHummArmEq.TabIndex = 27;
            this.cmbHummArmEq.Tag = "";
            this.cmbHummArmEq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel34
            // 
            this.materialLabel34.AutoSize = true;
            this.materialLabel34.Depth = 0;
            this.materialLabel34.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel34.Location = new System.Drawing.Point(3, 63);
            this.materialLabel34.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel34.Name = "materialLabel34";
            this.materialLabel34.Size = new System.Drawing.Size(35, 18);
            this.materialLabel34.TabIndex = 26;
            this.materialLabel34.Text = "Arm";
            // 
            // cmbHummAccessory2Eq
            // 
            this.cmbHummAccessory2Eq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbHummAccessory2Eq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHummAccessory2Eq.FormattingEnabled = true;
            this.cmbHummAccessory2Eq.Location = new System.Drawing.Point(108, 118);
            this.cmbHummAccessory2Eq.Name = "cmbHummAccessory2Eq";
            this.cmbHummAccessory2Eq.Size = new System.Drawing.Size(275, 21);
            this.cmbHummAccessory2Eq.TabIndex = 25;
            this.cmbHummAccessory2Eq.Tag = "";
            this.cmbHummAccessory2Eq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // cmbHummAccessory1Eq
            // 
            this.cmbHummAccessory1Eq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbHummAccessory1Eq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHummAccessory1Eq.FormattingEnabled = true;
            this.cmbHummAccessory1Eq.Location = new System.Drawing.Point(108, 91);
            this.cmbHummAccessory1Eq.Name = "cmbHummAccessory1Eq";
            this.cmbHummAccessory1Eq.Size = new System.Drawing.Size(275, 21);
            this.cmbHummAccessory1Eq.TabIndex = 24;
            this.cmbHummAccessory1Eq.Tag = "";
            this.cmbHummAccessory1Eq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel35
            // 
            this.materialLabel35.AutoSize = true;
            this.materialLabel35.Depth = 0;
            this.materialLabel35.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel35.Location = new System.Drawing.Point(3, 117);
            this.materialLabel35.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel35.Name = "materialLabel35";
            this.materialLabel35.Size = new System.Drawing.Size(90, 18);
            this.materialLabel35.TabIndex = 20;
            this.materialLabel35.Text = "Accessory 2";
            // 
            // materialLabel36
            // 
            this.materialLabel36.AutoSize = true;
            this.materialLabel36.Depth = 0;
            this.materialLabel36.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel36.Location = new System.Drawing.Point(3, 90);
            this.materialLabel36.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel36.Name = "materialLabel36";
            this.materialLabel36.Size = new System.Drawing.Size(90, 18);
            this.materialLabel36.TabIndex = 19;
            this.materialLabel36.Text = "Accessory 1";
            // 
            // cmbHummBodyEq
            // 
            this.cmbHummBodyEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbHummBodyEq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHummBodyEq.FormattingEnabled = true;
            this.cmbHummBodyEq.Location = new System.Drawing.Point(108, 37);
            this.cmbHummBodyEq.Name = "cmbHummBodyEq";
            this.cmbHummBodyEq.Size = new System.Drawing.Size(275, 21);
            this.cmbHummBodyEq.TabIndex = 18;
            this.cmbHummBodyEq.Tag = "";
            this.cmbHummBodyEq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel37
            // 
            this.materialLabel37.AutoSize = true;
            this.materialLabel37.Depth = 0;
            this.materialLabel37.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel37.Location = new System.Drawing.Point(3, 36);
            this.materialLabel37.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel37.Name = "materialLabel37";
            this.materialLabel37.Size = new System.Drawing.Size(42, 18);
            this.materialLabel37.TabIndex = 17;
            this.materialLabel37.Text = "Body";
            // 
            // cmbHummWeaponEq
            // 
            this.cmbHummWeaponEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbHummWeaponEq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHummWeaponEq.FormattingEnabled = true;
            this.cmbHummWeaponEq.Location = new System.Drawing.Point(108, 10);
            this.cmbHummWeaponEq.Name = "cmbHummWeaponEq";
            this.cmbHummWeaponEq.Size = new System.Drawing.Size(275, 21);
            this.cmbHummWeaponEq.TabIndex = 16;
            this.cmbHummWeaponEq.Tag = "";
            this.cmbHummWeaponEq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel41
            // 
            this.materialLabel41.AutoSize = true;
            this.materialLabel41.Depth = 0;
            this.materialLabel41.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel41.Location = new System.Drawing.Point(3, 12);
            this.materialLabel41.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel41.Name = "materialLabel41";
            this.materialLabel41.Size = new System.Drawing.Size(64, 18);
            this.materialLabel41.TabIndex = 15;
            this.materialLabel41.Text = "Weapon";
            // 
            // tabHummSkills
            // 
            this.tabHummSkills.Controls.Add(this.chkHummSkillUnlocked);
            this.tabHummSkills.Controls.Add(this.nudHummSkillRank);
            this.tabHummSkills.Controls.Add(this.materialLabel71);
            this.tabHummSkills.Controls.Add(this.lstHummSkills);
            this.tabHummSkills.Location = new System.Drawing.Point(4, 22);
            this.tabHummSkills.Name = "tabHummSkills";
            this.tabHummSkills.Size = new System.Drawing.Size(392, 302);
            this.tabHummSkills.TabIndex = 2;
            this.tabHummSkills.Text = "Skills";
            this.tabHummSkills.UseVisualStyleBackColor = true;
            // 
            // picHummel
            // 
            this.picHummel.Image = global::Save_Editor.Properties.Resources.hummel_trabaldo;
            this.picHummel.Location = new System.Drawing.Point(0, 0);
            this.picHummel.Name = "picHummel";
            this.picHummel.Size = new System.Drawing.Size(185, 350);
            this.picHummel.TabIndex = 2;
            this.picHummel.TabStop = false;
            // 
            // tabRicotta
            // 
            this.tabRicotta.Controls.Add(this.materialTabSelector7);
            this.tabRicotta.Controls.Add(this.tabRicoInfoContainer);
            this.tabRicotta.Controls.Add(this.picRicotta);
            this.tabRicotta.Location = new System.Drawing.Point(4, 22);
            this.tabRicotta.Name = "tabRicotta";
            this.tabRicotta.Size = new System.Drawing.Size(600, 369);
            this.tabRicotta.TabIndex = 4;
            this.tabRicotta.Tag = "Ricotta";
            this.tabRicotta.Text = "Ricotta";
            this.tabRicotta.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector7
            // 
            this.materialTabSelector7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector7.BaseTabControl = this.tabRicoInfoContainer;
            this.materialTabSelector7.Depth = 0;
            this.materialTabSelector7.Location = new System.Drawing.Point(191, 0);
            this.materialTabSelector7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector7.Name = "materialTabSelector7";
            this.materialTabSelector7.Size = new System.Drawing.Size(403, 23);
            this.materialTabSelector7.TabIndex = 8;
            this.materialTabSelector7.Text = "materialTabSelector3";
            // 
            // tabRicoInfoContainer
            // 
            this.tabRicoInfoContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabRicoInfoContainer.Controls.Add(this.tabRicoInfo);
            this.tabRicoInfoContainer.Controls.Add(this.tabRicoEquppied);
            this.tabRicoInfoContainer.Controls.Add(this.tabRicoSkills);
            this.tabRicoInfoContainer.Depth = 0;
            this.tabRicoInfoContainer.Location = new System.Drawing.Point(194, 29);
            this.tabRicoInfoContainer.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabRicoInfoContainer.Name = "tabRicoInfoContainer";
            this.tabRicoInfoContainer.SelectedIndex = 0;
            this.tabRicoInfoContainer.Size = new System.Drawing.Size(400, 328);
            this.tabRicoInfoContainer.TabIndex = 9;
            this.tabRicoInfoContainer.Tag = "adol";
            // 
            // tabRicoInfo
            // 
            this.tabRicoInfo.Controls.Add(this.chkRicoHp);
            this.tabRicoInfo.Controls.Add(this.materialLabel66);
            this.tabRicoInfo.Controls.Add(this.nudRicoMaxHp);
            this.tabRicoInfo.Controls.Add(this.materialLabel43);
            this.tabRicoInfo.Controls.Add(this.materialLabel45);
            this.tabRicoInfo.Controls.Add(this.nudRicoLvl);
            this.tabRicoInfo.Controls.Add(this.materialLabel46);
            this.tabRicoInfo.Location = new System.Drawing.Point(4, 22);
            this.tabRicoInfo.Name = "tabRicoInfo";
            this.tabRicoInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabRicoInfo.Size = new System.Drawing.Size(392, 302);
            this.tabRicoInfo.TabIndex = 0;
            this.tabRicoInfo.Text = "Information";
            this.tabRicoInfo.UseVisualStyleBackColor = true;
            // 
            // chkRicoHp
            // 
            this.chkRicoHp.AutoSize = true;
            this.chkRicoHp.Depth = 0;
            this.chkRicoHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkRicoHp.Location = new System.Drawing.Point(215, 45);
            this.chkRicoHp.Margin = new System.Windows.Forms.Padding(0);
            this.chkRicoHp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkRicoHp.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkRicoHp.Name = "chkRicoHp";
            this.chkRicoHp.Ripple = true;
            this.chkRicoHp.Size = new System.Drawing.Size(56, 30);
            this.chkRicoHp.TabIndex = 10;
            this.chkRicoHp.Tag = "adol";
            this.chkRicoHp.Text = "Max";
            this.chkRicoHp.UseVisualStyleBackColor = true;
            this.chkRicoHp.CheckedChanged += new System.EventHandler(this.chkCharacterMaxHp_CheckedChanged);
            // 
            // materialLabel66
            // 
            this.materialLabel66.AutoSize = true;
            this.materialLabel66.Depth = 0;
            this.materialLabel66.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel66.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel66.Location = new System.Drawing.Point(6, 49);
            this.materialLabel66.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel66.Name = "materialLabel66";
            this.materialLabel66.Size = new System.Drawing.Size(63, 18);
            this.materialLabel66.TabIndex = 8;
            this.materialLabel66.Text = "Max Hp:";
            // 
            // nudRicoMaxHp
            // 
            this.nudRicoMaxHp.Location = new System.Drawing.Point(76, 51);
            this.nudRicoMaxHp.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudRicoMaxHp.Name = "nudRicoMaxHp";
            this.nudRicoMaxHp.Size = new System.Drawing.Size(136, 20);
            this.nudRicoMaxHp.TabIndex = 9;
            this.nudRicoMaxHp.Tag = "ricotta";
            // 
            // materialLabel43
            // 
            this.materialLabel43.AutoSize = true;
            this.materialLabel43.Depth = 0;
            this.materialLabel43.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel43.Location = new System.Drawing.Point(6, 3);
            this.materialLabel43.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel43.Name = "materialLabel43";
            this.materialLabel43.Size = new System.Drawing.Size(52, 18);
            this.materialLabel43.TabIndex = 2;
            this.materialLabel43.Text = "Name:";
            // 
            // materialLabel45
            // 
            this.materialLabel45.AutoSize = true;
            this.materialLabel45.Depth = 0;
            this.materialLabel45.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel45.Location = new System.Drawing.Point(6, 23);
            this.materialLabel45.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel45.Name = "materialLabel45";
            this.materialLabel45.Size = new System.Drawing.Size(46, 18);
            this.materialLabel45.TabIndex = 3;
            this.materialLabel45.Text = "Level:";
            // 
            // nudRicoLvl
            // 
            this.nudRicoLvl.Location = new System.Drawing.Point(76, 25);
            this.nudRicoLvl.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudRicoLvl.Name = "nudRicoLvl";
            this.nudRicoLvl.Size = new System.Drawing.Size(136, 20);
            this.nudRicoLvl.TabIndex = 5;
            this.nudRicoLvl.Tag = "adol";
            // 
            // materialLabel46
            // 
            this.materialLabel46.AutoSize = true;
            this.materialLabel46.Depth = 0;
            this.materialLabel46.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel46.Location = new System.Drawing.Point(72, 3);
            this.materialLabel46.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel46.Name = "materialLabel46";
            this.materialLabel46.Size = new System.Drawing.Size(107, 18);
            this.materialLabel46.TabIndex = 4;
            this.materialLabel46.Text = "Ricotta Beldine";
            // 
            // tabRicoEquppied
            // 
            this.tabRicoEquppied.Controls.Add(this.cmbRicoArmEq);
            this.tabRicoEquppied.Controls.Add(this.materialLabel47);
            this.tabRicoEquppied.Controls.Add(this.cmbRicoAccessory2Eq);
            this.tabRicoEquppied.Controls.Add(this.cmbRicoAccessory1Eq);
            this.tabRicoEquppied.Controls.Add(this.materialLabel48);
            this.tabRicoEquppied.Controls.Add(this.materialLabel49);
            this.tabRicoEquppied.Controls.Add(this.cmbRicoBodyEq);
            this.tabRicoEquppied.Controls.Add(this.materialLabel50);
            this.tabRicoEquppied.Controls.Add(this.cmbRicoWeaponEq);
            this.tabRicoEquppied.Controls.Add(this.materialLabel51);
            this.tabRicoEquppied.Location = new System.Drawing.Point(4, 22);
            this.tabRicoEquppied.Name = "tabRicoEquppied";
            this.tabRicoEquppied.Padding = new System.Windows.Forms.Padding(3);
            this.tabRicoEquppied.Size = new System.Drawing.Size(392, 302);
            this.tabRicoEquppied.TabIndex = 1;
            this.tabRicoEquppied.Text = "Equipped";
            this.tabRicoEquppied.UseVisualStyleBackColor = true;
            // 
            // cmbRicoArmEq
            // 
            this.cmbRicoArmEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRicoArmEq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRicoArmEq.FormattingEnabled = true;
            this.cmbRicoArmEq.Location = new System.Drawing.Point(108, 64);
            this.cmbRicoArmEq.Name = "cmbRicoArmEq";
            this.cmbRicoArmEq.Size = new System.Drawing.Size(275, 21);
            this.cmbRicoArmEq.TabIndex = 27;
            this.cmbRicoArmEq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel47
            // 
            this.materialLabel47.AutoSize = true;
            this.materialLabel47.Depth = 0;
            this.materialLabel47.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel47.Location = new System.Drawing.Point(3, 63);
            this.materialLabel47.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel47.Name = "materialLabel47";
            this.materialLabel47.Size = new System.Drawing.Size(35, 18);
            this.materialLabel47.TabIndex = 26;
            this.materialLabel47.Text = "Arm";
            // 
            // cmbRicoAccessory2Eq
            // 
            this.cmbRicoAccessory2Eq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRicoAccessory2Eq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRicoAccessory2Eq.FormattingEnabled = true;
            this.cmbRicoAccessory2Eq.Location = new System.Drawing.Point(108, 118);
            this.cmbRicoAccessory2Eq.Name = "cmbRicoAccessory2Eq";
            this.cmbRicoAccessory2Eq.Size = new System.Drawing.Size(275, 21);
            this.cmbRicoAccessory2Eq.TabIndex = 25;
            this.cmbRicoAccessory2Eq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // cmbRicoAccessory1Eq
            // 
            this.cmbRicoAccessory1Eq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRicoAccessory1Eq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRicoAccessory1Eq.FormattingEnabled = true;
            this.cmbRicoAccessory1Eq.Location = new System.Drawing.Point(108, 91);
            this.cmbRicoAccessory1Eq.Name = "cmbRicoAccessory1Eq";
            this.cmbRicoAccessory1Eq.Size = new System.Drawing.Size(275, 21);
            this.cmbRicoAccessory1Eq.TabIndex = 24;
            this.cmbRicoAccessory1Eq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel48
            // 
            this.materialLabel48.AutoSize = true;
            this.materialLabel48.Depth = 0;
            this.materialLabel48.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel48.Location = new System.Drawing.Point(3, 117);
            this.materialLabel48.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel48.Name = "materialLabel48";
            this.materialLabel48.Size = new System.Drawing.Size(90, 18);
            this.materialLabel48.TabIndex = 20;
            this.materialLabel48.Text = "Accessory 2";
            // 
            // materialLabel49
            // 
            this.materialLabel49.AutoSize = true;
            this.materialLabel49.Depth = 0;
            this.materialLabel49.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel49.Location = new System.Drawing.Point(3, 90);
            this.materialLabel49.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel49.Name = "materialLabel49";
            this.materialLabel49.Size = new System.Drawing.Size(90, 18);
            this.materialLabel49.TabIndex = 19;
            this.materialLabel49.Text = "Accessory 1";
            // 
            // cmbRicoBodyEq
            // 
            this.cmbRicoBodyEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRicoBodyEq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRicoBodyEq.FormattingEnabled = true;
            this.cmbRicoBodyEq.Location = new System.Drawing.Point(108, 37);
            this.cmbRicoBodyEq.Name = "cmbRicoBodyEq";
            this.cmbRicoBodyEq.Size = new System.Drawing.Size(275, 21);
            this.cmbRicoBodyEq.TabIndex = 18;
            this.cmbRicoBodyEq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel50
            // 
            this.materialLabel50.AutoSize = true;
            this.materialLabel50.Depth = 0;
            this.materialLabel50.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel50.Location = new System.Drawing.Point(3, 36);
            this.materialLabel50.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel50.Name = "materialLabel50";
            this.materialLabel50.Size = new System.Drawing.Size(42, 18);
            this.materialLabel50.TabIndex = 17;
            this.materialLabel50.Text = "Body";
            // 
            // cmbRicoWeaponEq
            // 
            this.cmbRicoWeaponEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRicoWeaponEq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRicoWeaponEq.FormattingEnabled = true;
            this.cmbRicoWeaponEq.Location = new System.Drawing.Point(108, 10);
            this.cmbRicoWeaponEq.Name = "cmbRicoWeaponEq";
            this.cmbRicoWeaponEq.Size = new System.Drawing.Size(275, 21);
            this.cmbRicoWeaponEq.TabIndex = 16;
            this.cmbRicoWeaponEq.Tag = "";
            this.cmbRicoWeaponEq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel51
            // 
            this.materialLabel51.AutoSize = true;
            this.materialLabel51.Depth = 0;
            this.materialLabel51.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel51.Location = new System.Drawing.Point(3, 12);
            this.materialLabel51.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel51.Name = "materialLabel51";
            this.materialLabel51.Size = new System.Drawing.Size(64, 18);
            this.materialLabel51.TabIndex = 15;
            this.materialLabel51.Text = "Weapon";
            // 
            // tabRicoSkills
            // 
            this.tabRicoSkills.Controls.Add(this.chkRicoSkillUnlocked);
            this.tabRicoSkills.Controls.Add(this.nudRicoSkillRank);
            this.tabRicoSkills.Controls.Add(this.materialLabel72);
            this.tabRicoSkills.Controls.Add(this.lstRicoSkills);
            this.tabRicoSkills.Location = new System.Drawing.Point(4, 22);
            this.tabRicoSkills.Name = "tabRicoSkills";
            this.tabRicoSkills.Size = new System.Drawing.Size(392, 302);
            this.tabRicoSkills.TabIndex = 2;
            this.tabRicoSkills.Text = "Skills";
            this.tabRicoSkills.UseVisualStyleBackColor = true;
            // 
            // picRicotta
            // 
            this.picRicotta.Image = global::Save_Editor.Properties.Resources.ricotta_beldine;
            this.picRicotta.Location = new System.Drawing.Point(0, 0);
            this.picRicotta.Name = "picRicotta";
            this.picRicotta.Size = new System.Drawing.Size(185, 350);
            this.picRicotta.TabIndex = 2;
            this.picRicotta.TabStop = false;
            // 
            // tabDana
            // 
            this.tabDana.Controls.Add(this.materialTabSelector8);
            this.tabDana.Controls.Add(this.tabDanaInfoContainer);
            this.tabDana.Controls.Add(this.picDana);
            this.tabDana.Location = new System.Drawing.Point(4, 22);
            this.tabDana.Name = "tabDana";
            this.tabDana.Size = new System.Drawing.Size(600, 369);
            this.tabDana.TabIndex = 5;
            this.tabDana.Tag = "Dana";
            this.tabDana.Text = "Dana";
            this.tabDana.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector8
            // 
            this.materialTabSelector8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector8.BaseTabControl = this.tabDanaInfoContainer;
            this.materialTabSelector8.Depth = 0;
            this.materialTabSelector8.Location = new System.Drawing.Point(191, 0);
            this.materialTabSelector8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector8.Name = "materialTabSelector8";
            this.materialTabSelector8.Size = new System.Drawing.Size(403, 23);
            this.materialTabSelector8.TabIndex = 8;
            this.materialTabSelector8.Text = "materialTabSelector3";
            // 
            // tabDanaInfoContainer
            // 
            this.tabDanaInfoContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDanaInfoContainer.Controls.Add(this.tabDanaInfo);
            this.tabDanaInfoContainer.Controls.Add(this.tabDanaEquipped);
            this.tabDanaInfoContainer.Controls.Add(this.tabDanaSkills);
            this.tabDanaInfoContainer.Depth = 0;
            this.tabDanaInfoContainer.Location = new System.Drawing.Point(194, 29);
            this.tabDanaInfoContainer.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabDanaInfoContainer.Name = "tabDanaInfoContainer";
            this.tabDanaInfoContainer.SelectedIndex = 0;
            this.tabDanaInfoContainer.Size = new System.Drawing.Size(400, 328);
            this.tabDanaInfoContainer.TabIndex = 9;
            this.tabDanaInfoContainer.Tag = "adol";
            // 
            // tabDanaInfo
            // 
            this.tabDanaInfo.Controls.Add(this.chkDanaHp);
            this.tabDanaInfo.Controls.Add(this.materialLabel67);
            this.tabDanaInfo.Controls.Add(this.nudDanaMaxHp);
            this.tabDanaInfo.Controls.Add(this.materialLabel52);
            this.tabDanaInfo.Controls.Add(this.materialLabel53);
            this.tabDanaInfo.Controls.Add(this.nudDanaLvl);
            this.tabDanaInfo.Controls.Add(this.materialLabel54);
            this.tabDanaInfo.Location = new System.Drawing.Point(4, 22);
            this.tabDanaInfo.Name = "tabDanaInfo";
            this.tabDanaInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabDanaInfo.Size = new System.Drawing.Size(392, 302);
            this.tabDanaInfo.TabIndex = 0;
            this.tabDanaInfo.Text = "Information";
            this.tabDanaInfo.UseVisualStyleBackColor = true;
            // 
            // chkDanaHp
            // 
            this.chkDanaHp.AutoSize = true;
            this.chkDanaHp.Depth = 0;
            this.chkDanaHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkDanaHp.Location = new System.Drawing.Point(215, 45);
            this.chkDanaHp.Margin = new System.Windows.Forms.Padding(0);
            this.chkDanaHp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkDanaHp.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkDanaHp.Name = "chkDanaHp";
            this.chkDanaHp.Ripple = true;
            this.chkDanaHp.Size = new System.Drawing.Size(56, 30);
            this.chkDanaHp.TabIndex = 10;
            this.chkDanaHp.Tag = "adol";
            this.chkDanaHp.Text = "Max";
            this.chkDanaHp.UseVisualStyleBackColor = true;
            this.chkDanaHp.CheckedChanged += new System.EventHandler(this.chkCharacterMaxHp_CheckedChanged);
            // 
            // materialLabel67
            // 
            this.materialLabel67.AutoSize = true;
            this.materialLabel67.Depth = 0;
            this.materialLabel67.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel67.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel67.Location = new System.Drawing.Point(6, 49);
            this.materialLabel67.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel67.Name = "materialLabel67";
            this.materialLabel67.Size = new System.Drawing.Size(63, 18);
            this.materialLabel67.TabIndex = 8;
            this.materialLabel67.Text = "Max Hp:";
            // 
            // nudDanaMaxHp
            // 
            this.nudDanaMaxHp.Location = new System.Drawing.Point(76, 51);
            this.nudDanaMaxHp.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudDanaMaxHp.Name = "nudDanaMaxHp";
            this.nudDanaMaxHp.Size = new System.Drawing.Size(136, 20);
            this.nudDanaMaxHp.TabIndex = 9;
            this.nudDanaMaxHp.Tag = "dana";
            // 
            // materialLabel52
            // 
            this.materialLabel52.AutoSize = true;
            this.materialLabel52.Depth = 0;
            this.materialLabel52.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel52.Location = new System.Drawing.Point(6, 3);
            this.materialLabel52.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel52.Name = "materialLabel52";
            this.materialLabel52.Size = new System.Drawing.Size(52, 18);
            this.materialLabel52.TabIndex = 2;
            this.materialLabel52.Text = "Name:";
            // 
            // materialLabel53
            // 
            this.materialLabel53.AutoSize = true;
            this.materialLabel53.Depth = 0;
            this.materialLabel53.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel53.Location = new System.Drawing.Point(6, 23);
            this.materialLabel53.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel53.Name = "materialLabel53";
            this.materialLabel53.Size = new System.Drawing.Size(46, 18);
            this.materialLabel53.TabIndex = 3;
            this.materialLabel53.Text = "Level:";
            // 
            // nudDanaLvl
            // 
            this.nudDanaLvl.Location = new System.Drawing.Point(76, 25);
            this.nudDanaLvl.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudDanaLvl.Name = "nudDanaLvl";
            this.nudDanaLvl.Size = new System.Drawing.Size(136, 20);
            this.nudDanaLvl.TabIndex = 5;
            this.nudDanaLvl.Tag = "adol";
            // 
            // materialLabel54
            // 
            this.materialLabel54.AutoSize = true;
            this.materialLabel54.Depth = 0;
            this.materialLabel54.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel54.Location = new System.Drawing.Point(72, 3);
            this.materialLabel54.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel54.Name = "materialLabel54";
            this.materialLabel54.Size = new System.Drawing.Size(88, 18);
            this.materialLabel54.TabIndex = 4;
            this.materialLabel54.Text = "Dana Iclucia";
            // 
            // tabDanaEquipped
            // 
            this.tabDanaEquipped.Controls.Add(this.cmbDanaArmEq);
            this.tabDanaEquipped.Controls.Add(this.materialLabel55);
            this.tabDanaEquipped.Controls.Add(this.cmbDanaAccessory2Eq);
            this.tabDanaEquipped.Controls.Add(this.cmbDanaAccessory1Eq);
            this.tabDanaEquipped.Controls.Add(this.materialLabel56);
            this.tabDanaEquipped.Controls.Add(this.materialLabel57);
            this.tabDanaEquipped.Controls.Add(this.cmbDanaBodyEq);
            this.tabDanaEquipped.Controls.Add(this.materialLabel58);
            this.tabDanaEquipped.Controls.Add(this.cmbDanaWeaponEq);
            this.tabDanaEquipped.Controls.Add(this.materialLabel59);
            this.tabDanaEquipped.Location = new System.Drawing.Point(4, 22);
            this.tabDanaEquipped.Name = "tabDanaEquipped";
            this.tabDanaEquipped.Padding = new System.Windows.Forms.Padding(3);
            this.tabDanaEquipped.Size = new System.Drawing.Size(392, 302);
            this.tabDanaEquipped.TabIndex = 1;
            this.tabDanaEquipped.Text = "Equipped";
            this.tabDanaEquipped.UseVisualStyleBackColor = true;
            // 
            // cmbDanaArmEq
            // 
            this.cmbDanaArmEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDanaArmEq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDanaArmEq.FormattingEnabled = true;
            this.cmbDanaArmEq.Location = new System.Drawing.Point(108, 64);
            this.cmbDanaArmEq.Name = "cmbDanaArmEq";
            this.cmbDanaArmEq.Size = new System.Drawing.Size(275, 21);
            this.cmbDanaArmEq.TabIndex = 27;
            this.cmbDanaArmEq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel55
            // 
            this.materialLabel55.AutoSize = true;
            this.materialLabel55.Depth = 0;
            this.materialLabel55.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel55.Location = new System.Drawing.Point(3, 63);
            this.materialLabel55.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel55.Name = "materialLabel55";
            this.materialLabel55.Size = new System.Drawing.Size(35, 18);
            this.materialLabel55.TabIndex = 26;
            this.materialLabel55.Text = "Arm";
            // 
            // cmbDanaAccessory2Eq
            // 
            this.cmbDanaAccessory2Eq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDanaAccessory2Eq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDanaAccessory2Eq.FormattingEnabled = true;
            this.cmbDanaAccessory2Eq.Location = new System.Drawing.Point(108, 118);
            this.cmbDanaAccessory2Eq.Name = "cmbDanaAccessory2Eq";
            this.cmbDanaAccessory2Eq.Size = new System.Drawing.Size(275, 21);
            this.cmbDanaAccessory2Eq.TabIndex = 25;
            this.cmbDanaAccessory2Eq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // cmbDanaAccessory1Eq
            // 
            this.cmbDanaAccessory1Eq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDanaAccessory1Eq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDanaAccessory1Eq.FormattingEnabled = true;
            this.cmbDanaAccessory1Eq.Location = new System.Drawing.Point(108, 91);
            this.cmbDanaAccessory1Eq.Name = "cmbDanaAccessory1Eq";
            this.cmbDanaAccessory1Eq.Size = new System.Drawing.Size(275, 21);
            this.cmbDanaAccessory1Eq.TabIndex = 24;
            this.cmbDanaAccessory1Eq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel56
            // 
            this.materialLabel56.AutoSize = true;
            this.materialLabel56.Depth = 0;
            this.materialLabel56.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel56.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel56.Location = new System.Drawing.Point(3, 117);
            this.materialLabel56.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel56.Name = "materialLabel56";
            this.materialLabel56.Size = new System.Drawing.Size(90, 18);
            this.materialLabel56.TabIndex = 20;
            this.materialLabel56.Text = "Accessory 2";
            // 
            // materialLabel57
            // 
            this.materialLabel57.AutoSize = true;
            this.materialLabel57.Depth = 0;
            this.materialLabel57.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel57.Location = new System.Drawing.Point(3, 90);
            this.materialLabel57.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel57.Name = "materialLabel57";
            this.materialLabel57.Size = new System.Drawing.Size(90, 18);
            this.materialLabel57.TabIndex = 19;
            this.materialLabel57.Text = "Accessory 1";
            // 
            // cmbDanaBodyEq
            // 
            this.cmbDanaBodyEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDanaBodyEq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDanaBodyEq.FormattingEnabled = true;
            this.cmbDanaBodyEq.Location = new System.Drawing.Point(108, 37);
            this.cmbDanaBodyEq.Name = "cmbDanaBodyEq";
            this.cmbDanaBodyEq.Size = new System.Drawing.Size(275, 21);
            this.cmbDanaBodyEq.TabIndex = 18;
            this.cmbDanaBodyEq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel58
            // 
            this.materialLabel58.AutoSize = true;
            this.materialLabel58.Depth = 0;
            this.materialLabel58.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel58.Location = new System.Drawing.Point(3, 36);
            this.materialLabel58.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel58.Name = "materialLabel58";
            this.materialLabel58.Size = new System.Drawing.Size(42, 18);
            this.materialLabel58.TabIndex = 17;
            this.materialLabel58.Text = "Body";
            // 
            // cmbDanaWeaponEq
            // 
            this.cmbDanaWeaponEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDanaWeaponEq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDanaWeaponEq.FormattingEnabled = true;
            this.cmbDanaWeaponEq.Location = new System.Drawing.Point(108, 10);
            this.cmbDanaWeaponEq.Name = "cmbDanaWeaponEq";
            this.cmbDanaWeaponEq.Size = new System.Drawing.Size(275, 21);
            this.cmbDanaWeaponEq.TabIndex = 16;
            this.cmbDanaWeaponEq.Tag = "adol";
            this.cmbDanaWeaponEq.MouseHover += new System.EventHandler(this.EquippedItemToolTip_MouseHover);
            // 
            // materialLabel59
            // 
            this.materialLabel59.AutoSize = true;
            this.materialLabel59.Depth = 0;
            this.materialLabel59.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel59.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel59.Location = new System.Drawing.Point(3, 12);
            this.materialLabel59.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel59.Name = "materialLabel59";
            this.materialLabel59.Size = new System.Drawing.Size(64, 18);
            this.materialLabel59.TabIndex = 15;
            this.materialLabel59.Text = "Weapon";
            // 
            // tabDanaSkills
            // 
            this.tabDanaSkills.Controls.Add(this.chkDanaSkillUnlocked);
            this.tabDanaSkills.Controls.Add(this.nudDanaSkillRank);
            this.tabDanaSkills.Controls.Add(this.materialLabel73);
            this.tabDanaSkills.Controls.Add(this.lstDanaSkills);
            this.tabDanaSkills.Location = new System.Drawing.Point(4, 22);
            this.tabDanaSkills.Name = "tabDanaSkills";
            this.tabDanaSkills.Size = new System.Drawing.Size(392, 302);
            this.tabDanaSkills.TabIndex = 2;
            this.tabDanaSkills.Text = "Skills";
            this.tabDanaSkills.UseVisualStyleBackColor = true;
            // 
            // picDana
            // 
            this.picDana.Image = global::Save_Editor.Properties.Resources.dana_icarusia;
            this.picDana.Location = new System.Drawing.Point(0, 0);
            this.picDana.Name = "picDana";
            this.picDana.Size = new System.Drawing.Size(185, 369);
            this.picDana.TabIndex = 2;
            this.picDana.TabStop = false;
            // 
            // tabCheats
            // 
            this.tabCheats.Controls.Add(this.materialLabel61);
            this.tabCheats.Controls.Add(this.radBothInventories);
            this.tabCheats.Controls.Add(this.radPreviousInventory);
            this.tabCheats.Controls.Add(this.radCurrentInventory);
            this.tabCheats.Controls.Add(this.btnApplyCheats);
            this.tabCheats.Controls.Add(this.chkMaxItemValue);
            this.tabCheats.Controls.Add(this.chkAllInventoryItems);
            this.tabCheats.Controls.Add(this.materialLabel60);
            this.tabCheats.Location = new System.Drawing.Point(4, 22);
            this.tabCheats.Name = "tabCheats";
            this.tabCheats.Size = new System.Drawing.Size(618, 424);
            this.tabCheats.TabIndex = 3;
            this.tabCheats.Text = "Cheats";
            this.tabCheats.UseVisualStyleBackColor = true;
            // 
            // materialLabel61
            // 
            this.materialLabel61.AutoSize = true;
            this.materialLabel61.Depth = 0;
            this.materialLabel61.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel61.Location = new System.Drawing.Point(3, 119);
            this.materialLabel61.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel61.Name = "materialLabel61";
            this.materialLabel61.Size = new System.Drawing.Size(55, 18);
            this.materialLabel61.TabIndex = 8;
            this.materialLabel61.Text = "Cheats";
            // 
            // radBothInventories
            // 
            this.radBothInventories.AutoSize = true;
            this.radBothInventories.Checked = true;
            this.radBothInventories.Depth = 0;
            this.radBothInventories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radBothInventories.Location = new System.Drawing.Point(7, 79);
            this.radBothInventories.Margin = new System.Windows.Forms.Padding(0);
            this.radBothInventories.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radBothInventories.MouseState = MaterialSkin.MouseState.HOVER;
            this.radBothInventories.Name = "radBothInventories";
            this.radBothInventories.Ripple = true;
            this.radBothInventories.Size = new System.Drawing.Size(58, 30);
            this.radBothInventories.TabIndex = 7;
            this.radBothInventories.TabStop = true;
            this.radBothInventories.Text = "Both";
            this.radBothInventories.UseVisualStyleBackColor = true;
            // 
            // radPreviousInventory
            // 
            this.radPreviousInventory.AutoSize = true;
            this.radPreviousInventory.Depth = 0;
            this.radPreviousInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radPreviousInventory.Location = new System.Drawing.Point(7, 49);
            this.radPreviousInventory.Margin = new System.Windows.Forms.Padding(0);
            this.radPreviousInventory.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radPreviousInventory.MouseState = MaterialSkin.MouseState.HOVER;
            this.radPreviousInventory.Name = "radPreviousInventory";
            this.radPreviousInventory.Ripple = true;
            this.radPreviousInventory.Size = new System.Drawing.Size(83, 30);
            this.radPreviousInventory.TabIndex = 6;
            this.radPreviousInventory.TabStop = true;
            this.radPreviousInventory.Text = "Previous";
            this.radPreviousInventory.UseVisualStyleBackColor = true;
            // 
            // radCurrentInventory
            // 
            this.radCurrentInventory.AutoSize = true;
            this.radCurrentInventory.Depth = 0;
            this.radCurrentInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radCurrentInventory.Location = new System.Drawing.Point(7, 19);
            this.radCurrentInventory.Margin = new System.Windows.Forms.Padding(0);
            this.radCurrentInventory.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radCurrentInventory.MouseState = MaterialSkin.MouseState.HOVER;
            this.radCurrentInventory.Name = "radCurrentInventory";
            this.radCurrentInventory.Ripple = true;
            this.radCurrentInventory.Size = new System.Drawing.Size(75, 30);
            this.radCurrentInventory.TabIndex = 5;
            this.radCurrentInventory.TabStop = true;
            this.radCurrentInventory.Text = "Current";
            this.radCurrentInventory.UseVisualStyleBackColor = true;
            // 
            // btnApplyCheats
            // 
            this.btnApplyCheats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyCheats.Depth = 0;
            this.btnApplyCheats.Location = new System.Drawing.Point(0, 401);
            this.btnApplyCheats.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnApplyCheats.Name = "btnApplyCheats";
            this.btnApplyCheats.Primary = true;
            this.btnApplyCheats.Size = new System.Drawing.Size(618, 23);
            this.btnApplyCheats.TabIndex = 3;
            this.btnApplyCheats.Text = "Apply Cheats";
            this.btnApplyCheats.UseVisualStyleBackColor = true;
            this.btnApplyCheats.Click += new System.EventHandler(this.btnApplyCheats_Click);
            // 
            // chkMaxItemValue
            // 
            this.chkMaxItemValue.AutoSize = true;
            this.chkMaxItemValue.Depth = 0;
            this.chkMaxItemValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkMaxItemValue.Location = new System.Drawing.Point(7, 168);
            this.chkMaxItemValue.Margin = new System.Windows.Forms.Padding(0);
            this.chkMaxItemValue.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkMaxItemValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkMaxItemValue.Name = "chkMaxItemValue";
            this.chkMaxItemValue.Ripple = true;
            this.chkMaxItemValue.Size = new System.Drawing.Size(114, 30);
            this.chkMaxItemValue.TabIndex = 2;
            this.chkMaxItemValue.Text = "Max All Items";
            this.chkMaxItemValue.UseVisualStyleBackColor = true;
            // 
            // chkAllInventoryItems
            // 
            this.chkAllInventoryItems.AutoSize = true;
            this.chkAllInventoryItems.Depth = 0;
            this.chkAllInventoryItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkAllInventoryItems.Location = new System.Drawing.Point(7, 138);
            this.chkAllInventoryItems.Margin = new System.Windows.Forms.Padding(0);
            this.chkAllInventoryItems.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAllInventoryItems.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAllInventoryItems.Name = "chkAllInventoryItems";
            this.chkAllInventoryItems.Ripple = true;
            this.chkAllInventoryItems.Size = new System.Drawing.Size(112, 30);
            this.chkAllInventoryItems.TabIndex = 1;
            this.chkAllInventoryItems.Text = "Add All Items";
            this.chkAllInventoryItems.UseVisualStyleBackColor = true;
            // 
            // materialLabel60
            // 
            this.materialLabel60.AutoSize = true;
            this.materialLabel60.Depth = 0;
            this.materialLabel60.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel60.Location = new System.Drawing.Point(3, 0);
            this.materialLabel60.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel60.Name = "materialLabel60";
            this.materialLabel60.Size = new System.Drawing.Size(67, 18);
            this.materialLabel60.TabIndex = 0;
            this.materialLabel60.Text = "Inventory";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.tabMainContainer;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(110, 32);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(528, 23);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // ys8CharacterBindingSource
            // 
            this.ys8CharacterBindingSource.DataSource = typeof(Save_Editor.Ys8Character);
            // 
            // ys8CharacterBindingSource1
            // 
            this.ys8CharacterBindingSource1.DataSource = typeof(Save_Editor.Ys8Character);
            // 
            // chkLaxiaSkillUnlocked
            // 
            this.chkLaxiaSkillUnlocked.AutoSize = true;
            this.chkLaxiaSkillUnlocked.Depth = 0;
            this.chkLaxiaSkillUnlocked.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkLaxiaSkillUnlocked.Location = new System.Drawing.Point(154, 29);
            this.chkLaxiaSkillUnlocked.Margin = new System.Windows.Forms.Padding(0);
            this.chkLaxiaSkillUnlocked.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkLaxiaSkillUnlocked.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkLaxiaSkillUnlocked.Name = "chkLaxiaSkillUnlocked";
            this.chkLaxiaSkillUnlocked.Ripple = true;
            this.chkLaxiaSkillUnlocked.Size = new System.Drawing.Size(87, 30);
            this.chkLaxiaSkillUnlocked.TabIndex = 7;
            this.chkLaxiaSkillUnlocked.Text = "Unlocked";
            this.chkLaxiaSkillUnlocked.UseVisualStyleBackColor = true;
            // 
            // nudLaxiaSkillRank
            // 
            this.nudLaxiaSkillRank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudLaxiaSkillRank.Location = new System.Drawing.Point(201, 6);
            this.nudLaxiaSkillRank.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudLaxiaSkillRank.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLaxiaSkillRank.Name = "nudLaxiaSkillRank";
            this.nudLaxiaSkillRank.Size = new System.Drawing.Size(188, 20);
            this.nudLaxiaSkillRank.TabIndex = 6;
            this.nudLaxiaSkillRank.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // materialLabel69
            // 
            this.materialLabel69.AutoSize = true;
            this.materialLabel69.Depth = 0;
            this.materialLabel69.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel69.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel69.Location = new System.Drawing.Point(151, 4);
            this.materialLabel69.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel69.Name = "materialLabel69";
            this.materialLabel69.Size = new System.Drawing.Size(42, 19);
            this.materialLabel69.TabIndex = 5;
            this.materialLabel69.Text = "Rank";
            // 
            // lstLaxiaSkills
            // 
            this.lstLaxiaSkills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstLaxiaSkills.FormattingEnabled = true;
            this.lstLaxiaSkills.Location = new System.Drawing.Point(3, 3);
            this.lstLaxiaSkills.Name = "lstLaxiaSkills";
            this.lstLaxiaSkills.Size = new System.Drawing.Size(142, 303);
            this.lstLaxiaSkills.TabIndex = 4;
            this.lstLaxiaSkills.SelectedValueChanged += new System.EventHandler(this.lstCharacterSkills_SelectedValueChanged);
            // 
            // chkSahadSkillUnlocked
            // 
            this.chkSahadSkillUnlocked.AutoSize = true;
            this.chkSahadSkillUnlocked.Depth = 0;
            this.chkSahadSkillUnlocked.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkSahadSkillUnlocked.Location = new System.Drawing.Point(154, 29);
            this.chkSahadSkillUnlocked.Margin = new System.Windows.Forms.Padding(0);
            this.chkSahadSkillUnlocked.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkSahadSkillUnlocked.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkSahadSkillUnlocked.Name = "chkSahadSkillUnlocked";
            this.chkSahadSkillUnlocked.Ripple = true;
            this.chkSahadSkillUnlocked.Size = new System.Drawing.Size(87, 30);
            this.chkSahadSkillUnlocked.TabIndex = 7;
            this.chkSahadSkillUnlocked.Text = "Unlocked";
            this.chkSahadSkillUnlocked.UseVisualStyleBackColor = true;
            // 
            // nudSahadSkillRank
            // 
            this.nudSahadSkillRank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSahadSkillRank.Location = new System.Drawing.Point(201, 6);
            this.nudSahadSkillRank.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSahadSkillRank.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSahadSkillRank.Name = "nudSahadSkillRank";
            this.nudSahadSkillRank.Size = new System.Drawing.Size(188, 20);
            this.nudSahadSkillRank.TabIndex = 6;
            this.nudSahadSkillRank.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // materialLabel70
            // 
            this.materialLabel70.AutoSize = true;
            this.materialLabel70.Depth = 0;
            this.materialLabel70.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel70.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel70.Location = new System.Drawing.Point(151, 4);
            this.materialLabel70.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel70.Name = "materialLabel70";
            this.materialLabel70.Size = new System.Drawing.Size(42, 19);
            this.materialLabel70.TabIndex = 5;
            this.materialLabel70.Text = "Rank";
            // 
            // lstSahadSkills
            // 
            this.lstSahadSkills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstSahadSkills.FormattingEnabled = true;
            this.lstSahadSkills.Location = new System.Drawing.Point(3, 3);
            this.lstSahadSkills.Name = "lstSahadSkills";
            this.lstSahadSkills.Size = new System.Drawing.Size(142, 303);
            this.lstSahadSkills.TabIndex = 4;
            this.lstSahadSkills.SelectedValueChanged += new System.EventHandler(this.lstCharacterSkills_SelectedValueChanged);
            // 
            // chkHummSkillUnlocked
            // 
            this.chkHummSkillUnlocked.AutoSize = true;
            this.chkHummSkillUnlocked.Depth = 0;
            this.chkHummSkillUnlocked.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkHummSkillUnlocked.Location = new System.Drawing.Point(154, 29);
            this.chkHummSkillUnlocked.Margin = new System.Windows.Forms.Padding(0);
            this.chkHummSkillUnlocked.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkHummSkillUnlocked.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkHummSkillUnlocked.Name = "chkHummSkillUnlocked";
            this.chkHummSkillUnlocked.Ripple = true;
            this.chkHummSkillUnlocked.Size = new System.Drawing.Size(87, 30);
            this.chkHummSkillUnlocked.TabIndex = 7;
            this.chkHummSkillUnlocked.Text = "Unlocked";
            this.chkHummSkillUnlocked.UseVisualStyleBackColor = true;
            // 
            // nudHummSkillRank
            // 
            this.nudHummSkillRank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudHummSkillRank.Location = new System.Drawing.Point(201, 6);
            this.nudHummSkillRank.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudHummSkillRank.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHummSkillRank.Name = "nudHummSkillRank";
            this.nudHummSkillRank.Size = new System.Drawing.Size(188, 20);
            this.nudHummSkillRank.TabIndex = 6;
            this.nudHummSkillRank.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // materialLabel71
            // 
            this.materialLabel71.AutoSize = true;
            this.materialLabel71.Depth = 0;
            this.materialLabel71.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel71.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel71.Location = new System.Drawing.Point(151, 4);
            this.materialLabel71.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel71.Name = "materialLabel71";
            this.materialLabel71.Size = new System.Drawing.Size(42, 19);
            this.materialLabel71.TabIndex = 5;
            this.materialLabel71.Text = "Rank";
            // 
            // lstHummSkills
            // 
            this.lstHummSkills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstHummSkills.FormattingEnabled = true;
            this.lstHummSkills.Location = new System.Drawing.Point(3, 3);
            this.lstHummSkills.Name = "lstHummSkills";
            this.lstHummSkills.Size = new System.Drawing.Size(142, 303);
            this.lstHummSkills.TabIndex = 4;
            this.lstHummSkills.SelectedValueChanged += new System.EventHandler(this.lstCharacterSkills_SelectedValueChanged);
            // 
            // chkRicoSkillUnlocked
            // 
            this.chkRicoSkillUnlocked.AutoSize = true;
            this.chkRicoSkillUnlocked.Depth = 0;
            this.chkRicoSkillUnlocked.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkRicoSkillUnlocked.Location = new System.Drawing.Point(154, 29);
            this.chkRicoSkillUnlocked.Margin = new System.Windows.Forms.Padding(0);
            this.chkRicoSkillUnlocked.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkRicoSkillUnlocked.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkRicoSkillUnlocked.Name = "chkRicoSkillUnlocked";
            this.chkRicoSkillUnlocked.Ripple = true;
            this.chkRicoSkillUnlocked.Size = new System.Drawing.Size(87, 30);
            this.chkRicoSkillUnlocked.TabIndex = 7;
            this.chkRicoSkillUnlocked.Text = "Unlocked";
            this.chkRicoSkillUnlocked.UseVisualStyleBackColor = true;
            // 
            // nudRicoSkillRank
            // 
            this.nudRicoSkillRank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudRicoSkillRank.Location = new System.Drawing.Point(201, 6);
            this.nudRicoSkillRank.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudRicoSkillRank.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRicoSkillRank.Name = "nudRicoSkillRank";
            this.nudRicoSkillRank.Size = new System.Drawing.Size(188, 20);
            this.nudRicoSkillRank.TabIndex = 6;
            this.nudRicoSkillRank.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // materialLabel72
            // 
            this.materialLabel72.AutoSize = true;
            this.materialLabel72.Depth = 0;
            this.materialLabel72.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel72.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel72.Location = new System.Drawing.Point(151, 4);
            this.materialLabel72.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel72.Name = "materialLabel72";
            this.materialLabel72.Size = new System.Drawing.Size(42, 19);
            this.materialLabel72.TabIndex = 5;
            this.materialLabel72.Text = "Rank";
            // 
            // lstRicoSkills
            // 
            this.lstRicoSkills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstRicoSkills.FormattingEnabled = true;
            this.lstRicoSkills.Location = new System.Drawing.Point(3, 3);
            this.lstRicoSkills.Name = "lstRicoSkills";
            this.lstRicoSkills.Size = new System.Drawing.Size(142, 303);
            this.lstRicoSkills.TabIndex = 4;
            this.lstRicoSkills.SelectedValueChanged += new System.EventHandler(this.lstCharacterSkills_SelectedValueChanged);
            // 
            // chkDanaSkillUnlocked
            // 
            this.chkDanaSkillUnlocked.AutoSize = true;
            this.chkDanaSkillUnlocked.Depth = 0;
            this.chkDanaSkillUnlocked.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkDanaSkillUnlocked.Location = new System.Drawing.Point(154, 29);
            this.chkDanaSkillUnlocked.Margin = new System.Windows.Forms.Padding(0);
            this.chkDanaSkillUnlocked.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkDanaSkillUnlocked.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkDanaSkillUnlocked.Name = "chkDanaSkillUnlocked";
            this.chkDanaSkillUnlocked.Ripple = true;
            this.chkDanaSkillUnlocked.Size = new System.Drawing.Size(87, 30);
            this.chkDanaSkillUnlocked.TabIndex = 7;
            this.chkDanaSkillUnlocked.Text = "Unlocked";
            this.chkDanaSkillUnlocked.UseVisualStyleBackColor = true;
            // 
            // nudDanaSkillRank
            // 
            this.nudDanaSkillRank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDanaSkillRank.Location = new System.Drawing.Point(201, 6);
            this.nudDanaSkillRank.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudDanaSkillRank.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDanaSkillRank.Name = "nudDanaSkillRank";
            this.nudDanaSkillRank.Size = new System.Drawing.Size(188, 20);
            this.nudDanaSkillRank.TabIndex = 6;
            this.nudDanaSkillRank.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // materialLabel73
            // 
            this.materialLabel73.AutoSize = true;
            this.materialLabel73.Depth = 0;
            this.materialLabel73.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel73.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel73.Location = new System.Drawing.Point(151, 4);
            this.materialLabel73.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel73.Name = "materialLabel73";
            this.materialLabel73.Size = new System.Drawing.Size(42, 19);
            this.materialLabel73.TabIndex = 5;
            this.materialLabel73.Text = "Rank";
            // 
            // lstDanaSkills
            // 
            this.lstDanaSkills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstDanaSkills.FormattingEnabled = true;
            this.lstDanaSkills.Location = new System.Drawing.Point(3, 3);
            this.lstDanaSkills.Name = "lstDanaSkills";
            this.lstDanaSkills.Size = new System.Drawing.Size(142, 303);
            this.lstDanaSkills.TabIndex = 4;
            this.lstDanaSkills.SelectedValueChanged += new System.EventHandler(this.lstCharacterSkills_SelectedValueChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 540);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabMainContainer);
            this.MinimumSize = new System.Drawing.Size(650, 540);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Save Editor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.cmsCurrentItems.ResumeLayout(false);
            this.tabMainContainer.ResumeLayout(false);
            this.tabFile.ResumeLayout(false);
            this.tabInventory.ResumeLayout(false);
            this.tabInventoryContainer.ResumeLayout(false);
            this.tabCurrentInventory.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentItemCount)).EndInit();
            this.tabPreviousInventory.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.cmsPreviousItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrevItemCount)).EndInit();
            this.tabCharacter.ResumeLayout(false);
            this.tabCharacterContainer.ResumeLayout(false);
            this.tabAdol.ResumeLayout(false);
            this.tabAdolInfoContainer.ResumeLayout(false);
            this.tabIAdalInfo.ResumeLayout(false);
            this.tabIAdalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdolMaxHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdolLvl)).EndInit();
            this.tabAdolEquipped.ResumeLayout(false);
            this.tabAdolEquipped.PerformLayout();
            this.tabAdolSkills.ResumeLayout(false);
            this.tabAdolSkills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdolSkillRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdol)).EndInit();
            this.tabLaxia.ResumeLayout(false);
            this.tabLaxiaInfoContainer.ResumeLayout(false);
            this.tabLaxiaInfo.ResumeLayout(false);
            this.tabLaxiaInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLaxiaMaxHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLaxiaLvl)).EndInit();
            this.tabLaxiaEquipped.ResumeLayout(false);
            this.tabLaxiaEquipped.PerformLayout();
            this.tabLaxiaSkills.ResumeLayout(false);
            this.tabLaxiaSkills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLaxia)).EndInit();
            this.tabSahad.ResumeLayout(false);
            this.tabSahadInfoContainer.ResumeLayout(false);
            this.tabSahadInfo.ResumeLayout(false);
            this.tabSahadInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSahadMaxHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSahadLvl)).EndInit();
            this.tabSahadEquipped.ResumeLayout(false);
            this.tabSahadEquipped.PerformLayout();
            this.tabSahadSkills.ResumeLayout(false);
            this.tabSahadSkills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSahad)).EndInit();
            this.tabHummel.ResumeLayout(false);
            this.tabHummInfoContainer.ResumeLayout(false);
            this.tabHummInfo.ResumeLayout(false);
            this.tabHummInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHummMaxHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHummLvl)).EndInit();
            this.tabHummEquipped.ResumeLayout(false);
            this.tabHummEquipped.PerformLayout();
            this.tabHummSkills.ResumeLayout(false);
            this.tabHummSkills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHummel)).EndInit();
            this.tabRicotta.ResumeLayout(false);
            this.tabRicoInfoContainer.ResumeLayout(false);
            this.tabRicoInfo.ResumeLayout(false);
            this.tabRicoInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRicoMaxHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRicoLvl)).EndInit();
            this.tabRicoEquppied.ResumeLayout(false);
            this.tabRicoEquppied.PerformLayout();
            this.tabRicoSkills.ResumeLayout(false);
            this.tabRicoSkills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRicotta)).EndInit();
            this.tabDana.ResumeLayout(false);
            this.tabDanaInfoContainer.ResumeLayout(false);
            this.tabDanaInfo.ResumeLayout(false);
            this.tabDanaInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDanaMaxHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDanaLvl)).EndInit();
            this.tabDanaEquipped.ResumeLayout(false);
            this.tabDanaEquipped.PerformLayout();
            this.tabDanaSkills.ResumeLayout(false);
            this.tabDanaSkills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDana)).EndInit();
            this.tabCheats.ResumeLayout(false);
            this.tabCheats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ys8CharacterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ys8CharacterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLaxiaSkillRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSahadSkillRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHummSkillRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRicoSkillRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDanaSkillRank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        private MaterialSkin.Controls.MaterialTabControl tabMainContainer;
        private System.Windows.Forms.TabPage tabFile;
        private System.Windows.Forms.TabPage tabInventory;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.TabPage tabCharacter;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialTabControl tabCharacterContainer;
        private System.Windows.Forms.TabPage tabAdol;
        private System.Windows.Forms.TabPage tabLaxia;
        private System.Windows.Forms.TabPage tabSahad;
        private System.Windows.Forms.TabPage tabHummel;
        private System.Windows.Forms.TabPage tabRicotta;
        private System.Windows.Forms.TabPage tabDana;
        private System.Windows.Forms.PictureBox picAdol;
        private System.Windows.Forms.PictureBox picLaxia;
        private System.Windows.Forms.PictureBox picSahad;
        private System.Windows.Forms.PictureBox picHummel;
        private System.Windows.Forms.PictureBox picRicotta;
        private System.Windows.Forms.PictureBox picDana;
        private System.Windows.Forms.NumericUpDown nudAdolLvl;
        private MaterialSkin.Controls.MaterialLabel lblCharacterName;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTabControl tabAdolInfoContainer;
        private System.Windows.Forms.TabPage tabIAdalInfo;
        private System.Windows.Forms.TabPage tabAdolEquipped;
        private MaterialSkin.Controls.MaterialTabSelector selCharacterInformation;
        private System.Windows.Forms.ComboBox cmbAdolAccessory2Eq;
        private System.Windows.Forms.ComboBox cmbAdolAccessory1Eq;
        private MaterialSkin.Controls.MaterialLabel materialLabel29;
        private MaterialSkin.Controls.MaterialLabel materialLabel28;
        private System.Windows.Forms.ComboBox cmbAdolBodyEq;
        private MaterialSkin.Controls.MaterialLabel materialLabel27;
        private System.Windows.Forms.ComboBox cmbAdolWeaponEq;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector4;
        private System.Windows.Forms.ComboBox cmbAdolArmEq;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialContextMenuStrip cmsCurrentItems;
        private System.Windows.Forms.ToolStripMenuItem mnuiCurrAddItem;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector3;
        private MaterialSkin.Controls.MaterialTabControl tabLaxiaInfoContainer;
        private System.Windows.Forms.TabPage tabLaxiaInfo;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.NumericUpDown nudLaxiaLvl;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private System.Windows.Forms.TabPage tabLaxiaEquipped;
        private System.Windows.Forms.ComboBox cmbLaxiaArmEq;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private System.Windows.Forms.ComboBox cmbLaxiaAccessory2Eq;
        private System.Windows.Forms.ComboBox cmbLaxiaAccessory1Eq;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private System.Windows.Forms.ComboBox cmbLaxiaBodyEq;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private System.Windows.Forms.ComboBox cmbLaxiaWeaponEq;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector5;
        private MaterialSkin.Controls.MaterialTabControl tabSahadInfoContainer;
        private System.Windows.Forms.TabPage tabSahadInfo;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private System.Windows.Forms.NumericUpDown nudSahadLvl;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private System.Windows.Forms.TabPage tabSahadEquipped;
        private System.Windows.Forms.ComboBox cmbSahadArmEq;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
        private System.Windows.Forms.ComboBox cmbSahadAccessory2Eq;
        private System.Windows.Forms.ComboBox cmbSahadAccessory1Eq;
        private MaterialSkin.Controls.MaterialLabel materialLabel22;
        private MaterialSkin.Controls.MaterialLabel materialLabel23;
        private System.Windows.Forms.ComboBox cmbSahadBodyEq;
        private MaterialSkin.Controls.MaterialLabel materialLabel24;
        private System.Windows.Forms.ComboBox cmbSahadWeaponEq;
        private MaterialSkin.Controls.MaterialLabel materialLabel25;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector6;
        private MaterialSkin.Controls.MaterialTabControl tabHummInfoContainer;
        private System.Windows.Forms.TabPage tabHummInfo;
        private MaterialSkin.Controls.MaterialLabel materialLabel30;
        private MaterialSkin.Controls.MaterialLabel materialLabel31;
        private System.Windows.Forms.NumericUpDown nudHummLvl;
        private MaterialSkin.Controls.MaterialLabel materialLabel32;
        private System.Windows.Forms.TabPage tabHummEquipped;
        private System.Windows.Forms.ComboBox cmbHummArmEq;
        private MaterialSkin.Controls.MaterialLabel materialLabel34;
        private System.Windows.Forms.ComboBox cmbHummAccessory2Eq;
        private System.Windows.Forms.ComboBox cmbHummAccessory1Eq;
        private MaterialSkin.Controls.MaterialLabel materialLabel35;
        private MaterialSkin.Controls.MaterialLabel materialLabel36;
        private System.Windows.Forms.ComboBox cmbHummBodyEq;
        private MaterialSkin.Controls.MaterialLabel materialLabel37;
        private System.Windows.Forms.ComboBox cmbHummWeaponEq;
        private MaterialSkin.Controls.MaterialLabel materialLabel41;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector7;
        private MaterialSkin.Controls.MaterialTabControl tabRicoInfoContainer;
        private System.Windows.Forms.TabPage tabRicoInfo;
        private MaterialSkin.Controls.MaterialLabel materialLabel43;
        private MaterialSkin.Controls.MaterialLabel materialLabel45;
        private System.Windows.Forms.NumericUpDown nudRicoLvl;
        private MaterialSkin.Controls.MaterialLabel materialLabel46;
        private System.Windows.Forms.TabPage tabRicoEquppied;
        private System.Windows.Forms.ComboBox cmbRicoArmEq;
        private MaterialSkin.Controls.MaterialLabel materialLabel47;
        private System.Windows.Forms.ComboBox cmbRicoAccessory2Eq;
        private System.Windows.Forms.ComboBox cmbRicoAccessory1Eq;
        private MaterialSkin.Controls.MaterialLabel materialLabel48;
        private MaterialSkin.Controls.MaterialLabel materialLabel49;
        private System.Windows.Forms.ComboBox cmbRicoBodyEq;
        private MaterialSkin.Controls.MaterialLabel materialLabel50;
        private System.Windows.Forms.ComboBox cmbRicoWeaponEq;
        private MaterialSkin.Controls.MaterialLabel materialLabel51;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector8;
        private MaterialSkin.Controls.MaterialTabControl tabDanaInfoContainer;
        private System.Windows.Forms.TabPage tabDanaInfo;
        private MaterialSkin.Controls.MaterialLabel materialLabel52;
        private MaterialSkin.Controls.MaterialLabel materialLabel53;
        private System.Windows.Forms.NumericUpDown nudDanaLvl;
        private MaterialSkin.Controls.MaterialLabel materialLabel54;
        private System.Windows.Forms.TabPage tabDanaEquipped;
        private System.Windows.Forms.ComboBox cmbDanaArmEq;
        private MaterialSkin.Controls.MaterialLabel materialLabel55;
        private System.Windows.Forms.ComboBox cmbDanaAccessory2Eq;
        private System.Windows.Forms.ComboBox cmbDanaAccessory1Eq;
        private MaterialSkin.Controls.MaterialLabel materialLabel56;
        private MaterialSkin.Controls.MaterialLabel materialLabel57;
        private System.Windows.Forms.ComboBox cmbDanaBodyEq;
        private MaterialSkin.Controls.MaterialLabel materialLabel58;
        private System.Windows.Forms.ComboBox cmbDanaWeaponEq;
        private MaterialSkin.Controls.MaterialLabel materialLabel59;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem;
        private MaterialSkin.Controls.MaterialContextMenuStrip cmsPreviousItems;
        private System.Windows.Forms.ToolStripMenuItem mnuiPrevAddItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TabPage tabCheats;
        private MaterialSkin.Controls.MaterialLabel materialLabel60;
        private MaterialSkin.Controls.MaterialCheckBox chkAllInventoryItems;
        private MaterialSkin.Controls.MaterialCheckBox chkMaxItemValue;
        private MaterialSkin.Controls.MaterialRaisedButton btnApplyCheats;
        private MaterialSkin.Controls.MaterialLabel materialLabel61;
        private MaterialSkin.Controls.MaterialRadioButton radBothInventories;
        private MaterialSkin.Controls.MaterialRadioButton radPreviousInventory;
        private MaterialSkin.Controls.MaterialRadioButton radCurrentInventory;
        private System.Windows.Forms.ToolTip tipEquippedItem;
        private MaterialSkin.Controls.MaterialTabControl tabInventoryContainer;
        private System.Windows.Forms.TabPage tabCurrentInventory;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trvCurrentInventory;
        private MaterialSkin.Controls.MaterialLabel lblCurrentItemRank;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.NumericUpDown nudCurrentItemCount;
        private MaterialSkin.Controls.MaterialLabel lblCurrentItemCount;
        private MaterialSkin.Controls.MaterialLabel lblCurrentItemName;
        private MaterialSkin.Controls.MaterialLabel lblCurrentItemId;
        private MaterialSkin.Controls.MaterialLabel lblCurrentItemType;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblCurrentItemDescription;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblCurrentItemEffect;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TabPage tabPreviousInventory;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView trvPreviousInventory;
        private MaterialSkin.Controls.MaterialLabel lblPrevItemRank;
        private MaterialSkin.Controls.MaterialLabel materialLabel33;
        private System.Windows.Forms.NumericUpDown nudPrevItemCount;
        private MaterialSkin.Controls.MaterialLabel lblPrevItemCount;
        private MaterialSkin.Controls.MaterialLabel lblPrevItemName;
        private MaterialSkin.Controls.MaterialLabel lblPrevItemId;
        private MaterialSkin.Controls.MaterialLabel lblPrevItemType;
        private MaterialSkin.Controls.MaterialLabel materialLabel38;
        private MaterialSkin.Controls.MaterialLabel materialLabel39;
        private MaterialSkin.Controls.MaterialLabel materialLabel40;
        private MaterialSkin.Controls.MaterialLabel lblPrevItemDescription;
        private MaterialSkin.Controls.MaterialLabel materialLabel42;
        private MaterialSkin.Controls.MaterialLabel lblPrevItemEffect;
        private MaterialSkin.Controls.MaterialLabel materialLabel44;
        private MaterialSkin.Controls.MaterialLabel materialLabel62;
        private System.Windows.Forms.NumericUpDown nudAdolMaxHp;
        private MaterialSkin.Controls.MaterialLabel materialLabel63;
        private System.Windows.Forms.NumericUpDown nudLaxiaMaxHp;
        private MaterialSkin.Controls.MaterialLabel materialLabel64;
        private System.Windows.Forms.NumericUpDown nudSahadMaxHp;
        private MaterialSkin.Controls.MaterialLabel materialLabel65;
        private System.Windows.Forms.NumericUpDown nudHummMaxHp;
        private MaterialSkin.Controls.MaterialLabel materialLabel66;
        private System.Windows.Forms.NumericUpDown nudRicoMaxHp;
        private MaterialSkin.Controls.MaterialLabel materialLabel67;
        private System.Windows.Forms.NumericUpDown nudDanaMaxHp;
        private MaterialSkin.Controls.MaterialCheckBox chkAdolHp;
        private MaterialSkin.Controls.MaterialCheckBox chkLaxiaHp;
        private MaterialSkin.Controls.MaterialCheckBox chkSahadHp;
        private MaterialSkin.Controls.MaterialCheckBox chkHummHp;
        private MaterialSkin.Controls.MaterialCheckBox chkRicoHp;
        private MaterialSkin.Controls.MaterialCheckBox chkDanaHp;
        private System.Windows.Forms.BindingSource ys8CharacterBindingSource;
        private System.Windows.Forms.TabPage tabAdolSkills;
        private System.Windows.Forms.TabPage tabLaxiaSkills;
        private System.Windows.Forms.TabPage tabSahadSkills;
        private System.Windows.Forms.TabPage tabHummSkills;
        private System.Windows.Forms.TabPage tabRicoSkills;
        private System.Windows.Forms.TabPage tabDanaSkills;
        private System.Windows.Forms.NumericUpDown nudAdolSkillRank;
        private MaterialSkin.Controls.MaterialLabel materialLabel68;
        private System.Windows.Forms.ListBox lstAdolSkills;
        private MaterialSkin.Controls.MaterialCheckBox chkAdolSkillUnlocked;
        private System.Windows.Forms.BindingSource ys8CharacterBindingSource1;
        private MaterialSkin.Controls.MaterialCheckBox chkLaxiaSkillUnlocked;
        private System.Windows.Forms.NumericUpDown nudLaxiaSkillRank;
        private MaterialSkin.Controls.MaterialLabel materialLabel69;
        private System.Windows.Forms.ListBox lstLaxiaSkills;
        private MaterialSkin.Controls.MaterialCheckBox chkSahadSkillUnlocked;
        private System.Windows.Forms.NumericUpDown nudSahadSkillRank;
        private MaterialSkin.Controls.MaterialLabel materialLabel70;
        private System.Windows.Forms.ListBox lstSahadSkills;
        private MaterialSkin.Controls.MaterialCheckBox chkHummSkillUnlocked;
        private System.Windows.Forms.NumericUpDown nudHummSkillRank;
        private MaterialSkin.Controls.MaterialLabel materialLabel71;
        private System.Windows.Forms.ListBox lstHummSkills;
        private MaterialSkin.Controls.MaterialCheckBox chkRicoSkillUnlocked;
        private System.Windows.Forms.NumericUpDown nudRicoSkillRank;
        private MaterialSkin.Controls.MaterialLabel materialLabel72;
        private System.Windows.Forms.ListBox lstRicoSkills;
        private MaterialSkin.Controls.MaterialCheckBox chkDanaSkillUnlocked;
        private System.Windows.Forms.NumericUpDown nudDanaSkillRank;
        private MaterialSkin.Controls.MaterialLabel materialLabel73;
        private System.Windows.Forms.ListBox lstDanaSkills;
    }
}

