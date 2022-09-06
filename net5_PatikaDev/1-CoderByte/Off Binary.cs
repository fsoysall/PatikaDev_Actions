using System;
using System.Linq;

using System.Collections;
using System.Collections.Generic;



using static FSYS.MyAddons;
using System.Diagnostics;

namespace net5.CoderByte.OffBinary {


    class MainClass {
        
        static public void Main() {
            // keep this function call here
            Console.WriteLine(OffBinary(new string[] { "56", "011000" }));
            Console.WriteLine(OffBinary(new string[] { "5624", "0010111111001" }));
            Console.WriteLine(OffBinary(new string[] { "44", "111111" }));
        }

        private static int OffBinary(string[] pNum) {
            var dec = int.Parse(pNum[0]);
            var dBin = Convert.ToString(dec, 2);
            var bin = pNum[1];
            var needle = 0;

            bin.PadLeft(dBin.Length - bin.Length);
            //if (dBin.Length != bin.Length) { bin.PadLeft(dBin.Length - bin.Length); }
            for (int i = 0; i < bin.Length; i++) {
                if (dBin[i] != bin[i]) { needle++; }
            }
            return needle;
        }
    }
}



