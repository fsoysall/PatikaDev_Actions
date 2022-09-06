
namespace net5.hackerrank.Questions.fizzBuzz {

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
		 * Complete the 'fizzBuzz' function below.
		 *
		 * The function accepts INTEGER n as parameter.
		 */

		public static void fizzBuzz(int n) {
			var b = false;
			for (int i = 1; i < n + 1; i++) {
				b = false;
				if (i % 3 == 0) { Console.Write("Fizz"); b = true; }
				if (i % 5 == 0) { Console.Write("Buzz"); b = true; }
				if (b == false) { Console.Write(i); }
				Console.WriteLine();
				}

			}

		}

	class Solution {
		public static void Main(string [] args) {
			int n = Convert.ToInt32(Console.ReadLine().Trim());
			Result.fizzBuzz(n);
			}
		}


	}