
namespace net5.hackerrank.challenges {
  namespace s10_standard_deviation {

	 using System.CodeDom.Compiler;
	 using System.Collections.Generic;
	 using System.Collections;
	 using System.ComponentModel;
	 using System.Diagnostics.CodeAnalysis;
	 using System.Globalization;
	 using System.IO;
	 using System.Linq;
	 using System.Reflection;
	 using System.Runtime.Serialization;
	 using System.Text.RegularExpressions;
	 using System.Text;
	 using System;

	 class Result {

		/*
       * Complete the 'stdDev' function below.
       *
       * The function accepts INTEGER_ARRAY arr as parameter.
       */

		public static void stdDev(List<int> arr) {
		  // Print your answers to 1 decimal place within this function
		  decimal d     = 0;
		  decimal n     = arr.Count();
		  decimal sum   = arr.Sum();
		  decimal u     = sum / n;
		  arr.ForEach(f => { d += (f - u) * (f - u); });
		  var dn        = (d / n);
		  var sq        = Math.Sqrt((double)dn);
		  var result    = Math.Round(sq, 1);
		  result        = sq;
		  Console.WriteLine($"{result:F1}");
		}
	 }

	 class Solution {
		public static void Main(string[] args) {
		  //int n = Convert.ToInt32(Console.ReadLine().Trim());

		  //List<int> vals = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(valsTemp => Convert.ToInt32(valsTemp)).ToList();
		  List<int> vals = "10 40 30 50 20".Split(' ').ToList().Select(valsTemp => Convert.ToInt32(valsTemp)).ToList();
		  // 30466.9
		  vals = "64630 11735 14216 99233 14470 4978 73429 38120 51135 67060".Split(' ').ToList().Select(valsTemp => Convert.ToInt32(valsTemp)).ToList();

		  Result.stdDev(vals);
		}
	 }

  }
}