using System;
using System.Linq;

using System.Collections;
using System.Collections.Generic;



using static FSYS.MyAddons;
using System.Diagnostics;

namespace net5.CoderByte.AdditivePersistence {


    class MainClass {

        public static void logl(object what) { logL(what); }
        public static void logL(object what) { Debug.WriteLine(what); }



        public static int checkDigCount(int num) {
            //if ( num >= 0 && num <= 9 ) { return 0; }
            return num.ToString().ToCharArray().Length;
        }

        public static int checkDigCount(Array num) { return num.Length; }

        public static int GetSum(int num) {
            var AsChar = num.ToString().ToCharArray();
            var sum = AsChar.Select(
                s => int.Parse(s.ToString())
                )
                .Sum();
            return sum;
        }


        public static int GetSum(char[] AsChar) {
            var sum = AsChar.Select(s => int.Parse(s.ToString())).Sum();
            return sum;
        }



        public static int AdditivePersistence(int num) {

            var step = 0;
            var sum = num;
            var AsChar = sum.ToString().ToCharArray();
            var digit = checkDigCount(AsChar);

            // logl($"\r\n\rdigit: {digit}\r\n");
            if (digit == 1) { return 0; }


            while (AsChar.Length > 1 /*  step == 0 || sum > 9 */  ) {
                step++;
                sum = GetSum(AsChar);
                AsChar = sum.ToString().ToCharArray();
            }
            // logl($"\r\ndone: {step} \r\n");
            return step;
        }

        public static void Main() {
            // keep this function call here
            //var q = int.Parse(Console.ReadLine());
            Console.WriteLine(AdditivePersistence(81));
            Console.WriteLine(AdditivePersistence(987654));
            Console.WriteLine(AdditivePersistence(98765));
            Console.WriteLine(AdditivePersistence(9876));
            Console.WriteLine(AdditivePersistence(987));
            Console.WriteLine(AdditivePersistence(98));
        }

    }
}













