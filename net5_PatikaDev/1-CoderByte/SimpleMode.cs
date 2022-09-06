using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace net5.CoderByte.SimpleMode {



    class MainClass {

        public static int SimpleMode(int[] arr) {

            var r = arr.GroupBy(g => g)
                .Select((s, i) => new { s.Key, Count = s.Count(), ind = i })
                .Where(w => w.Count > 1)
                .OrderByDescending(o=> o.Count  ).ThenBy(t=> t.ind)
                .ToList();
            return r.Count == 0 ? -1 : r.First().Key;

        }

        public static void Main() {
            // keep this function call here
            //Console.WriteLine(SimpleMode(Console.ReadLine()));
            Console.WriteLine(SimpleMode(new int[] { 5, 5, 2, 2, 1 }));
            Console.WriteLine(SimpleMode(new int[] { 3, 4, 1, 6, 10 }));
            Console.WriteLine(SimpleMode(new int[] { 4, 4, 5, 6, 7, 8, 8, 8, 8, 8 }));
        }

    }

}