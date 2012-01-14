using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AcousticsNowPlaying {
    public partial class SettingsWindow : Form {
        public SettingsWindow() {
            InitializeComponent();
        }

        private void reloadData() {
            txtServerBase.Text = Properties.Settings.Default.serverBaseAddress;
            txtUserName.Text = Properties.Settings.Default.userName;
            txtRoom.Text = Properties.Settings.Default.roomName;
            chkAskForPass.Checked = Properties.Settings.Default.promptForPassword;
            chkShowExtra.Checked = Properties.Settings.Default.showExtraInfo;
        }

        private void SettingsWindow_Load(object sender, EventArgs e) {
            reloadData();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            reloadData();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Properties.Settings.Default.serverBaseAddress = txtServerBase.Text;
            Properties.Settings.Default.userName = txtUserName.Text;
            Properties.Settings.Default.roomName = txtRoom.Text;
            Properties.Settings.Default.promptForPassword = chkAskForPass.Checked;
            Properties.Settings.Default.showExtraInfo = chkShowExtra.Checked;
            Properties.Settings.Default.Save();

            ((MainForm)this.Owner).Reinit();
            this.Hide();
        }

    }
}
