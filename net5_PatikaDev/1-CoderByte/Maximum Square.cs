using System;
using System.Linq;

using static System.Convert;

namespace net5.CoderByte.MaximumSquare {


  // C# code to implement the approach
  using System;
  using System.Numerics;
  using System.Collections.Generic;

  public class GFG {

	 //static int R = 6;
	 //static int C = 5;

	 public static string MaximalSquare(string[] strArr) {
		int[,] M = new int[strArr.Count(), strArr[0].ToCharArray().Count()];
		int r = 0;
		int c = 0;
		foreach (string s in strArr) {
		  c = 0;
		  foreach (var s2 in s.ToCharArray()) {
			 M[r, c] = int.Parse(s2.ToString());
			 if (c < M.GetUpperBound(1)) { c++; }
		  }
		  if (r < M.GetUpperBound(0)) { r++; }
		}
		return printMaxSubSquare(M).ToString();
	 }


	 static string printMaxSubSquare(int[,] M, bool PrintTheSq = false) {
		//R = M.GetUpperBound(M.GetLength(0));
		var R = M.GetUpperBound(0) + 1;
		var C = M.GetUpperBound(1) + 1;

		int[,] S = new int[2, C];
		int Maxx = 0;

		// set all elements of S to 0 first
		for (int i = 0; i < 2; i++) {
		  for (int j = 0; j < C; j++) {
			 S[i, j] = 0;
		  }
		}

		// Construct the entries
		for (int i = 0; i < R; i++) {
		  for (int j = 0; j < C; j++) {

			 // Compute the entrie at the current position
			 int Entrie = M[i, j];
			 if (Entrie != 0) {
				if (j != 0) {
				  Entrie = 1 + Math.Min(S[1, j - 1], Math.Min(S[0, j - 1], S[1, j]));
				}
			 }

			 // Save the last entrie and add the new one
			 S[0, j] = S[1, j];
			 S[1, j] = Entrie;

			 // Keep track of the max square length
			 Maxx = Math.Max(Maxx, Entrie);
		  }
		}

		// Print the square
		if (PrintTheSq) {
		  Console.Write("Maximum size sub-matrix is: \n");
		  for (int i = 0; i < Maxx; i++) {
			 for (int j = 0; j < Maxx; j++) {
				Console.Write("1 ");
			 }
			 Console.WriteLine();
		  }
		}
		//Console.WriteLine(Maxx * Maxx);
		return (Maxx * Maxx).ToString();
	 }

	 // Driver Code
	 public static void Main(string[] args) {
		var r = "";

		r = MaximalSquare(new string[] { "0111", "1111", "1111", "1111" });
		Console.WriteLine(r);

		r = MaximalSquare(new string[] { "0111", "1101", "0111" });
		Console.WriteLine(r);

		int[,] M = {{0, 1, 1, 0, 1},
				{1, 1, 0, 1, 0},
				{0, 1, 1, 1, 0},
				{1, 1, 1, 1, 0},
				{1, 1, 1, 1, 1},
				{0, 0, 0, 0, 0}};

		printMaxSubSquare(M);

		M = new int[,] {
		  { 1 ,0 ,1 ,0 ,0},
		  { 1 ,0 ,1 ,1 ,1},
		  { 1 ,1 ,1 ,1 ,1},
		  { 1, 0, 0, 1, 0},
		};
		printMaxSubSquare(M);

		M = new int[,] {
			 {0,1,1,1 },
		  {1,1,1,1},
		  { 1,1,1,1},
		  { 1,1,1,1}
		};
		printMaxSubSquare(M);
		M = new int[,] {
			 {0,1,1,1 },
		  {1,1,0,1},
		  { 0,1,1,1},
		};
		printMaxSubSquare(M);

	 }
  }


}