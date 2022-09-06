
namespace net5.hackerrank.challenges {
  namespace s10_interQuartile_Range {

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
       * Complete the 'interQuartile' function below.
       *
       * The function accepts following parameters:
       *  1. INTEGER_ARRAY values
       *  2. INTEGER_ARRAY freqs
       */

		public static void interQuartile(List<int> values, List<int> freqs) {
		  // Print your answer to 1 decimal place within this function

		  var arr = new List<int>();
		  for (int i = 0; i < values.Count; i++) {
			 for (int k = 0; k < freqs[i]; k++) {
				arr.Add(values[i]);
			 }
		  }

		  arr.Sort();

		  var midArr = GetMiddleArr(arr);
		  var LeftArr = GetLeftArr(arr);
		  var RightArr = GetRightArr(arr);
		  var r = (GetMiddleArr(RightArr)[0] - GetMiddleArr(LeftArr)[0]);
		  Console.WriteLine($"{r:f1}");

		}

		private static List<int> GetMiddleArr(List<int> arr) {
		  var c = arr.Count();
		  var mid = c / 2;
		  var IsOdd = c % 2 == 1;
		  return new List<int>() { IsOdd ? arr[mid] : (arr[mid - 1] + arr[mid]) / 2 };
		}

		private static List<int> GetRightArr(List<int> arr) {
		  var c = arr.Count();
		  var mid = c / 2;
		  var IsOdd = c % 2 == 1;
		  //var r = mid < 1 ? arr : arr.Skip(mid).ToList();
		  var r = arr.TakeLast(mid).ToList();
		  return r;
		}

		private static List<int> GetLeftArr(List<int> arr) {
		  var c = arr.Count();
		  var mid = c / 2;
		  var IsOdd = c % 2 == 1;
		  //var r = mid < 1 ? arr : arr.Take(mid).ToList();
		  var r = arr.Take(mid).ToList();
		  return r;
		}

	 }




	 static class Solution {
		public static void Main(string[] args) {
		  //int n = Convert.ToInt32(Console.ReadLine().Trim());
		  //List<int> val = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(valTemp => Convert.ToInt32(valTemp)).ToList();
		  //List<int> freq = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(freqTemp => Convert.ToInt32(freqTemp)).ToList();

		  Result.interQuartile("10 40 30 50 20".SplitIt(), "1 2 3 4 5".SplitIt());
		  Result.interQuartile("1,2,3".SplitIt(), "3,2,1".SplitIt());
		  Result.interQuartile("6 12 8 10 20 16".SplitIt(), "5, 4, 3, 2, 1, 5".SplitIt());



		}

		public static List<int> SplitIt(this string data) {
		  return data.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList().Select(dataTemp => Convert.ToInt32(dataTemp)).ToList();
		}

	 }


  }
}

