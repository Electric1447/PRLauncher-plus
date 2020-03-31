namespace PRLauncher_plus.Objects {
    class Levels {

        private readonly static string[] doom_lvlArr = new string[] {
            "E1M1", "E1M2", "E1M3", "E1M4", "E1M5", "E1M6", "E1M7", "E1M8", "E1M9",
            "E2M1", "E2M2", "E2M3", "E2M4", "E2M5", "E2M6", "E2M7", "E2M8", "E2M9",
            "E3M1", "E3M2", "E3M3", "E3M4", "E3M5", "E3M6", "E3M7", "E3M8", "E3M9"};

        private readonly static string[] doomu_lvlArr = new string[] {
            "E1M1", "E1M2", "E1M3", "E1M4", "E1M5", "E1M6", "E1M7", "E1M8", "E1M9",
            "E2M1", "E2M2", "E2M3", "E2M4", "E2M5", "E2M6", "E2M7", "E2M8", "E2M9",
            "E3M1", "E3M2", "E3M3", "E3M4", "E3M5", "E3M6", "E3M7", "E3M8", "E3M9",
            "E4M1", "E4M2", "E4M3", "E4M4", "E4M5", "E4M6", "E4M7", "E4M8", "E4M9"};
            
        private readonly static string[] doom2_lvlArr = new string[] {
            "MAP01", "MAP02", "MAP03", "MAP04", "MAP05", "MAP06", "MAP07", "MAP08",
            "MAP09", "MAP10", "MAP11", "MAP12", "MAP13", "MAP14", "MAP15", "MAP16",
            "MAP17", "MAP18", "MAP19", "MAP20", "MAP21", "MAP22", "MAP23", "MAP24",
            "MAP25", "MAP26", "MAP27", "MAP28", "MAP29", "MAP30", "MAP31", "MAP32"};

        private readonly static string[][] levelsArr = new string[3][] { doom_lvlArr, doomu_lvlArr, doom2_lvlArr };

        private static int DetectIWadType (string wfn) {

            if (wfn.Equals("doom1.wad"))
                return 0; // Doom 1
            else if (wfn.Equals("doom.wad") || wfn.Equals("doomu.wad") || wfn.Equals("freedoom1.wad"))
                return 1; // Ultimate Doom
            else if (wfn.Equals("doom2.wad") || wfn.Equals("plutonia.wad") || wfn.Equals("tnt.wad") || wfn.Equals("freedoom2.wad"))
                return 2; // Doom II / Final Doom

            return -1;
        }

        public static string[] GetLevelList (string wfn) {
            return levelsArr[DetectIWadType(wfn)];
        }

        public static string ParseLevel (string wfn, int index) {

            if (DetectIWadType(wfn) == 0 || DetectIWadType(wfn) == 1)
                return (index / 9 + 1) + " " + (index % 9 + 1);
            else if (DetectIWadType(wfn) == 2)
                return (index + 1).ToString();

            return "";
        }

        public static string ReverseParseLevel (string wfn, string wd) {
            int m;

            if (DetectIWadType(wfn) == 0 || DetectIWadType(wfn) == 1) {
                if (int.TryParse(wd[0].ToString(), out int e) && int.TryParse(wd[2].ToString(), out m))
                    return "E" + e + "M" + m;
            } else if (DetectIWadType(wfn) == 2) {
                if (int.TryParse(wd, out m))
                    return "MAP" + m.ToString().PadLeft(2, '0');
            }

            return "";
        }

    }
}
