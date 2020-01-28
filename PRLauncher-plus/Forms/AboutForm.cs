using System;
using System.Windows.Forms;

namespace PRLauncher_plus.Forms {
    public partial class AboutForm : Form {

        public AboutForm () {
            InitializeComponent();
            aboutLabel5.Text = Program.VERSION;
        }

        private void Close (object sender, EventArgs e) {
            Close();
        }

        private void Goto_Github (object sender, EventArgs e) {
            System.Diagnostics.Process.Start("http://github.com/Electric1447/prlauncher-plus");
        }
    }
}
