using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRLauncher_plus {

    class WadList {

        private readonly string[] wadsFilenameDB = new string[] { "doom.wad", "doom1.wad", "doomu.wad", "doom2.wad", "plutonia.wad", "tnt.wad"};
        private readonly string[] wadsTitleDB = new string[] { "Doom / Ultimate Doom", "Doom", "The Ultimate Doom", "Doom II: Hell on Earth", "The Plutonia Experiment", "TNT: Evilution"};

        private string[] wadsFilename;
        private string[] wadsTitle;

        public WadList () {

        }

        public void detectWads (string path) {

            if (!Directory.Exists(path)) {
                noIWads("Invalid path");
                return;
            }

            string[] wads = Directory.GetFiles(path, "*.wad");

            for (int i = 0; i < wads.Length; i++)
                wads[i] = wads[i].Substring(wads[i].LastIndexOf('\\') + 1);

            if (wads == null) {
                noIWads("No iwads found");
                return;
            }

            if (wads.Length == 0) {
                noIWads("No iwads found");
                return;
            }

            string[] tempWadFN = new string[wads.Length];
            string[] tempWadT = new string[wads.Length];
            
            string[] tempStr = wads.Select(s => s.ToLowerInvariant()).ToArray();
            Array.Sort(tempStr);

            for (int i = 0; i < tempStr.Length; i++) {
                if (Array.IndexOf(wadsFilenameDB, tempStr[i]) > -1) {
                    int index = Array.IndexOf(wadsFilenameDB, tempStr[i]);
                    tempWadFN[i] = wadsFilenameDB[index];
                    tempWadT[i] = wadsTitleDB[index];
                } else {
                    tempWadFN[i] = tempStr[i];
                    tempWadT[i] = tempStr[i];
                }
            }

            this.setWadsFilename(tempWadFN);
            this.setWadsTitle(tempWadT);
        }

        private void noIWads (string msg) {
            this.wadsFilename = new string[] {""};
            this.wadsTitle = new string[] {"No iwads"};
            Console.WriteLine(msg);
        }

        // Get & Set methods
        public string[] getWadsFilename () {
            return this.wadsFilename;
        }

        public void setWadsFilename (string[] wfn) {
            this.wadsFilename = wfn;
        }

        public string[] getWadsTitle () {
            return this.wadsTitle;
        }

        public void setWadsTitle (string[] wt) {
            this.wadsTitle = wt;
        }

        public string getWadFilename (int index) {
            return this.wadsFilename[index];
        }

        public void setWadFilename (string wfn, int index) {
            this.wadsFilename[index] = wfn;
        }

        public string getWadTitle (int index) {
            return this.wadsTitle[index];
        }

        public void setWadTitle (string wt, int index) {
            this.wadsTitle[index] = wt;
        }

        public string[] getWadsFullTitle () {
            string[] str = new string[this.wadsFilename.Length];

            for (int i = 0; i < str.Length; i++) {
                if (this.IsKnown(i))
                    str[i] = this.wadsTitle[i] + " (" + this.wadsFilename[i] + ")";
                else
                    str[i] = this.wadsTitle[i];
            }

            return str;
        }

        public string getWadFullTitle (int index) {
            return (this.wadsTitle[index] + " (" + this.wadsFilename[index] + ")");
        }

        public bool IsKnown (int index) {

            if (this.wadsFilename == null)
                return false;

            return (Array.IndexOf(wadsFilenameDB, this.wadsFilename[index]) > -1);
        }

    }
}
