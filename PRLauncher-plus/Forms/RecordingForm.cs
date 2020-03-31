using Ookii.Dialogs.WinForms;
using PRLauncher_plus.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRLauncher_plus.Forms {
    public partial class RecordingForm : Form {

        bool enabled = false;
        string demoFolderPath = "";

        public RecordingForm () {
            InitializeComponent();

            enabled = Settings.Default.recordPref;
            demoFolderPath = Settings.Default.demoFolderPathPref;

            enableCheckBox.Checked = enabled;
            dirTextBox.Text = demoFolderPath;
        }

        private void recordStatusChanged (object sender, EventArgs e) {
            enabled = enableCheckBox.Checked;
        }

        private void ChooseDirectoryButton (object sender, EventArgs e) {
            VistaFolderBrowserDialog folderBD = new VistaFolderBrowserDialog();

            if (folderBD.ShowDialog() == DialogResult.OK) {
                demoFolderPath = folderBD.SelectedPath;
                dirTextBox.Text = demoFolderPath;
            }
        }

        #region Bottom action Buttons region

        private void Discard (object sender, EventArgs e) {
            Close();
        }

        private void Save (object sender, EventArgs e) {
            if (Directory.Exists(dirTextBox.Text))
                Settings.Default.demoFolderPathPref = dirTextBox.Text;

            Settings.Default.recordPref = enabled;
            Settings.Default.Save();
            Close();
        }

        private void ResetPrompte (object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure you want to reset?", "Are you sure?",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

            if (result == DialogResult.Yes) {
                enabled = false;
                enableCheckBox.Checked = enabled;
                Settings.Default.recordPref = enabled;
                demoFolderPath = "";
                dirTextBox.Text = demoFolderPath;
                Settings.Default.demoFolderPathPref = demoFolderPath;
                Settings.Default.Save();
            }
        }

        #endregion

    }
}
