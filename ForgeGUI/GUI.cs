using System.Windows.Forms;
using ForgeLib;
using ForgeLib.File;
using ForgeLib.Messages;
using ForgeLib.Objects;
using ForgeLib.Services;

namespace ForgeGUI
{
    /// <summary>
    /// Main GUI Form
    /// </summary>
    public partial class GUI : Form
    {
        public GUI()
        {
            App.Initialize();
            InitializeComponent();
        }

        /// <summary>
        /// Indicates if the add/edit panel is opened in edit mode.
        /// </summary>
        private bool editMode = false;

        /// <summary>
        /// Event fired when the GUI window is resized.
        /// </summary>
        /// <param name="sender">The object that fired the event</param>
        /// <param name="e">Event arguments</param>
        /// <returns>void</returns>
        private void GUI_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized && App.activeVault != null)
            {
                NotifyIcon notifyIcon = new();
                notifyIcon.Visible = true;
                notifyIcon.Icon = Icon;
                notifyIcon.ShowBalloonTip(100, Warning.WARNING, Warning.UNLOCKED_VAULT, ToolTipIcon.Warning);
            }
        }

        private void GUI_Close(object sender, FormClosingEventArgs e)
        {
            App.Close();
        }


        //  ************************** LockedPanel *************************  //

        private void TryCreateVault()
        {
            if (!ForgeLib.Services.Validate.NewVaultID(txtNewVaultID.Text))
            {
                MessageBox.Show(Error.INVALID_NEW_ID, Error.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (ForgeLib.Services.Validate.IsEmpty(lblNewDirectory.Text))
            {
                MessageBox.Show(Error.EMPTY_DIR, Error.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string path = ForgeLib.File.Directory.GetVaultPath(txtNewVaultID.Text);
            if (ForgeLib.Services.Validate.FileExists(path))
            {
                MessageBox.Show(Error.ID_EXISTS_1 + txtNewVaultID + Error.ID_EXISTS_2, Error.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            App.CreateVault(txtNewVaultID.Text, lblNewDirectory.Text);
            MessageBox.Show(Success.VAULT_CREATED, Success.SUCCESS, MessageBoxButtons.OK, MessageBoxIcon.None);
            ExitNewVaultSetup();
        }

        private void TryOpenVault()
        {
            if (ForgeLib.Services.Validate.IsEmpty(txtVaultID.Text))
            {
                MessageBox.Show(Error.EMPTY_ID, Error.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string vaultPath = ForgeLib.File.Directory.GetVaultPath(txtVaultID.Text);

            try
            {
                string hash = Process.Decode(Process.Read(ForgeLib.File.Directory.GetHashPath(txtVaultID.Text)));
            }
            catch
            {
                MessageBox.Show(Error.INVALID_VAULT_KEY, Error.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ForgeLib.Services.Validate.VaultKey(txtVaultID.Text, lblDirectory.Text))
            {
                MessageBox.Show(Error.INVALID_VAULT_KEY, Error.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ForgeLib.Services.Validate.IsEmpty(lblDirectory.Text))
            {
                MessageBox.Show(Error.EMPTY_KEY_PATH, Error.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashPath = ForgeLib.File.Directory.GetHashPath(txtVaultID.Text);
            if (!Cryptography.VerifyHash(lblDirectory.Text, hashPath))
            {
                MessageBox.Show(Error.VERIFY_FAILED, Error.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            App.OpenVault(vaultPath, txtVaultID.Text);
            RefreshKeyList(App.activeVault);

            toolVault.Visible = true;
            toolVault.Enabled = true;
            menuVault.Visible = true;
            menuVault.Enabled = true;
            menuNewVault.Enabled = false;
            pnlLocked.Visible = false;
            pnlVault.Visible = true;
            txtVaultID.Text = String.Empty;
            lblDirectory.Text = String.Empty;

        }

        private void btnNewVault_Click(object sender, EventArgs e)
        {
            txtVaultID.Text = string.Empty;
            lblDirectory.Text = string.Empty;
            pnlLocked.Visible = false;
            pnlNewVault.Visible = true;
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            ofdVaultKey.ShowDialog();
            lblDirectory.Text = ofdVaultKey.FileName;
        }

        private void btnUnlockVault_Click(object sender, EventArgs e)
        {
            TryOpenVault();
        }


        //  ************************** VaultPanel *************************  //

        private void DeleteSelectedKey()
        {
            try
            {
                foreach (Key key in App.activeVault.keys)
                {
                    if (key.service == GetSelectedRow().Cells[0].Value.ToString() &
                        key.username == GetSelectedRow().Cells[1].Value.ToString() &
                        key.password == GetSelectedRow().Cells[2].Value.ToString() &
                        key.notes == GetSelectedRow().Cells[3].Value.ToString())
                    {
                        App.activeVault.DeleteKey(key);
                        RefreshKeyList(App.activeVault);
                        App.SaveVault(App.activeVault);
                        return;
                    }
                }
            }
            catch
            { 
                MessageBox.Show(Error.DELETE_KEY, Error.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowAddEditPanel()
        {
            pnlDgvKeyList.Visible = false;
            pnlAddEdit.Visible = true;
            tsbAdd.Enabled = false;
            tsbEdit.Enabled = false;
            tsbDelete.Enabled = false;
            menuAddKey.Enabled = false;
            menuDeleteKey.Enabled = false;
            menuEditKey.Enabled = false;
            menuExportVault.Enabled = false;
            menuSaveVault.Enabled = false;
            AcceptButton = btnSaveKey;
        }


        //  ************************** NewVaultPanel *************************  //

        private void ExitNewVaultSetup()
        {
            txtNewVaultID.Text = string.Empty;
            lblNewDirectory.Text = string.Empty;
            pnlNewVault.Visible = false;
            pnlLocked.Visible = true;
            menuNewVault.Enabled = true;
        }

        private void btnNewDirectory_Click(object sender, EventArgs e)
        {
            fbdNewVaultKey.ShowDialog();
            string keyPath = fbdNewVaultKey.SelectedPath;
            lblNewDirectory.Text = keyPath;
        }

        private void btnCancelNewVaultSetup_Click(object sender, EventArgs e)
        {
            ExitNewVaultSetup();
        }

        private void btnCreateVaultKey_Click(object sender, EventArgs e)
        {
            TryCreateVault();
        }


        //  ************************** AddEditPanel *************************  //

        private void ClearAddEditForm()
        {
            txtService.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtNotes.Text = string.Empty;
        }

        private void ExitAddEditPanel()
        {
            ClearAddEditForm();
            pnlAddEdit.Visible = false;
            pnlDgvKeyList.Visible = true;
            tsbAdd.Enabled = true;
            menuAddKey.Enabled = true;
            menuExportVault.Enabled = true;
            menuSaveVault.Enabled = true;

            if (GetIsCellSelected())
            {
                tsbEdit.Enabled = true;
                tsbDelete.Enabled = true;
                menuDeleteKey.Enabled = true;
                menuEditKey.Enabled = true;
            }
        }

        private void GenerateRandomPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = Rng.GenerateRandomSafeString(10);
        }

        private void btnExitAddEditPanel_Click(object sender, EventArgs e)
        {
            editMode = false;
            ExitAddEditPanel();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearAddEditForm();
        }

        private void SaveKey_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                DeleteSelectedKey();
            }

            Key key = App.CreateKey(txtService.Text, txtUsername.Text, txtPassword.Text, txtNotes.Text);
            App.activeVault.AddKey(key);
            App.SaveVault(App.activeVault);

            RefreshKeyList(App.activeVault);

            editMode = false;
            ExitAddEditPanel();
        }


        //  ************************** MenuStrip *************************  //

        private void menuMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            if (App.activeVault != null)
            {
                NotifyIcon notifyIcon = new();
                notifyIcon.Visible = true;
                notifyIcon.Icon = Icon;
                notifyIcon.ShowBalloonTip(100, Warning.WARNING, Warning.UNLOCKED_VAULT, ToolTipIcon.Warning);
            }
        }

        private void menuNewVault_Click(object sender, EventArgs e)
        {
            txtVaultID.Text = string.Empty;
            lblDirectory.Text = string.Empty;
            pnlLocked.Visible = false;
            pnlNewVault.Visible = true;
            menuNewVault.Enabled = false;
        }

        private void menuLockVault_Click(object sender, EventArgs e)
        {
            if (pnlAddEdit.Visible)
            {
                ExitAddEditPanel();
            }

            App.LockVault(App.activeVault);
            ClearKeyList();

            toolVault.Enabled = false;
            toolVault.Visible = false;

            pnlVault.Visible = false;
            pnlLocked.Visible = true;
            menuNewVault.Enabled = true;
            menuVault.Enabled = false;
            menuDeleteKey.Enabled = false;
            menuEditKey.Enabled = false;
            menuVault.Visible = false;
            AcceptButton = btnUnlockVault;
            CancelButton = null;
        }


        //  ************************** MenuButtons *************************  //

        private void addKey_Click(object sender, EventArgs e)
        {
            ShowAddEditPanel();
        }

        private void deleteKey_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show(Warning.CONFIRM_DELETE, Warning.WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                DeleteSelectedKey();
            }
        }

        private void editKey_Click(object sender, EventArgs e)
        {
            editMode = true;
            ShowAddEditPanel();
            txtService.Text = GetSelectedRow().Cells[0].Value.ToString();
            txtUsername.Text = GetSelectedRow().Cells[1].Value.ToString();
            txtPassword.Text = GetSelectedRow().Cells[2].Value.ToString();
            txtNotes.Text = GetSelectedRow().Cells[3].Value.ToString();
        }

        private void saveVault_Click(object sender, EventArgs e)
        {
            if (App.activeVault == null)
            {
                MessageBox.Show(Error.NO_VAULT, Error.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                App.SaveVault(App.activeVault);
                MessageBox.Show(Success.VAULT_SAVED, Success.SUCCESS, MessageBoxButtons.OK);
            }
        }

        private void reportBug_Click(object sender, EventArgs e)
        {
            try
            {
                App.ReportBug();
            }
            catch
            {
                MessageBox.Show(Error.REPORT_BUG, Error.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportVault_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender == exportAsTxtToolStripMenuItem)
                {
                    Export.ExportVault(App.activeVault, Export.ExportFormat.txt);
                }
                else if (sender == exportAsCsvToolStripMenuItem)
                {
                    Export.ExportVault(App.activeVault, Export.ExportFormat.csv);
                }
                else if (sender == exportAsjsonToolStripMenuItem)
                {
                    Export.ExportVault(App.activeVault, Export.ExportFormat.json);
                }
                else if (sender == exportAsxmlToolStripMenuItem)
                {
                    Export.ExportVault(App.activeVault, Export.ExportFormat.xml);
                }
                else if (sender == tsbExport)
                {
                    Export.ExportVault(App.activeVault, Export.ExportFormat.txt);
                }

                ShowExportWarning();
            }
            catch
            {
                MessageBox.Show(Error.EXPORT_FAILED, Error.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lockVault_Click(object sender, EventArgs e)
        {
            if (pnlAddEdit.Visible)
            {
                ExitAddEditPanel();
            }

            App.LockVault(App.activeVault);
            ClearKeyList();

            toolVault.Visible = false;
            toolVault.Enabled = false;

            pnlVault.Visible = false;
            pnlLocked.Visible = true;
            menuNewVault.Enabled = true;
            menuVault.Enabled = false;
            menuDeleteKey.Enabled = false;
            menuEditKey.Enabled = false;
            menuVault.Visible = false;
            AcceptButton = btnUnlockVault;
            CancelButton = null;
        }

        private void ShowExportWarning()
        {
            MessageBox.Show(Warning.EXPORT,
                Success.EXPORT_COMPLETE,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }


        //  ************************** DgvKeyList *************************  //

        private void RefreshKeyList(Vault activeVault)
        {
            ClearKeyList();

            for (int intIndex = 0; intIndex < activeVault.keys.Count; intIndex++)
            {
                try
                {
                    dgvKeyList.Rows.Add(activeVault.keys[intIndex].ConvertToObject());
                }
                catch (Exception)
                {
                    MessageBox.Show(Error.INVALID_REFRESH, Error.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearKeyList()
        {
            try
            {
                dgvKeyList.Rows.Clear();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show(Error.INVALID_CLEAR, Error.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool GetIsCellSelected()
        {
            return dgvKeyList.SelectedCells.Count > 0;
        }

        private DataGridViewRow GetSelectedRow()
        {
            return dgvKeyList.SelectedCells[0].OwningRow;
        }

        private void dgvKeyList_SelectionChanged(object sender, EventArgs e)
        {
            if (!GetIsCellSelected())
            {
                // If a cell is NOT selected, disable the edit and delete buttons
                tsbEdit.Enabled = false;
                tsbDelete.Enabled = false;
                menuEditKey.Enabled = false;
                menuDeleteKey.Enabled = false;
            }
            else
            {
                // If a cell is selected, enable the edit and delete buttons
                tsbEdit.Enabled = true;
                tsbDelete.Enabled = true;
                menuEditKey.Enabled = true;
                menuDeleteKey.Enabled = true;
                GetSelectedRow().Selected = true;
            }
        }

    }
}
