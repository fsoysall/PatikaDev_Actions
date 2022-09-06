using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace net5.CoderByte.DashInsertRegEx {

    class MainClass {


        public static string DashInsert(string str) {
            if (string.IsNullOrEmpty(str)) { return null; }
            if (str.Trim() == "") { return null; }
            var re = new Regex("(?<=[13579])(?=[13579])", RegexOptions.IgnoreCase);
            return re.Replace(str, "-");
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