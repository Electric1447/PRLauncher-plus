using PRLauncher_plus.Forms;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace PRLauncher_plus {
    static class Program {

        public static string Version {
            get {
                Assembly asm = Assembly.GetExecutingAssembly();
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(asm.Location);

                string verstr = string.Format("{0}.{1}.{2}", fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart);

                if (fvi.FilePrivatePart != 0)
                    verstr += ("." + fvi.FilePrivatePart);

                return verstr + "-beta3";
            }
        }

        [STAThread]
        static void Main () {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

    }
}
