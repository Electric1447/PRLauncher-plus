using PRLauncher_plus.Objects;
using PRLauncher_plus.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PRLauncher_plus {
    public partial class MainForm : Form {

        WadList iwads = new WadList();

        string folderPath = "";

        static string[] prboomExec = new string[] { "prboom-plus.exe", "glboom-plus.exe" };
        static string[] prboomExecNames = new string[] { "PRBoom+ (" + prboomExec[0] + ")", "GLBoom+ (" + prboomExec[1] + ")" };

        static string[] complevels = new string[] { "-1 - Current Prboom-plus", "0 - Doom v1.2", "1 - Doom v1.666", "2 - Doom v1.9", "3 - Ultimate Doom",
            "4 - Final Doom's doom2.exe", "5 - DOSDoom", "6 - TASDDOOM", "7 - Boom's compatibility mode", "8 - Boom v2.01", "9 - Boom v2.02", "10 - LxDoom v1.4.x",
            "11 - MBF", "12 - PrBoom v2.03beta", "13 - PrBoom v2.1.0", "14 - PrBoom v2.1.1-2.2.6", "15 - PrBoom v2.3.x", "16 - PrBoom v2.4.0", "17 - Latest PrBoom-plus" };

        static string[] difficulties = new string[] { "None (select ingame)", "I'm too young to die", "Hey, not too rough", "Hurt me plenty", "Ultra-Violence", "Nightmare!" };

        int cExecutable = 0, cIWad = 0, cComplevel = 0, cDifficulty = 0;

        public MainForm() {
            InitializeComponent();

            cExecutable = Settings.Default.cExecutablePref;
            cIWad = Settings.Default.cIWadPref;
            cComplevel = Settings.Default.cComplevelPref;
            cDifficulty = Settings.Default.cDifficultyPref;
            folderPath = Settings.Default.folderPathPref;

            dirTextBox.Text = folderPath;
            levelTextBox.Text = Settings.Default.warpPref;

            compComboBox.Items.AddRange(complevels);
            compComboBox.SelectedIndex = cComplevel;
            diffComboBox.Items.AddRange(difficulties);
            diffComboBox.SelectedIndex = cDifficulty;

            if (folderPath != "")
                iwads.DetectWads(folderPath);

            RefreshLevelList();

            execCheckBox.Checked = cExecutable == 1;

        }

        private void Run (object sender, EventArgs e) {

            string diff_temp = "", warp_temp = levelTextBox.Text;

            if (cDifficulty != 0)
                diff_temp = " -skill " + cDifficulty;

            if (warp_temp != "")
                warp_temp = " -warp " + warp_temp;

            if (!folderPath.Equals("")) {
                try {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = folderPath + @"\" + prboomExec[cExecutable];
                    startInfo.Arguments = " -iwad " + iwads.GetWadsFilename()[cIWad] + " -complevel " + (cComplevel - 1) + warp_temp + " " + diff_temp + " " + argTextBox.Text;
                    Process.Start(startInfo);
                } catch { Console.WriteLine("ERROR: can't open executable"); }
            }

            Settings.Default.warpPref = levelTextBox.Text;
            Settings.Default.Save();
        }

        private void ChooseDirectoryButton (object sender, EventArgs e) {

            FolderBrowserDialog folderBD = new FolderBrowserDialog();

            if (folderBD.ShowDialog() == DialogResult.OK) {
                folderPath = folderBD.SelectedPath;
                Settings.Default.folderPathPref = folderPath;
                dirTextBox.Text = folderPath;
            }

            Settings.Default.Save();
        }

        private void RefreshDirectory (object sender, EventArgs e) {

            folderPath = dirTextBox.Text;
            Settings.Default.folderPathPref = folderPath;
            Settings.Default.Save();

            if (Directory.Exists(dirTextBox.Text) && (File.Exists(dirTextBox.Text + @"\" + prboomExec[0]) || File.Exists(dirTextBox.Text + @"\" + prboomExec[1]))) {

                iwads.DetectWads(folderPath);
                iwadComboBox.Items.Clear();
                iwadComboBox.Items.AddRange(iwads.GetWadsFullTitle());

                if (iwads.GetWadsFilename().Length <= cIWad) {
                    cIWad = 0;
                    Settings.Default.cIWadPref = cIWad;
                }

                iwadComboBox.SelectedIndex = cIWad;
                
            } else {
                iwadComboBox.Items.Clear();
            }

        }

        private void ExecutableChanged (object sender, EventArgs e) {

            if (execCheckBox.Checked)
                cExecutable = 1;
            else
                cExecutable = 0;

            Settings.Default.cExecutablePref = cExecutable;
            Settings.Default.Save();

        }

        private void iwadCB_IndexChanged (object sender, EventArgs e) {
            cIWad = iwadComboBox.SelectedIndex;
            RefreshLevelList();
            Settings.Default.cIWadPref = cIWad;
            Settings.Default.Save();
        } 

        private void compCB_IndexChanged (object sender, EventArgs e) {
            cComplevel = compComboBox.SelectedIndex;
            Settings.Default.cComplevelPref = cComplevel;
            Settings.Default.Save();
        }

        private void diffCB_IndexChanged (object sender, EventArgs e) {
            cDifficulty = diffComboBox.SelectedIndex;
            Settings.Default.cDifficultyPref = cDifficulty;
            Settings.Default.Save();
        }

        private void RefreshLevelList () {
            levelComboBox.Items.Clear();
            levelComboBox.Items.Add("CUSTOM");
            if (iwads.IsKnown(cIWad) && folderPath != "")
                levelComboBox.Items.AddRange(Levels.GetLevelList(iwads.GetWadsFilename()[cIWad]));
        }
    }
}
