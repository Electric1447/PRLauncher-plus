using System;
using System.IO;
using System.Linq;

namespace PRLauncher_plus.Objects {

    class WadList {

        private readonly string[] wadsFilenameDB = new string[] { "doom.wad", "doom1.wad", "doomu.wad", "doom2.wad", "plutonia.wad", "tnt.wad", "freedoom1.wad", "freedoom2.wad"};
        private readonly string[] wadsTitleDB = new string[] { "Doom / Ultimate Doom", "Doom", "The Ultimate Doom", "Doom II: Hell on Earth", "The Plutonia Experiment", "TNT: Evilution", "Freedoom: Phase 1", "Freedoom: Phase 2"};

        private string[] wadsFilename;
        private string[] wadsTitle;

        public WadList () {
        }

        public void DetectWads (string path) {

            if (!Directory.Exists(path)) {
                NoIWads("Invalid path");
                return;
            }

            string[] wads = Directory.GetFiles(path, "*.wad");

            for (int i = 0; i < wads.Length; i++)
                wads[i] = wads[i].Substring(wads[i].LastIndexOf('\\') + 1);

            if (wads == null) {
                NoIWads("No iwads found");
                return;
            }

            if (wads.Length == 0) {
                NoIWads("No iwads found");
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

            SetWadsFilename(tempWadFN);
            SetWadsTitle(tempWadT);
        }

        private void NoIWads (string msg) {
            wadsFilename = new string[] {""};
            wadsTitle = new string[] {"No iwads"};
            Console.WriteLine(msg);
        }

        // Get & Set methods
        public string[] GetWadsFilename () {
            return wadsFilename;
        }

        public void SetWadsFilename (string[] wfn) {
            wadsFilename = wfn;
        }

        public string[] GetWadsTitle () {
            return wadsTitle;
        }

        public void SetWadsTitle (string[] wt) {
            wadsTitle = wt;
        }

        // Returns the wad full title (title + filename)
        public string[] GetWadsFullTitle () {
            string[] str = new string[wadsFilename.Length];

            for (int i = 0; i < str.Length; i++)
                str[i] = IsKnown(i) ? wadsTitle[i] : wadsTitle[i] + " (" + wadsFilename[i] + ")";

            return str;
        }

        // Returns if wad is known (in the database)
        public bool IsKnown (int index) {
            if (wadsFilename == null)
                return false;

            return (Array.IndexOf(wadsFilenameDB, wadsFilename[index]) > -1);
        }

    }
}
