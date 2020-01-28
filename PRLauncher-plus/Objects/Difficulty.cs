using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRLauncher_plus.Objects {

    class Difficulty {

        public static readonly string[] doom_difflvlArr = new string[] { "I'm too young to die", "Hey, not too rough", "Hurt me plenty", "Ultra-Violence", "Nightmare!" };
        public static readonly string[] freedoom_difflvlArr = new string[] { "Please don't Kill Me!", "Will this Hurt?", "Bring on the Pain.", "Extreme-Carnage.", "Mayhem!" };

        public static readonly string[][] difflvlArr = new string[2][] { doom_difflvlArr, freedoom_difflvlArr };

        public static string[] GetDifflvlList (string wfn) {
            int index = 0;

            if (wfn.Equals("freedoom1.wad") || wfn.Equals("freedoom2.wad"))
                index = 1;

            return difflvlArr[index];
        }

    }
}
