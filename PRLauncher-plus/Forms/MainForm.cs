using PRLauncher_plus.Objects;
using PRLauncher_plus.Properties;
using PRLauncher_plus.Util;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PRLauncher_plus.Forms {
    public partial class MainForm : Form {

        #region Constants
        /// <summary>
        /// Constant variable.
        /// </summary>
        static string[] prboomExec = new string[] { "prboom-plus.exe", "glboom-plus.exe" };
        static string[] prboomExecNames = new string[] { "PRBoom+ (" + prboomExec[0] + ")", "GLBoom+ (" + prboomExec[1] + ")" };

        static string[] complevels = new string[] { "-1 - Current Prboom-plus", "0 - Doom v1.2", "1 - Doom v1.666", "2 - Doom v1.9", "3 - Ultimate Doom",
            "4 - Final Doom's doom2.exe", "5 - DOSDoom", "6 - TASDDOOM", "7 - Boom's compatibility mode", "8 - Boom v2.01", "9 - Boom v2.02", "10 - LxDoom v1.4.x",
            "11 - MBF", "12 - PrBoom v2.03beta", "13 - PrBoom v2.1.0", "14 - PrBoom v2.1.1-2.2.6", "15 - PrBoom v2.3.x", "16 - PrBoom v2.4.0", "17 - Latest PrBoom-plus" };
        #endregion

        WadList iwads = new WadList();

        string folderPath = "", cWarp = "";
        int cExecutable = 0, cIWad = 0, cComplevel = 0, cDifficulty = 0, cWarpIndex = 0;

        public MainForm () {
            InitializeComponent();
            Text = "PRLauncher+ " + Program.Version;

            folderPath = Settings.Default.folderPathPref;
            cWarp = Settings.Default.warpPref;
            cExecutable = Settings.Default.cExecutablePref;
            cIWad = Settings.Default.cIWadPref;
            cComplevel = Settings.Default.cComplevelPref;
            cDifficulty = Settings.Default.cDifficultyPref;
            cWarpIndex = Settings.Default.cWarpIndexPref;

            dirTextBox.Text = folderPath;
            argTextBox.Text = Settings.Default.argPref;

            // Checks if PRLauncher-plus.exe is in the PRBoom+'s directory.
            // And if so, it changes the folder path to be PRLauncher-plus.exe's directory.
            if (folderPath.Equals("") && File.Exists(Application.StartupPath + @"\prboom-plus.exe")) {
                folderPath = Application.StartupPath;
                Settings.Default.folderPathPref = folderPath;
                dirTextBox.Text = folderPath;
                Settings.Default.Save();
            }

            compComboBox.Items.AddRange(complevels);
            compComboBox.SelectedIndex = cComplevel;

            execCheckBox.Checked = cExecutable == 1;

            iwads.DetectWads(folderPath);
            RefreshLevelList();
            RefreshDiffList();
        }

        private void RunButton (object sender, EventArgs e) {

            Check_cWarp();

            string diff_temp = (cDifficulty != 0) ? ("-skill " + cDifficulty) : "";
            string warp_temp = !cWarp.Equals("") ? ("-warp " + cWarp) : cWarp;
            string dfnh = "";

            if (recordDemoToolStripMenuItem.Checked && !argTextBox.Text.Contains("-record")) {
                int demo_count = 0;
                dfnh = (!cWarp.Equals("") ? ("d_" + Levels.ReverseParseLevel(iwads.GetWadsFilename()[cIWad], cWarp).ToLower() + "_") : "demo_");

                while (File.Exists(folderPath + @"\" + dfnh + demo_count.ToString().PadLeft(2, '0') + ".lmp")) {
                    demo_count++;
                }

                dfnh += demo_count.ToString().PadLeft(2, '0');
                dfnh = "-record " + dfnh;
            }

            string launchArguments = string.Format(" -iwad {0} -complevel {1} {2} {3} {4} {5}",
                iwads.GetWadsFilename()[cIWad], (cComplevel - 1), warp_temp, diff_temp, argTextBox.Text, dfnh);

            switch (Run(folderPath, prboomExec[cExecutable], launchArguments)) {
                case 1:
                    MessageBox.Show("Please insert the path to your PRBoom+ folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("Can't find " + prboomExec[cExecutable], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    Console.WriteLine("Error launching PRBoom+/GLBoom+");
                    break;
            }

            SaveSettings();
        }

        private int Run (string execFolderPath, string execFilePath, string args) {

            try {
                if (execFolderPath.Equals("")) {
                    return 1; // The Folder Path is Empty
                } else if (!File.Exists(execFolderPath + @"\" + execFilePath)) {
                    return 2; // The Executable does not exist/isn't found
                } else {
                    // Run the exectuable
                    ProcessStartInfo startInfo = new ProcessStartInfo {
                        FileName = execFolderPath + @"\" + execFilePath,
                        Arguments = args
                    };
                    Process.Start(startInfo);
                }
            } catch { return 3; }

            return 0;
        }

        private void ChooseDirectoryButton (object sender, EventArgs e) {

            FolderBrowserDialog folderBD = new FolderBrowserDialog();

            if (folderBD.ShowDialog() == DialogResult.OK) {
                folderPath = folderBD.SelectedPath;
                Settings.Default.folderPathPref = folderPath;
                dirTextBox.Text = folderPath;
                Settings.Default.Save();
            }
            
        }

        #region Refresh misc functions
        /// <summary>
        /// Functions that refresh. (TODO: better explaination)
        /// </summary>

        private void ExecutableChanged (object sender, EventArgs e) {
            cExecutable = Convert.ToInt32(execCheckBox.Checked);
            Settings.Default.cExecutablePref = cExecutable;
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

            RefreshLevelList();
        }

        private void RefreshLevelList () {

            levelComboBox.Items.Clear();
            levelComboBox.Items.Add("CUSTOM");

            if (iwads.IsKnown(cIWad) && !folderPath.Equals(""))
                levelComboBox.Items.AddRange(Levels.GetLevelList(iwads.GetWadsFilename()[cIWad]));

            if (cWarpIndex >= levelComboBox.Items.Count)
                cWarpIndex = 0;

            levelComboBox.SelectedIndex = cWarpIndex;
        }

        private void RefreshDiffList () {

            diffComboBox.Items.Clear();
            diffComboBox.Items.Add("None (select ingame)");

            diffComboBox.Items.AddRange(Difficulty.GetDifflvlList((iwads.IsKnown(cIWad) && !folderPath.Equals(""))
                ? iwads.GetWadsFilename()[cIWad] : "doom.wad"));

            diffComboBox.SelectedIndex = cDifficulty;
        }

        #endregion

        #region Comboboxes index changed functions
        /// <summary>
        /// The code for all Comboboxes when they detect that their index was changed.
        /// </summary>

        /// IWad Combobox
        private void iwadCB_IndexChanged (object sender, EventArgs e) {
            cIWad = iwadComboBox.SelectedIndex;

            // Retrieving saved custom warp prefs needs to be run BEFORE RefreshLevelList().
            // Otherwise it wouldn't retrive the saved custom warp prefs.
            if (cWarpIndex == 0)
                levelTextBox.Text = cWarp;

            RefreshLevelList();
            RefreshDiffList();
            Settings.Default.cIWadPref = cIWad;
            Settings.Default.Save();
        }

        /// Complevel Combobox
        private void compCB_IndexChanged (object sender, EventArgs e) {
            cComplevel = compComboBox.SelectedIndex;
            Settings.Default.cComplevelPref = cComplevel;
            Settings.Default.Save();
        }

        /// Difficulty Combobox
        private void diffCB_IndexChanged (object sender, EventArgs e) {
            cDifficulty = diffComboBox.SelectedIndex;
            Settings.Default.cDifficultyPref = cDifficulty;
            Settings.Default.Save();
        }

        /// Level Combobox
        private void levelCB_IndexChanged (object sender, EventArgs e) {
            levelTextBox.Enabled = (levelComboBox.SelectedIndex == 0);
            cWarpIndex = levelComboBox.SelectedIndex;
            Check_cWarp();
            Settings.Default.cWarpIndexPref = cWarpIndex;
            Settings.Default.warpPref = cWarp;
            Settings.Default.Save();
        }

        #endregion

        #region Save/Load/Reset Configaration
        /// <summary>
        /// Save, Load & Reset Configaration functions.
        /// </summary>

        /// Save current config to Settings. (ToolStripMenuItem)
        private void SaveCurrentConfig (object sender, EventArgs e) {
            SaveSettings();
        }

        /// Save current config to Settings.
        private void SaveSettings () {
            Check_cWarp();
            Settings.Default.warpPref = cWarp;
            Settings.Default.argPref = argTextBox.Text;
            Settings.Default.Save();
            Console.WriteLine("Settings have been saved!");
        }

        /// Reset current config. (ToolStripMenuItem)
        private void ResetConfigPrompte (object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure you want to reset the current configaration?", "Are you sure?",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

            if (result == DialogResult.Yes) {
                Settings.Default.Reset();
                Application.Restart();
            }
        }

        /// Save current config to an INI file. (ToolStripMenuItem)
        private void SaveToINI (object sender, EventArgs e) {
            const string INIHeader = "Config";

            SaveFileDialog inif_sfd = new SaveFileDialog {
                InitialDirectory = folderPath,
                Title = "Save Configaration to an INI file.",
                Filter = "Configaration Files|*.ini",
                CheckPathExists = true,
                DefaultExt = "ini"
            };

            if (inif_sfd.ShowDialog() == DialogResult.OK) {
                INIFile inif = new INIFile(inif_sfd.FileName);
                inif.Write(INIHeader, "f_folderPath", folderPath);
                Check_cWarp();
                inif.Write(INIHeader, "f_warp", cWarp);
                inif.Write(INIHeader, "f_exec", cExecutable.ToString());
                inif.Write(INIHeader, "f_iwad", cIWad.ToString());
                inif.Write(INIHeader, "f_complevel", cComplevel.ToString());
                inif.Write(INIHeader, "f_difficulty", cDifficulty.ToString());
                inif.Write(INIHeader, "f_warpIndex", cWarpIndex.ToString());
                inif.Write(INIHeader, "f_args", argTextBox.Text);
            }
        }

        /// Load config from an INI file. (ToolStripMenuItem)
        private void LoadFromINI (object sender, EventArgs e) {
            const string INIHeader = "Config";

            OpenFileDialog inif_ofd = new OpenFileDialog {
                InitialDirectory = folderPath,
                Title = "Save Configaration to an INI file.",
                Filter = "INI Configaration Files (*.ini)|*.ini|All files (*.*)|*.*",
                CheckPathExists = true,
                CheckFileExists = true,
                DefaultExt = "ini"
            };

            if (inif_ofd.ShowDialog() == DialogResult.OK) {
                INIFile inif = new INIFile(inif_ofd.FileName);
                Settings.Default.folderPathPref = inif.Read(INIHeader, "f_folderPath");
                Settings.Default.warpPref = inif.Read(INIHeader, "f_warp");
                Settings.Default.cExecutablePref = string.IsNullOrEmpty(inif.Read(INIHeader, "f_exec")) ? 0 : int.Parse(inif.Read(INIHeader, "f_exec"));
                Settings.Default.cIWadPref = string.IsNullOrEmpty(inif.Read(INIHeader, "f_iwad")) ? 0 : int.Parse(inif.Read(INIHeader, "f_iwad"));
                Settings.Default.cComplevelPref = string.IsNullOrEmpty(inif.Read(INIHeader, "f_complevel")) ? 0 : int.Parse(inif.Read(INIHeader, "f_complevel"));
                Settings.Default.cDifficultyPref = string.IsNullOrEmpty(inif.Read(INIHeader, "f_difficulty")) ? 0 : int.Parse(inif.Read(INIHeader, "f_difficulty"));
                Settings.Default.cWarpIndexPref = string.IsNullOrEmpty(inif.Read(INIHeader, "f_warpIndex")) ? 0 : int.Parse(inif.Read(INIHeader, "f_warpIndex"));
                Settings.Default.argPref = inif.Read(INIHeader, "f_args");
                Settings.Default.Save();
                Application.Restart();
            }
        }

        #endregion

        #region Demo functions

        private void PlayDemo (object sender, EventArgs e) {

            OpenFileDialog lmp_ofd = new OpenFileDialog {
                InitialDirectory = folderPath,
                Title = "demo",
                Filter = "Doom Demo Files (*.lmp)|*.lmp|All files (*.*)|*.*",
                CheckPathExists = true,
                CheckFileExists = true,
                DefaultExt = "lmp"
            };

            if (lmp_ofd.ShowDialog() == DialogResult.OK) {
                string args = " -playdemo " + lmp_ofd.FileName;
                switch (Run(folderPath, prboomExec[cExecutable], args)) {
                    case 1:
                        MessageBox.Show("Please insert the path to your PRBoom+ folder first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 2:
                        MessageBox.Show("Can't find " + prboomExec[cExecutable], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 3:
                        Console.WriteLine("Error launching PRBoom+/GLBoom+/Demo");
                        break;
                }
            }
        }

        #endregion

        #region Goto functions
        /// <summary>
        /// The functions that open a new form/link.
        /// </summary>

        private void Goto_About (object sender, EventArgs e) {
            AboutForm af = new AboutForm();
            af.Show();
        }

        private void Goto_CompHint (object sender, EventArgs e) {
            CompHintForm chf = new CompHintForm();
            chf.Show();
        }

        #endregion

        #region Exit functions
        /// <summary>
        /// Exit functions.
        /// </summary>
        
        private void Exit (object sender, FormClosingEventArgs e) {
            SaveSettings();
        }

        private void ExitTSMI (object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure you want to close PRLauncher+ ?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        #endregion

        private void Check_cWarp () {
            cWarp = ((cWarpIndex == 0) ? levelTextBox.Text : Levels.ParseLevel(iwads.GetWadsFilename()[cIWad], cWarpIndex - 1));
        }

    }
}
