using System;
using System.Linq;

using static System.Convert;

namespace net5.CoderByte.Consecutive {

  using System;
  using System.Linq;
  using System.Collections;
  using System.Collections.Generic;

  public class MainClass {

	 public static int Consecutive(int[] pArr) {
		var arr = pArr.ToList();

		var c = arr.Count();
		arr.Sort();
		var d = arr.Last() - arr.First() + 1;
		//Console.WriteLine( $"{ arr.Last()} {arr.First()}");

		return d - c;

	 }

	 public static void Main() {
		// keep this function call here
		Console.WriteLine(Consecutive(Console.ReadLine().Split(',').Select(s => int.Parse(s)).ToArray()));
	 }

  }

}