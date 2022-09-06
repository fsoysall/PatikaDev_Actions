using System;
using System.Linq;

using static System.Convert;

namespace net5.CoderByte.PentagonalNumber {

  using System;

  class MainClass {

	 public static int PentagonalNumber(int num) {
		return (5 * num * num - 5 * num + 2) / 2;
	 }

	 public static void Main() {
		// keep this function call here
		//Console.WriteLine(PentagonalNumber(int.Parse(Console.ReadLine())));
		Console.WriteLine(PentagonalNumber(2)	 + "   6 ");   // 6
		Console.WriteLine(PentagonalNumber(3)	 + "   16 ");   // 16
		Console.WriteLine(PentagonalNumber(4)	 + "   31 ");   // 31
		Console.WriteLine(PentagonalNumber(5)	 + "   51 ");   // 51
		Console.WriteLine(PentagonalNumber(6)	 + "   76 ");   // 76
		Console.WriteLine(PentagonalNumber(7)	 + "   106 ");   // 106
		Console.WriteLine(PentagonalNumber(11)	 + "   276 ");  // 276
		Console.WriteLine(PentagonalNumber(16)	 + "   601 ");  // 601
		Console.WriteLine(PentagonalNumber(22)	 + "   1156 ");  // 1156
	 }

  }


}
