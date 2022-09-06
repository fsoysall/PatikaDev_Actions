using System;
using System.Linq;

using static System.Convert;

namespace net5.CoderByte.ThreeFive_Multiples {


  using System;
  using System.Collections.Generic;
  using System.Linq;


  class MainClass {

	 public static string ThreeFiveMultiples(string pNum) {
		var num = Convert.ToInt32(pNum);
		var l35 = DividerOf3And5(num);


		var r = l35.Sum();
		var rL = "";

		l35.ForEach(f => rL += $"{f}, ");
		Console.Write($"{pNum} : {rL.TrimEnd(new char[] { ' ', ',' })} : ");

		return r.ToString();
	 }

	 private static List<int> DividerOf3And5(int num) {
		var list = new List<int>();
		int i = 1;
		while (i < num ) {
		  if (i % 3 == 0) { list.Add(i); }
		  else if (i % 5 == 0) { list.Add(i); }
		  i++;
		}
		return list;
	 }


	 static public void Main() {
		// keep this function call here
		Console.WriteLine(ThreeFiveMultiples("6"));
		
		Console.WriteLine(ThreeFiveMultiples("7"));
		Console.WriteLine(ThreeFiveMultiples("9"));
		Console.WriteLine(ThreeFiveMultiples("28"));
		Console.WriteLine(ThreeFiveMultiples("13"));
		Console.WriteLine(ThreeFiveMultiples("17"));
		Console.WriteLine(ThreeFiveMultiples("19"));
		Console.WriteLine(ThreeFiveMultiples("465"));
		Console.WriteLine(ThreeFiveMultiples("0"));
		Console.WriteLine(ThreeFiveMultiples("2"));
		Console.WriteLine(ThreeFiveMultiples("3"));
		Console.WriteLine(ThreeFiveMultiples("5"));
	 }

  }




}