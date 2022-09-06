using System;
using System.Linq;

using static System.Convert;

namespace net5.CoderByte.DashInsert2 {

    class MainClass {

        public static string DashInsert(string str) {
            if (string.IsNullOrEmpty(str)) { return null; }
            if (str.Trim() == "") { return null; }

            var arr = str.ToCharArray();
            var result = "";
            var odds = new int[] { 1, 3, 5, 7, 9 };

            for (long i = 0; i < arr.LongLength - 1; i++) {
                result += arr[i]
                    + (
                    odds.Contains(arr[i]) && odds.Contains(arr[i + 1])
                    ? "-" : ""
                    );

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