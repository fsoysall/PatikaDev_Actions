using System;
using System.Linq;

using System.Collections;
using System.Collections.Generic;



using static FSYS.MyAddons;
using System.Diagnostics;

namespace net5.CoderByte.KnightMove {

    using System;

    class MainClass {

        // - 8 7 6 5 4 3 2 1
        // 8 . . . . . . . .
        // 7 . . . . . . . .
        // 6 . . . . . . . .
        // 5 . . . . . . . .
        // 4 . . . . . . . .
        // 3 . . . . . . . .
        // 2 . . . . . . . .
        // 1 . . . . . . . .

        public static List<xy> KnightyMoves(xy xy) { return KnightyMoves(xy.x, xy.y); }

        public static List<xy> KnightyMoves(int x, int y) {
            var moves = new List<xy>();

            moves.Add(new xy(x + 2, y + 1));
            moves.Add(new xy(x + 2, y - 1));

            moves.Add(new xy(x - 2, y + 1));
            moves.Add(new xy(x - 2, y - 1));

            moves.Add(new xy(x + 1, y + 2));
            moves.Add(new xy(x + 1, y - 2));

            moves.Add(new xy(x - 1, y + 2));
            moves.Add(new xy(x - 1, y - 2));

            var ValidMoves = new List<xy>();
            foreach (var f in moves) {
                if (IsKnighty(f)) { ValidMoves.Add(f); }
            };

            return ValidMoves;

        }

        public static bool IsKnighty(xy xy) => xy.x > 0 && xy.y > 0 && xy.x < 9 && xy.y < 9;

        public static string KnightJumps(string str) {
            var xy1 = str.ToCharArray();
            var x = int.Parse(xy1[1].ToString());
            var y = int.Parse(xy1[3].ToString());
            var xy = new xy(x, y);

            // return IsKnighty(xy).ToString();
            return KnightyMoves(xy).Count.ToString();
        }

        static public void Main() {
            // keep this function call here
            //Console.WriteLine(KnightJumps(Console.ReadLine()));
            Console.WriteLine(KnightJumps("(1 1)"));
            Console.WriteLine(KnightJumps("(2 8)"));
            Console.WriteLine(KnightJumps("(4 4)"));
        }



        public class xy {
            public int x { get; set; }
            public int y { get; set; }

            public xy(int x, int y) {
                this.x = x;
                this.y = y;
            }

            public override string ToString() => $"{x}:{y}";

        }


    }
}



