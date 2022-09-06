

namespace net5.CoderByte.SudokuQuadrantChecker {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using System.Diagnostics;

	class MainClass {

		private static string [,] sdk = new string [9, 9];
		private static List<int> BugList = new List<int>();

		private static int GetQuadNo(int row, int col) {
			var a = (int)Math.Ceiling((double)(row + 1) / 3);
			var b = (int)Math.Ceiling((double)(col + 1) / 3);
			int c = ((a - 1) * 3) + b;
			Debug.WriteLine($"{c}. QUAD  {row}:{col} :: {sdk [row, col]} ");
			// Console.WriteLine($"QN:{c}");
			return c;

			}

		// (1,2,3,4,5,6,7,8,1)
		// (x,x,x,x,x,x,x,x,x)
		// (x,x,x,x,x,x,x,x,x)
		// (1,x,x,x,x,x,x,x,x)
		// (x,x,x,x,x,x,x,x,x)
		// (x,x,x,x,x,x,x,x,x)
		// (x,x,x,x,x,x,x,x,x)
		// (x,x,x,x,x,x,x,x,x)
		// (x,x,x,x,x,x,x,x,x)

		private static bool CheckDupInRows(int row, int cRow, int cCol) {
			string v = sdk [cRow, cCol];
			for (var col = 0; col < 9; col++) {
				if (col != cCol) {
					if (char.IsDigit(v, 0)) {		// 0 'da olabilir , onun 1..9 kontrol'ü daha mantıklı
						if (sdk [row, col] == v) { return true; }
						}
					}
				}
			return false;
			}

		private static bool CheckDupInCols(int col, int cRow, int cCol) {
			var v = sdk [cRow, cCol];
			for (var row = 0; row < 9; row++) {
				if (row != cRow) {
					if (char.IsDigit(v, 0)) {
						if (sdk [row, col] == v) { return true; }
						}
					}
				}
			return false;
			}

		public static string SudokuQuadrantChecker(string [] strArr) {
			// if(strArr.Length<2) return "bug" // no need check it because answer is legal or bug list
			var result = "";
			BugList = new List<int>();

			FillSudoku(strArr);


			for (var q = 0; q < 9; q++) {
				for (var w = 0; w < 9; w++) {
					if (CheckDupInRows(q, q, w)) { BugList.Add(GetQuadNo(q, w)); }
					if (CheckDupInCols(w, q, w)) { BugList.Add(GetQuadNo(q, w)); }
					}
				}

			// code goes here  
			if (BugList.Count == 0) { result = "legal"; }
			else {
				result = string.Join(",", BugList.Distinct());
				Debug.Print($"BL: {string.Join(",", BugList)}");
				}
			return result;

			}

		private static void FillSudoku(string [] strArr) {
		// ["(1,2,3,4,5,6,7,8,1)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(1,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)"]

		// (1,2,3,4,5,6,7,8,1)
		// (x,x,x,x,x,x,x,x,x)
		// (x,x,x,x,x,x,x,x,x)
		// (1,x,x,x,x,x,x,x,x)
		// (x,x,x,x,x,x,x,x,x)
		// (x,x,x,x,x,x,x,x,x)
		// (x,x,x,x,x,x,x,x,x)
		// (x,x,x,x,x,x,x,x,x)
		// (x,x,x,x,x,x,x,x,x)

			var row = 0; var col = 0;
			foreach (var r in strArr) {
				col = 0;
				// (1,2,3,4,5,6,7,8,1)
				// 1,2,3,4,5,6,7,8,1
				foreach (var c in r.Trim('(', ')').Split(',')) {
					sdk [row, col] = c;
					col++;
					}
				row++;
				}
			}


		internal static void Main() {
			// keep this function call here
			// var r = Console.ReadLine();
			 //Console.WriteLine(SudokuQuadrantChecker(r.Split(',').ToArray()));
			var AnswerS = new List<string>() { "1,3,4", "3,4,5,9", "4,5",
															"legal", "legal",
															"3,9", "3,6,9",   "1,3,7",
															"legal",
															"2" };

			var CaseS = new List<string []> {
				  new string [] { "(1,2,3,4,5,6,7,8,1)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(1,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)" }
				, new string [] { "(1,2,3,4,5,6,7,8,9)","(x,x,x,x,x,x,x,x,x)","(6,x,5,x,3,x,x,4,x)","(2,x,1,1,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,9)" }
				, new string [] { "(1,2,3,4,5,6,7,8,9)","(x,x,x,x,x,x,x,x,x)","(6,x,5,x,3,x,x,4,x)","(2,x,1,1,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)" }

				, new string [] {"(1,2,3,4,5,6,7,8,9)","(x,x,x,x,x,x,x,x,x)","(6,x,5,x,3,x,x,4,x)","(2,x,1,5,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,8)"}
				, new string [] {"(1,2,3,4,5,6,7,8,9)","(x,x,x,x,x,x,x,x,x)","(6,x,5,x,3,x,x,4,x)","(2,x,1,5,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,4)","(9,1,2,3,4,5,6,7,8)"}

				, new string [] {"(1,2,3,4,5,6,7,8,9)","(x,x,x,x,x,x,x,x,x)","(6,x,5,x,3,x,x,4,x)","(2,x,1,5,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,9)","(9,1,2,3,4,5,6,7,8)"}
				, new string [] {"(1,2,3,4,5,6,7,8,9)","(x,x,x,x,x,x,x,x,x)","(6,x,5,x,3,x,x,4,x)","(2,x,1,5,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,9)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,9)","(9,1,2,3,4,5,6,7,8)"}
				, new string [] {"(9,2,3,4,5,6,7,8,9)","(x,x,x,x,x,x,x,x,x)","(6,x,5,x,3,x,x,4,x)","(2,x,1,5,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,1)","(x,x,x,x,x,x,x,x,2)","(9,1,2,3,4,5,6,7,8)"}

				, new string [] {"(1,2,3,4,5,6,7,8,9)","(4,5,6,x,x,x,x,x,x)","(7,8,9,x,x,x,x,x,x)","(2,3,4,x,x,x,x,x,x)","(5,6,7,x,x,x,x,x,x)","(8,9,1,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,1)"}

				, new string [] {"(1,2,3,4,5,6,7,8,9)","(4,5,6,1,2,3,x,x,x)","(7,8,9,x,x,6,x,x,x)","(2,3,4,x,x,x,x,x,x)","(5,6,7,x,x,x,x,x,x)","(8,9,1,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,1)"}
				};

			for (int i = 0; i < CaseS.Count; i++) {
				string [] xCase = CaseS [i];
				Debug.WriteLine($"\r\n it's starts;  " + string.Join(' ', xCase).Replace("x", "").Replace(",,", ",").Replace(",,", ",").Replace("(,", "(").Replace("(,", "("));
				var result = SudokuQuadrantChecker(xCase);
				Console.WriteLine($"R:{i} :: {AnswerS [i] == result} :: {AnswerS [i].PadRight(15)} :: {result}");
				//Console.WriteLine($"R:{i} :: {AnswerS [i] == result} :: {AnswerS [i].PadRight(15)} :: {result} :: {result2.PadRight(15)} ");
				}

			}

		}

	}