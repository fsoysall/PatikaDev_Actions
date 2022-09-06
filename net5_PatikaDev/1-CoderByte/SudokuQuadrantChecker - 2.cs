using System;
using System.Collections.Generic;


namespace net5.CoderByte.SudokuQuadrantChecker2
{

	//var result2 = net5.CoderByte.SudokuQuadrantChecker2.MainClass.SudokuQuadrantChecker(xCase);



	/* 
		Ref: What I tried for a test from https://coderbyte.com 
		Function: To check a Sudoku number set to see which quadrant is wrong
	*/
	class MainClass
	{
		public static string SudokuQuadrantChecker(string[] strArr)
		{
			string[][] Rows = new string[9][];
			string[][] Cols = new string[9][];
			for (int i = 0; i < 9; i++)
			{
				Rows[i] = new string[9];
				Cols[i] = new string[9];
			}

			fillUpRowsCols(strArr, Rows, Cols);
			List<int> lstQ = new List<int>();
			for (int i = 0; i < 9; i++)
			{
				checkRows(Rows[i], lstQ, i);
			}

			for (int i = 0; i < 9; i++)
			{
				checkCols(Cols[i], lstQ, i);
			}

			lstQ.Sort();

			if (lstQ.Count > 0)
				return string.Join(",", lstQ);

			return "legal";
		}

		public static void fillUpRowsCols(string[] strArr, string[][] Rows, string[][] Cols)
		{
			int iRow = 0;
			foreach (string str in strArr)
			{
				string[] strCells = str.Substring(1, str.Length - 2).Split(",");
				for (int i = 0; i < 9; i++)
				{
					Rows[iRow][i] = strCells[i];
					Cols[i][iRow] = strCells[i];
				}
				iRow++;
			}
		}

		public static void checkRows(string[] Row, List<int> lstQ, int RowNo)
		{
			for (int i = 0; i < 8; i++)
			{
				for (int j = i + 1; j < 9; j++)
				{
					if (Row[i] == "x" || Row[j] == "x") continue;

					if (Row[i] == Row[j])
					{
						int iTmp1 = (i / 3) + 1 + (3 * (RowNo / 3));
						int iTmp2 = (j / 3) + 1 + (3 * (RowNo / 3));
						if (!lstQ.Contains(iTmp1)) lstQ.Add(iTmp1);
						if (!lstQ.Contains(iTmp2)) lstQ.Add(iTmp2);
					}
				}
			}
		}

		public static void checkCols(string[] Col, List<int> lstQ, int ColNo)
		{
			for (int i = 0; i < 8; i++)
			{
				for (int j = i + 1; j < 9; j++)
				{
					if (Col[i] == "x" || Col[j] == "x") continue;

					if (Col[i] == Col[j])
					{
						int iTmp1 = (ColNo / 3) + 1 + (3 * (i / 3));
						int iTmp2 = (ColNo / 3) + 1 + (3 * (j / 3));
						if (!lstQ.Contains(iTmp1)) lstQ.Add(iTmp1);
						if (!lstQ.Contains(iTmp2)) lstQ.Add(iTmp2);
					}
				}
			}
		}

		internal static void Main()
		{
			// keep this function call here
			//Console.WriteLine(SudokuQuadrantChecker(Console.ReadLine()));// For testing, the input is fed like this in the site => new string[] {"(1,2,3,4,5,6,7,8,1)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(1,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)"}
			// Console.WriteLine(SudokuQuadrantChecker(Console.ReadLine()));// For testing, the input is fed like this in the site => new string[] {"(1,2,3,4,5,6,7,8,1)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(1,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)","(x,x,x,x,x,x,x,x,x)"}

			var l = new string[] { "(1,2,3,4,5,6,7,8,1)", "(x,x,x,x,x,x,x,x,x)", "(x,x,x,x,x,x,x,x,x)", "(1,x,x,x,x,x,x,x,x)", "(x,x,x,x,x,x,x,x,x)", "(x,x,x,x,x,x,x,x,x)", "(x,x,x,x,x,x,x,x,x)", "(x,x,x,x,x,x,x,x,x)", "(x,x,x,x,x,x,x,x,x)" };
			//foreach (var s in l) {
			Console.WriteLine(SudokuQuadrantChecker(l));
		}
		//}
	}

}