using System;
using System.Linq;

using System.Collections;
using System.Collections.Generic;



using static FSYS.MyAddons;
using System.Diagnostics;

namespace net5.CoderByte.KaprekarsConstant {


    class MainClass {

        static public void Main() {
            // keep this function call here
            Console.WriteLine(KaprekarsConstant(6174));
            Console.WriteLine(KaprekarsConstant(3524));
            Console.WriteLine(KaprekarsConstant(2111));
            Console.WriteLine(KaprekarsConstant(9831));
        }

        private static int KaprekarsConstant(int num) { return KaprekarsConstant(num, 0); }

        private static int KaprekarsConstant(int num, int step) {
            step++;

            var chars = num.ToString().PadLeft(4,'0').ToCharArray().ToList();
            chars.Sort();
            var min = int.Parse(string.Join("", chars));
            
            chars.Reverse();
            var max = int.Parse(string.Join("", chars));

            var result = max - min;
            if (result == 6174) { return step; }
            if (result == 0) { return 0; }

            return KaprekarsConstant(result, step);

        }
    }
}



