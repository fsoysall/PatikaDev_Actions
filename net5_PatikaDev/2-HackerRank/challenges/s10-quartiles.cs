
namespace net5.hackerrank.challenges {
  namespace s10_quartiles {

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
       * Complete the 'quartiles' function below.
       *
       * The function is expected to return an INTEGER_ARRAY.
       * The function accepts INTEGER_ARRAY arr as parameter.
       */

		public static List<int> quartiles(List<int> arr) {
		  arr.Sort();
		  var n = arr.Count;
		  var IsOdd = n % 2 == 1;
		  var midArr = GetMiddleArr(arr);

		  List<int> l1;
		  List<int> r1;
		  List<int> l3;
		  List<int> r3;

		  if (n == 4) {
			 l1 = arr.Take(2).ToList();
			 r1 = arr.TakeLast(2).ToList();
		  }

		  else {
			 l1 = GetLeftArr(arr);
			 r1 = GetRightArr(arr);
		  }

		  l3 = l1.Count < 3 ? l1 : GetMiddleArr(l1);
		  r3 = r1.Count < 3 ? r1 : GetMiddleArr(r1);

		  var q1 = l3.Sum() / l3.Count;
		  var q2 = midArr.Sum() / midArr.Count;
		  var q3 = r3.Sum() / r3.Count;

		  return new List<int> { q1, q2, q3 };
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

		  //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		  //int n = Convert.ToInt32(Console.ReadLine().Trim());

		  //List<int> data = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(dataTemp => Convert.ToInt32(dataTemp)).ToList();
		  List<int> data;

		  // 6 12 16
		  data = SplitIt("3 5 7 8 12 13 14 18 21"); // 3, 5, 7, 8, 12, 13, 14, 18, 21
		  Console.WriteLine($"\r\n{string.Join("\n", Result.quartiles(data))} : {string.Join(' ', data)}");

		  // 2,5,8
		  data = SplitIt("9,5,7,1,3");   // 1, 3, 5, 7, 9
		  Console.WriteLine($"\r\n{string.Join("\n", Result.quartiles(data))} : {string.Join(' ', data)}");

		  // 4 11 15
		  data = SplitIt("4 17 7 14 18 12 3 16 10 4 4 12"); // 3 4 4 4 7 10 12 12 14 16 17 18
		  Console.WriteLine($"\r\n{string.Join("\n", Result.quartiles(data))} : {string.Join(' ', data)}");

		  // 7,13,15
		  data = SplitIt("3 7 8 5 12 14 21 15 18 14"); // 3, 5, 7, 8, 12, 14, 14, 15, 18, 21
		  Console.WriteLine($"\r\n{string.Join("\n", Result.quartiles(data))} : {string.Join(' ', data)}");


		}

		public static List<int> SplitIt(this string data) {
		  return data.Split(new char[] { ' ', ',' }).ToList().Select(dataTemp => Convert.ToInt32(dataTemp)).ToList();
		}

	 }


  }
}

