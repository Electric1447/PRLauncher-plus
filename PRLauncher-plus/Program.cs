using PRLauncher_plus.Forms;
using System;
using System.Windows.Forms;

namespace PRLauncher_plus {
    static class Program {

        public static readonly string VERSION = "0.6.2.1";

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
