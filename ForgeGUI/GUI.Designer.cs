namespace ForgeGUI
{
    partial class GUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            pnlVault = new Panel();
            pnlAddEdit = new Panel();
            btnClearAddEditPanel = new Button();
            btnSaveKey = new Button();
            btnExitAddEditPanel = new Button();
            btnGenerateRandomPassword = new Button();
            txtNotes = new TextBox();
            label10 = new Label();
            txtPassword = new TextBox();
            label9 = new Label();
            txtUsername = new TextBox();
            label8 = new Label();
            txtService = new TextBox();
            label5 = new Label();
            pnlDgvKeyList = new Panel();
            dgvKeyList = new DataGridView();
            Service = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Notes = new DataGridViewTextBoxColumn();
            pnlNewVault = new Panel();
            panel1 = new Panel();
            btnCreateVaultKey = new Button();
            btnCancelNewVaultSetup = new Button();
            lblNewDirectory = new Label();
            btnNewDirectory = new Button();
            txtNewVaultID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pnlLocked = new Panel();
            panel3 = new Panel();
            picLogo = new PictureBox();
            btnUnlockVault = new Button();
            btnNewVault = new Button();
            lblDirectory = new Label();
            btnDirectory = new Button();
            txtVaultID = new TextBox();
            label6 = new Label();
            label7 = new Label();
            ofdVaultKey = new OpenFileDialog();
            fbdNewVaultKey = new FolderBrowserDialog();
            menuMain = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuNewVault = new ToolStripMenuItem();
            menuView = new ToolStripMenuItem();
            menuMinimize = new ToolStripMenuItem();
            menuVault = new ToolStripMenuItem();
            menuAddKey = new ToolStripMenuItem();
            menuDeleteKey = new ToolStripMenuItem();
            menuEditKey = new ToolStripMenuItem();
            menuExportVault = new ToolStripMenuItem();
            exportAsTxtToolStripMenuItem = new ToolStripMenuItem();
            exportAsjsonToolStripMenuItem = new ToolStripMenuItem();
            exportAsCsvToolStripMenuItem = new ToolStripMenuItem();
            exportAsxmlToolStripMenuItem = new ToolStripMenuItem();
            menuLockVault = new ToolStripMenuItem();
            menuSaveVault = new ToolStripMenuItem();
            menuHelp = new ToolStripMenuItem();
            reportABugToolStripMenuItem = new ToolStripMenuItem();
            statStrip = new StatusStrip();
            statStripVersion = new ToolStripStatusLabel();
            tsbReportBug = new ToolStripSplitButton();
            tsbReportBugSub = new ToolStripMenuItem();
            toolVault = new ToolStrip();
            tsbLock = new ToolStripButton();
            tsbSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbAdd = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbExport = new ToolStripButton();
            pnlVault.SuspendLayout();
            pnlAddEdit.SuspendLayout();
            pnlDgvKeyList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKeyList).BeginInit();
            pnlNewVault.SuspendLayout();
            panel1.SuspendLayout();
            pnlLocked.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            menuMain.SuspendLayout();
            statStrip.SuspendLayout();
            toolVault.SuspendLayout();
            SuspendLayout();
            // 
            // pnlVault
            // 
            pnlVault.Controls.Add(pnlAddEdit);
            pnlVault.Controls.Add(pnlDgvKeyList);
            pnlVault.Location = new Point(1, 52);
            pnlVault.Name = "pnlVault";
            pnlVault.Size = new Size(608, 347);
            pnlVault.TabIndex = 0;
            pnlVault.Visible = false;
            // 
            // pnlAddEdit
            // 
            pnlAddEdit.BorderStyle = BorderStyle.Fixed3D;
            pnlAddEdit.Controls.Add(btnClearAddEditPanel);
            pnlAddEdit.Controls.Add(btnSaveKey);
            pnlAddEdit.Controls.Add(btnExitAddEditPanel);
            pnlAddEdit.Controls.Add(btnGenerateRandomPassword);
            pnlAddEdit.Controls.Add(txtNotes);
            pnlAddEdit.Controls.Add(label10);
            pnlAddEdit.Controls.Add(txtPassword);
            pnlAddEdit.Controls.Add(label9);
            pnlAddEdit.Controls.Add(txtUsername);
            pnlAddEdit.Controls.Add(label8);
            pnlAddEdit.Controls.Add(txtService);
            pnlAddEdit.Controls.Add(label5);
            pnlAddEdit.Location = new Point(0, 0);
            pnlAddEdit.Name = "pnlAddEdit";
            pnlAddEdit.Size = new Size(608, 347);
            pnlAddEdit.TabIndex = 7;
            pnlAddEdit.Visible = false;
            // 
            // btnClearAddEditPanel
            // 
            btnClearAddEditPanel.Location = new Point(347, 247);
            btnClearAddEditPanel.Name = "btnClearAddEditPanel";
            btnClearAddEditPanel.Size = new Size(78, 23);
            btnClearAddEditPanel.TabIndex = 18;
            btnClearAddEditPanel.Text = "Clea&r";
            btnClearAddEditPanel.UseVisualStyleBackColor = true;
            btnClearAddEditPanel.Click += Clear_Click;
            // 
            // btnSaveKey
            // 
            btnSaveKey.Location = new Point(263, 247);
            btnSaveKey.Name = "btnSaveKey";
            btnSaveKey.Size = new Size(78, 23);
            btnSaveKey.TabIndex = 17;
            btnSaveKey.Text = "Confir&m";
            btnSaveKey.UseVisualStyleBackColor = true;
            btnSaveKey.Click += SaveKey_Click;
            // 
            // btnExitAddEditPanel
            // 
            btnExitAddEditPanel.Location = new Point(179, 247);
            btnExitAddEditPanel.Name = "btnExitAddEditPanel";
            btnExitAddEditPanel.Size = new Size(78, 23);
            btnExitAddEditPanel.TabIndex = 16;
            btnExitAddEditPanel.Text = "&Back";
            btnExitAddEditPanel.UseVisualStyleBackColor = true;
            btnExitAddEditPanel.Click += btnExitAddEditPanel_Click;
            // 
            // btnGenerateRandomPassword
            // 
            btnGenerateRandomPassword.Location = new Point(179, 218);
            btnGenerateRandomPassword.Name = "btnGenerateRandomPassword";
            btnGenerateRandomPassword.Size = new Size(246, 23);
            btnGenerateRandomPassword.TabIndex = 15;
            btnGenerateRandomPassword.Text = "&Generate Random Password";
            btnGenerateRandomPassword.UseVisualStyleBackColor = true;
            btnGenerateRandomPassword.Click += GenerateRandomPassword_Click;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(233, 145);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(213, 23);
            txtNotes.TabIndex = 14;
            // 
            // label10
            // 
            label10.Location = new Point(159, 150);
            label10.Name = "label10";
            label10.Size = new Size(68, 18);
            label10.TabIndex = 22;
            label10.Text = "Notes:";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(233, 116);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(213, 23);
            txtPassword.TabIndex = 13;
            // 
            // label9
            // 
            label9.Location = new Point(159, 121);
            label9.Name = "label9";
            label9.Size = new Size(68, 18);
            label9.TabIndex = 20;
            label9.Text = "Password:";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(233, 87);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(213, 23);
            txtUsername.TabIndex = 12;
            // 
            // label8
            // 
            label8.Location = new Point(159, 92);
            label8.Name = "label8";
            label8.Size = new Size(68, 18);
            label8.TabIndex = 18;
            label8.Text = "Username:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // txtService
            // 
            txtService.Location = new Point(233, 58);
            txtService.Name = "txtService";
            txtService.Size = new Size(213, 23);
            txtService.TabIndex = 11;
            // 
            // label5
            // 
            label5.Location = new Point(159, 63);
            label5.Name = "label5";
            label5.Size = new Size(68, 18);
            label5.TabIndex = 0;
            label5.Text = "Service:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // pnlDgvKeyList
            // 
            pnlDgvKeyList.BorderStyle = BorderStyle.Fixed3D;
            pnlDgvKeyList.Controls.Add(dgvKeyList);
            pnlDgvKeyList.Dock = DockStyle.Fill;
            pnlDgvKeyList.Location = new Point(0, 0);
            pnlDgvKeyList.Name = "pnlDgvKeyList";
            pnlDgvKeyList.Size = new Size(608, 347);
            pnlDgvKeyList.TabIndex = 5;
            // 
            // dgvKeyList
            // 
            dgvKeyList.AllowUserToAddRows = false;
            dgvKeyList.AllowUserToDeleteRows = false;
            dgvKeyList.AllowUserToResizeRows = false;
            dgvKeyList.BorderStyle = BorderStyle.Fixed3D;
            dgvKeyList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvKeyList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKeyList.Columns.AddRange(new DataGridViewColumn[] { Service, Username, Password, Notes });
            dgvKeyList.Dock = DockStyle.Fill;
            dgvKeyList.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvKeyList.Location = new Point(0, 0);
            dgvKeyList.MultiSelect = false;
            dgvKeyList.Name = "dgvKeyList";
            dgvKeyList.RowHeadersVisible = false;
            dgvKeyList.Size = new Size(604, 343);
            dgvKeyList.TabIndex = 6;
            dgvKeyList.SelectionChanged += dgvKeyList_SelectionChanged;
            // 
            // Service
            // 
            Service.HeaderText = "Service";
            Service.Name = "Service";
            Service.ReadOnly = true;
            Service.Width = 120;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.Width = 120;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.Width = 120;
            // 
            // Notes
            // 
            Notes.HeaderText = "Notes";
            Notes.Name = "Notes";
            Notes.ReadOnly = true;
            Notes.Width = 350;
            // 
            // pnlNewVault
            // 
            pnlNewVault.Controls.Add(panel1);
            pnlNewVault.Location = new Point(1, 52);
            pnlNewVault.Name = "pnlNewVault";
            pnlNewVault.Size = new Size(608, 347);
            pnlNewVault.TabIndex = 6;
            pnlNewVault.Visible = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnCreateVaultKey);
            panel1.Controls.Add(btnCancelNewVaultSetup);
            panel1.Controls.Add(lblNewDirectory);
            panel1.Controls.Add(btnNewDirectory);
            panel1.Controls.Add(txtNewVaultID);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(84, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 251);
            panel1.TabIndex = 6;
            // 
            // btnCreateVaultKey
            // 
            btnCreateVaultKey.Location = new Point(205, 203);
            btnCreateVaultKey.Name = "btnCreateVaultKey";
            btnCreateVaultKey.Size = new Size(124, 23);
            btnCreateVaultKey.TabIndex = 10;
            btnCreateVaultKey.Text = "Create &Vault";
            btnCreateVaultKey.UseVisualStyleBackColor = true;
            btnCreateVaultKey.Click += btnCreateVaultKey_Click;
            // 
            // btnCancelNewVaultSetup
            // 
            btnCancelNewVaultSetup.Location = new Point(108, 203);
            btnCancelNewVaultSetup.Name = "btnCancelNewVaultSetup";
            btnCancelNewVaultSetup.Size = new Size(91, 23);
            btnCancelNewVaultSetup.TabIndex = 9;
            btnCancelNewVaultSetup.Text = "&Cancel";
            btnCancelNewVaultSetup.UseVisualStyleBackColor = true;
            btnCancelNewVaultSetup.Click += btnCancelNewVaultSetup_Click;
            // 
            // lblNewDirectory
            // 
            lblNewDirectory.BorderStyle = BorderStyle.Fixed3D;
            lblNewDirectory.Location = new Point(196, 156);
            lblNewDirectory.Name = "lblNewDirectory";
            lblNewDirectory.Size = new Size(147, 18);
            lblNewDirectory.TabIndex = 8;
            // 
            // btnNewDirectory
            // 
            btnNewDirectory.Location = new Point(163, 152);
            btnNewDirectory.Name = "btnNewDirectory";
            btnNewDirectory.Size = new Size(27, 23);
            btnNewDirectory.TabIndex = 7;
            btnNewDirectory.Text = "🗀";
            btnNewDirectory.UseVisualStyleBackColor = true;
            btnNewDirectory.Click += btnNewDirectory_Click;
            // 
            // txtNewVaultID
            // 
            txtNewVaultID.Location = new Point(163, 120);
            txtNewVaultID.Name = "txtNewVaultID";
            txtNewVaultID.Size = new Size(180, 23);
            txtNewVaultID.TabIndex = 6;
            // 
            // label4
            // 
            label4.Location = new Point(94, 156);
            label4.Name = "label4";
            label4.Size = new Size(63, 18);
            label4.TabIndex = 9;
            label4.Text = "Directory:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.Location = new Point(94, 125);
            label3.Name = "label3";
            label3.Size = new Size(63, 18);
            label3.TabIndex = 8;
            label3.Text = "Vault ID:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(13, 17);
            label2.Name = "label2";
            label2.Size = new Size(411, 79);
            label2.TabIndex = 7;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlLocked
            // 
            pnlLocked.Controls.Add(panel3);
            pnlLocked.Location = new Point(1, 52);
            pnlLocked.Name = "pnlLocked";
            pnlLocked.Size = new Size(608, 347);
            pnlLocked.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(picLogo);
            panel3.Controls.Add(btnUnlockVault);
            panel3.Controls.Add(btnNewVault);
            panel3.Controls.Add(lblDirectory);
            panel3.Controls.Add(btnDirectory);
            panel3.Controls.Add(txtVaultID);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(84, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(441, 251);
            panel3.TabIndex = 6;
            // 
            // picLogo
            // 
            picLogo.AccessibleRole = AccessibleRole.Graphic;
            picLogo.BackgroundImageLayout = ImageLayout.Stretch;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(82, 25);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(273, 72);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 17;
            picLogo.TabStop = false;
            // 
            // btnUnlockVault
            // 
            btnUnlockVault.Location = new Point(221, 196);
            btnUnlockVault.Name = "btnUnlockVault";
            btnUnlockVault.Size = new Size(122, 23);
            btnUnlockVault.TabIndex = 5;
            btnUnlockVault.Text = "&Unlock Vault";
            btnUnlockVault.UseVisualStyleBackColor = true;
            btnUnlockVault.Click += btnUnlockVault_Click;
            // 
            // btnNewVault
            // 
            btnNewVault.Location = new Point(94, 196);
            btnNewVault.Name = "btnNewVault";
            btnNewVault.Size = new Size(122, 23);
            btnNewVault.TabIndex = 4;
            btnNewVault.Text = "&New Vault";
            btnNewVault.UseVisualStyleBackColor = true;
            btnNewVault.Click += btnNewVault_Click;
            // 
            // lblDirectory
            // 
            lblDirectory.BorderStyle = BorderStyle.Fixed3D;
            lblDirectory.Location = new Point(196, 155);
            lblDirectory.Name = "lblDirectory";
            lblDirectory.Size = new Size(147, 18);
            lblDirectory.TabIndex = 3;
            // 
            // btnDirectory
            // 
            btnDirectory.Location = new Point(163, 151);
            btnDirectory.Name = "btnDirectory";
            btnDirectory.Size = new Size(27, 23);
            btnDirectory.TabIndex = 2;
            btnDirectory.Text = "🗀";
            btnDirectory.UseVisualStyleBackColor = true;
            btnDirectory.Click += btnDirectory_Click;
            // 
            // txtVaultID
            // 
            txtVaultID.AccessibleRole = AccessibleRole.Text;
            txtVaultID.Location = new Point(163, 119);
            txtVaultID.Name = "txtVaultID";
            txtVaultID.Size = new Size(180, 23);
            txtVaultID.TabIndex = 1;
            // 
            // label6
            // 
            label6.Location = new Point(94, 155);
            label6.Name = "label6";
            label6.Size = new Size(63, 18);
            label6.TabIndex = 9;
            label6.Text = "Key:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label7
            // 
            label7.Location = new Point(94, 124);
            label7.Name = "label7";
            label7.Size = new Size(63, 18);
            label7.TabIndex = 8;
            label7.Text = "Vault ID:";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // ofdVaultKey
            // 
            ofdVaultKey.DefaultExt = "fvk";
            // 
            // menuMain
            // 
            menuMain.AccessibleRole = AccessibleRole.MenuBar;
            menuMain.BackColor = SystemColors.Control;
            menuMain.Items.AddRange(new ToolStripItem[] { menuFile, menuView, menuVault, menuHelp });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(611, 24);
            menuMain.TabIndex = 8;
            menuMain.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.BackColor = SystemColors.Control;
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuNewVault });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(37, 20);
            menuFile.Text = "File";
            // 
            // menuNewVault
            // 
            menuNewVault.BackColor = SystemColors.Control;
            menuNewVault.Image = (Image)resources.GetObject("menuNewVault.Image");
            menuNewVault.Name = "menuNewVault";
            menuNewVault.ShortcutKeys = Keys.Alt | Keys.N;
            menuNewVault.Size = new Size(166, 22);
            menuNewVault.Text = "New Vault";
            menuNewVault.Click += menuNewVault_Click;
            // 
            // menuView
            // 
            menuView.DropDownItems.AddRange(new ToolStripItem[] { menuMinimize });
            menuView.Name = "menuView";
            menuView.Size = new Size(44, 20);
            menuView.Text = "View";
            // 
            // menuMinimize
            // 
            menuMinimize.Image = (Image)resources.GetObject("menuMinimize.Image");
            menuMinimize.Name = "menuMinimize";
            menuMinimize.Size = new Size(123, 22);
            menuMinimize.Text = "Minimize";
            menuMinimize.Click += menuMinimize_Click;
            // 
            // menuVault
            // 
            menuVault.DropDownItems.AddRange(new ToolStripItem[] { menuAddKey, menuDeleteKey, menuEditKey, menuExportVault, menuLockVault, menuSaveVault });
            menuVault.Enabled = false;
            menuVault.Name = "menuVault";
            menuVault.Size = new Size(45, 20);
            menuVault.Text = "Vault";
            menuVault.Visible = false;
            // 
            // menuAddKey
            // 
            menuAddKey.Image = (Image)resources.GetObject("menuAddKey.Image");
            menuAddKey.Name = "menuAddKey";
            menuAddKey.ShortcutKeys = Keys.Alt | Keys.A;
            menuAddKey.Size = new Size(174, 22);
            menuAddKey.Text = "Add Key";
            menuAddKey.Click += addKey_Click;
            // 
            // menuDeleteKey
            // 
            menuDeleteKey.Enabled = false;
            menuDeleteKey.Image = (Image)resources.GetObject("menuDeleteKey.Image");
            menuDeleteKey.Name = "menuDeleteKey";
            menuDeleteKey.ShortcutKeys = Keys.Alt | Keys.D;
            menuDeleteKey.Size = new Size(174, 22);
            menuDeleteKey.Text = "Delete Key";
            menuDeleteKey.Click += deleteKey_Click;
            // 
            // menuEditKey
            // 
            menuEditKey.Enabled = false;
            menuEditKey.Image = (Image)resources.GetObject("menuEditKey.Image");
            menuEditKey.Name = "menuEditKey";
            menuEditKey.ShortcutKeys = Keys.Alt | Keys.E;
            menuEditKey.Size = new Size(174, 22);
            menuEditKey.Text = "Edit Key";
            menuEditKey.Click += editKey_Click;
            // 
            // menuExportVault
            // 
            menuExportVault.DropDownItems.AddRange(new ToolStripItem[] { exportAsTxtToolStripMenuItem, exportAsjsonToolStripMenuItem, exportAsCsvToolStripMenuItem, exportAsxmlToolStripMenuItem });
            menuExportVault.Image = (Image)resources.GetObject("menuExportVault.Image");
            menuExportVault.Name = "menuExportVault";
            menuExportVault.ShortcutKeys = Keys.Alt | Keys.X;
            menuExportVault.Size = new Size(174, 22);
            menuExportVault.Text = "Export Vault";
            // 
            // exportAsTxtToolStripMenuItem
            // 
            exportAsTxtToolStripMenuItem.Name = "exportAsTxtToolStripMenuItem";
            exportAsTxtToolStripMenuItem.Size = new Size(150, 22);
            exportAsTxtToolStripMenuItem.Text = "Export as .txt";
            exportAsTxtToolStripMenuItem.Click += exportVault_Click;
            // 
            // exportAsjsonToolStripMenuItem
            // 
            exportAsjsonToolStripMenuItem.Name = "exportAsjsonToolStripMenuItem";
            exportAsjsonToolStripMenuItem.Size = new Size(150, 22);
            exportAsjsonToolStripMenuItem.Text = "Export as .json";
            exportAsjsonToolStripMenuItem.Click += exportVault_Click;
            // 
            // exportAsCsvToolStripMenuItem
            // 
            exportAsCsvToolStripMenuItem.Name = "exportAsCsvToolStripMenuItem";
            exportAsCsvToolStripMenuItem.Size = new Size(150, 22);
            exportAsCsvToolStripMenuItem.Text = "Export as .csv";
            exportAsCsvToolStripMenuItem.Click += exportVault_Click;
            // 
            // exportAsxmlToolStripMenuItem
            // 
            exportAsxmlToolStripMenuItem.Name = "exportAsxmlToolStripMenuItem";
            exportAsxmlToolStripMenuItem.Size = new Size(150, 22);
            exportAsxmlToolStripMenuItem.Text = "Export as .xml";
            exportAsxmlToolStripMenuItem.Click += exportVault_Click;
            // 
            // menuLockVault
            // 
            menuLockVault.Image = (Image)resources.GetObject("menuLockVault.Image");
            menuLockVault.Name = "menuLockVault";
            menuLockVault.ShortcutKeys = Keys.Alt | Keys.L;
            menuLockVault.Size = new Size(174, 22);
            menuLockVault.Text = "Lock Vault";
            menuLockVault.Click += menuLockVault_Click;
            // 
            // menuSaveVault
            // 
            menuSaveVault.Image = (Image)resources.GetObject("menuSaveVault.Image");
            menuSaveVault.Name = "menuSaveVault";
            menuSaveVault.ShortcutKeys = Keys.Control | Keys.S;
            menuSaveVault.Size = new Size(174, 22);
            menuSaveVault.Text = "Save Vault";
            menuSaveVault.Click += saveVault_Click;
            // 
            // menuHelp
            // 
            menuHelp.DropDownItems.AddRange(new ToolStripItem[] { reportABugToolStripMenuItem });
            menuHelp.Name = "menuHelp";
            menuHelp.Size = new Size(44, 20);
            menuHelp.Text = "Help";
            // 
            // reportABugToolStripMenuItem
            // 
            reportABugToolStripMenuItem.Image = (Image)resources.GetObject("reportABugToolStripMenuItem.Image");
            reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
            reportABugToolStripMenuItem.Size = new Size(142, 22);
            reportABugToolStripMenuItem.Text = "Report a Bug";
            reportABugToolStripMenuItem.Click += reportBug_Click;
            // 
            // statStrip
            // 
            statStrip.AutoSize = false;
            statStrip.BackColor = SystemColors.ControlDarkDark;
            statStrip.Items.AddRange(new ToolStripItem[] { statStripVersion, tsbReportBug });
            statStrip.Location = new Point(0, 400);
            statStrip.Name = "statStrip";
            statStrip.Size = new Size(611, 25);
            statStrip.SizingGrip = false;
            statStrip.TabIndex = 9;
            statStrip.Text = "statusStrip1";
            // 
            // statStripVersion
            // 
            statStripVersion.AutoSize = false;
            statStripVersion.BorderStyle = Border3DStyle.RaisedOuter;
            statStripVersion.ForeColor = SystemColors.ControlLightLight;
            statStripVersion.Name = "statStripVersion";
            statStripVersion.Size = new Size(533, 20);
            statStripVersion.Spring = true;
            statStripVersion.Text = "Forge Password Management Utility v.1.0.1";
            statStripVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tsbReportBug
            // 
            tsbReportBug.Alignment = ToolStripItemAlignment.Right;
            tsbReportBug.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbReportBug.DropDownItems.AddRange(new ToolStripItem[] { tsbReportBugSub });
            tsbReportBug.ForeColor = SystemColors.ControlLightLight;
            tsbReportBug.Image = (Image)resources.GetObject("tsbReportBug.Image");
            tsbReportBug.ImageTransparentColor = Color.Magenta;
            tsbReportBug.Name = "tsbReportBug";
            tsbReportBug.Size = new Size(32, 23);
            tsbReportBug.Text = "toolStripSplitButton1";
            tsbReportBug.ToolTipText = "Help";
            // 
            // tsbReportBugSub
            // 
            tsbReportBugSub.Image = (Image)resources.GetObject("tsbReportBugSub.Image");
            tsbReportBugSub.Name = "tsbReportBugSub";
            tsbReportBugSub.Size = new Size(142, 22);
            tsbReportBugSub.Text = "Report a Bug";
            tsbReportBugSub.Click += reportBug_Click;
            // 
            // toolVault
            // 
            toolVault.AutoSize = false;
            toolVault.BackColor = SystemColors.Control;
            toolVault.Enabled = false;
            toolVault.GripStyle = ToolStripGripStyle.Hidden;
            toolVault.Items.AddRange(new ToolStripItem[] { tsbLock, tsbSave, toolStripSeparator1, tsbAdd, tsbDelete, tsbEdit, toolStripSeparator2, tsbExport });
            toolVault.Location = new Point(0, 24);
            toolVault.Name = "toolVault";
            toolVault.Padding = new Padding(0);
            toolVault.RenderMode = ToolStripRenderMode.Professional;
            toolVault.Size = new Size(611, 25);
            toolVault.Stretch = true;
            toolVault.TabIndex = 10;
            toolVault.Text = "toolStrip1";
            toolVault.Visible = false;
            // 
            // tsbLock
            // 
            tsbLock.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbLock.Image = (Image)resources.GetObject("tsbLock.Image");
            tsbLock.ImageTransparentColor = Color.Magenta;
            tsbLock.Name = "tsbLock";
            tsbLock.Size = new Size(23, 22);
            tsbLock.Text = "Lock Vault";
            tsbLock.Click += lockVault_Click;
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSave.Image = (Image)resources.GetObject("tsbSave.Image");
            tsbSave.ImageTransparentColor = Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(23, 22);
            tsbSave.Text = "Save Vault";
            tsbSave.Click += saveVault_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tsbAdd
            // 
            tsbAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAdd.Image = (Image)resources.GetObject("tsbAdd.Image");
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(23, 22);
            tsbAdd.Text = "Add Key";
            tsbAdd.Click += addKey_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbDelete.Enabled = false;
            tsbDelete.Image = (Image)resources.GetObject("tsbDelete.Image");
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(23, 22);
            tsbDelete.Text = "toolStripButton1";
            tsbDelete.Click += deleteKey_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEdit.Enabled = false;
            tsbEdit.Image = (Image)resources.GetObject("tsbEdit.Image");
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(23, 22);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += editKey_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // tsbExport
            // 
            tsbExport.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbExport.Image = (Image)resources.GetObject("tsbExport.Image");
            tsbExport.ImageTransparentColor = Color.Magenta;
            tsbExport.Name = "tsbExport";
            tsbExport.Size = new Size(23, 22);
            tsbExport.Text = "Export Vault";
            tsbExport.Click += exportVault_Click;
            // 
            // GUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 425);
            Controls.Add(statStrip);
            Controls.Add(toolVault);
            Controls.Add(pnlLocked);
            Controls.Add(pnlNewVault);
            Controls.Add(pnlVault);
            Controls.Add(menuMain);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuMain;
            MaximizeBox = false;
            Name = "GUI";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forge Password Management Utility";
            FormClosing += GUI_Close;
            Resize += GUI_Resize;
            pnlVault.ResumeLayout(false);
            pnlAddEdit.ResumeLayout(false);
            pnlAddEdit.PerformLayout();
            pnlDgvKeyList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKeyList).EndInit();
            pnlNewVault.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlLocked.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            statStrip.ResumeLayout(false);
            statStrip.PerformLayout();
            toolVault.ResumeLayout(false);
            toolVault.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlVault;
        private Panel pnlDgvKeyList;
        private Panel pnlNewVault;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNewVaultID;
        private Button btnNewDirectory;
        private Label lblNewDirectory;
        private Button btnCreateVaultKey;
        private Button btnCancelNewVaultSetup;
        private Panel pnlLocked;
        private Panel panel3;
        private Label lblDirectory;
        private Button btnDirectory;
        private TextBox txtVaultID;
        private Label label6;
        private Label label7;
        private Button btnUnlockVault;
        private Button btnNewVault;
        private Panel pnlAddEdit;
        private TextBox txtPassword;
        private Label label9;
        private TextBox txtUsername;
        private Label label8;
        private TextBox txtService;
        private Label label5;
        private TextBox txtNotes;
        private Label label10;
        private Button btnExitAddEditPanel;
        private Button btnGenerateRandomPassword;
        private Button btnClearAddEditPanel;
        private Button btnSaveKey;
        private OpenFileDialog ofdVaultKey;
        private FolderBrowserDialog fbdNewVaultKey;
        private DataGridView dgvKeyList;
        private MenuStrip menuMain;
        private ToolStripMenuItem menuVault;
        private ToolStripMenuItem menuAddKey;
        private ToolStripMenuItem menuDeleteKey;
        private ToolStripMenuItem menuEditKey;
        private ToolStripMenuItem menuExportVault;
        private ToolStripMenuItem menuLockVault;
        private ToolStripMenuItem menuSaveVault;
        private ToolStripMenuItem menuHelp;
        private ToolStripMenuItem reportABugToolStripMenuItem;
        private ToolStripMenuItem menuView;
        private ToolStripMenuItem menuMinimize;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuNewVault;
        private PictureBox picLogo;
        private StatusStrip statStrip;
        private ToolStripStatusLabel statStripVersion;
        private ToolStripSplitButton tsbReportBug;
        private ToolStrip toolVault;
        private ToolStripButton tsbAdd;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbDelete;
        private ToolStripButton tsbEdit;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbExport;
        private ToolStripButton tsbLock;
        private ToolStripButton tsbSave;
        private ToolStripMenuItem tsbReportBugSub;
        private DataGridViewTextBoxColumn Service;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Notes;
        private ToolStripMenuItem exportAsTxtToolStripMenuItem;
        private ToolStripMenuItem exportAsCsvToolStripMenuItem;
        private ToolStripMenuItem exportAsjsonToolStripMenuItem;
        private ToolStripMenuItem exportAsxmlToolStripMenuItem;
    }
}
