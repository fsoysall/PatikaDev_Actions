using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;



namespace net5.CoderByte.TwoSum {


	internal class MainClass {

		public static string TwoSum(int [] arr) {


			if (arr == null   ) { return "-1"; }
			if (arr.Length < 4) { return "-1"; }

			var result = "";
			var rList = new List<string>();

			for (int i = 1; i < arr.Length; i++) {

				for (int k = 1; k < arr.Length; k++) {

					if (i != k) {
						if (arr [i] + arr [k] == arr [0]) {
							result += $"{i},{k} ";
							rList.Add($"{i},{k}");
							}
						}

					}
				}

			if (string.IsNullOrEmpty(result)) { return "-1"; }
			// code goes here  
			result = string.Join(' ', rList.Distinct().ToList());
			return result;

			}

		internal static void Main() {
			// keep this function call here
			// Console.WriteLine(TwoSum(Console.ReadLine()));
			Console.WriteLine(TwoSum(new int [] { 17, 4, 5, 6, 10, 11, 4, -3, -5, 3, 15, 2, 7 }));

			// Examples
			// Input: new int[] {17, 4, 5, 6, 10, 11, 4, -3, -5, 3, 15, 2, 7}
			// Output: 6,11 10,7 15,2
			// Input: new int[] {7, 6, 4, 1, 7, -2, 3, 12}
			// Output: 6,1 4,3 


			//  
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			}
		}

	}