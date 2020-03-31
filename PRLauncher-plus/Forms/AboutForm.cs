using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PRLauncher_plus.Forms {
    public partial class AboutForm : Form {

        public AboutForm () {
            InitializeComponent();
            vLabel.Text = "PRLauncher+ Version " + Program.Version;
        }

        private void Close (object sender, EventArgs e) {
            Close();
        }

        private void Goto_Github (object sender, EventArgs e) {
            Process.Start("http://github.com/Electric1447/prlauncher-plus");
        }

    }
}
