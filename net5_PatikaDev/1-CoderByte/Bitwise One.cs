namespace net5.CoderByte.Bitwise_One {

  using System;
  using System.Linq;


  class MainClass {

	 public static string BitwiseOne(string[] strArr) {


		var r = 0;
		foreach (var c in strArr) {
		  r = r | System.Convert.ToInt32(c, 2);
		}
		return Convert.ToString(r, 2).PadLeft(strArr[0].Length, '0');

	 }

	 public static void Main() {
		// keep this function call here
		//Console.WriteLine(BitwiseOne(Console.ReadLine()));
		Console.WriteLine(BitwiseOne(new string[] { "00011", "01010" }));

	 }

  }




}