using System;
using System.Linq;

using Microsoft.VisualBasic;

using static System.Convert;

namespace net5.CoderByte.DashInsert {

    class MainClass {

        public static string DashInsert(string str) {
            if (string.IsNullOrEmpty(str)) { return null; }
            if (str.Trim() == "") { return null; }

            var arr = str.ToCharArray();
            var result = "";

            for (long i = 0; i < arr.LongLength - 1; i++) {
                var curr = arr[i];
                var curr2 = arr[i + 1];
                result += curr;
                if (char.IsNumber(curr)
                    && (ToInt16(curr) & 1) == 1
                    && (ToInt16(curr2) & 1) == 1
                ) { result += "-"; };

            }

            result += arr.Last();
            return result;

        }


        public static void Main() {
            // keep this function call here
            // Console.WriteLine( DashInsert( Console.ReadLine() ) );
            Console.WriteLine(DashInsert(null));
            Console.WriteLine(DashInsert(String.Empty));
            Console.WriteLine(DashInsert(""));
            Console.WriteLine(DashInsert("454793"));
            Console.WriteLine(DashInsert(" 454793 "));
            Console.WriteLine(DashInsert("56730"));
            Console.WriteLine(DashInsert("99946"));
        }

    }
}