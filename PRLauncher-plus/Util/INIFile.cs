using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PRLauncher_plus.Util {
    class INIFile {

        private string filePath;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString (string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString (string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public INIFile (string filePath) {
            this.filePath = filePath;
        }

        public void Write (string section, string key, string value) {
            WritePrivateProfileString(section, key, value, filePath);
        }

        public string Read (string section, string key) {
            StringBuilder SB = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "", SB, 255, filePath);
            return SB.ToString();
        }

        public string FilePath {
            get { return filePath; }
            set { filePath = value; }
        }
    }
}
