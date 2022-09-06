using System;
using System.Linq;

using System.Collections;
using System.Collections.Generic;



using static FSYS.MyAddons;
using System.Diagnostics;

namespace net5.CoderByte.SecondGreatLow {


    class MainClass {


        static public string SecondGreatLow(long[] pNums) {
            var nums = pNums.ToList();
            nums.Sort();

            //if (nums.Count < 3) { return $"{nums[1]} {nums[0]} - {string.Join(" ", pNums)}"; }
            //if (nums.Count > 2) { return $"{nums[nums.Count - 1 - 1]} {nums[1]} - {string.Join(" ", pNums)}"; }
            if (nums.Count < 3) { return $"{nums[1]} {nums[0]}"; }

            nums = nums.Distinct().ToList();
            if (nums.Count > 2) { return $"{nums[1]} {nums[nums.Count - 1 - 1]}"; }

            return "hiyyaa";
        }

        static public void Main() {
            // keep this function call here
            //Console.WriteLine(KnightJumps(Console.ReadLine()));
            Console.WriteLine(SecondGreatLow(new long[] { 7, 7, 12, 98, 106 }));
            Console.WriteLine(SecondGreatLow(new long[] { 1, 2, 3, 100 }));
            Console.WriteLine(SecondGreatLow(new long[] { 42, 42 }));
            Console.WriteLine(SecondGreatLow(new long[] { 90, 4 }));
            Console.WriteLine(SecondGreatLow(new long[] { 80, 80 }));
        }




    }
}



