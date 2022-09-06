using System;
using System.Linq;
using static System.Convert;

namespace net5.CoderByte.SnakeCase {


  using System;
  using System.Text.RegularExpressions;

  class MainClass {

	 public static string SnakeCase(string str) {
		var r = "";
		foreach(var s in str) {
		  r += char.IsLetterOrDigit(s) ? s.ToString() : "_";
		}
		return r.ToLower();
	 }

	 public static void Main() {
		// keep this function call here
		//Console.WriteLine(SnakeCase(Console.ReadLine()));

		CheckIt("BOB loves-coding"         ,    "bob_loves_coding"         );
		CheckIt("cats AND*Dogs-are Awesome",	 "cats_and_dogs_are_awesome");
		CheckIt("a b c d-e-f%g"            ,	 "a_b_c_d_e_f_g"            );
		CheckIt("apples and oranges"       ,	 "apples_and_oranges"       );
		CheckIt("javaSCRIPT is The-BEST"   ,	 "javascript_is_the_best"   );
		CheckIt("abcdef abcdef"            ,	 "abcdef_abcdef"            );
		CheckIt("a-b-paper-house"          ,	 "a_b_paper_house"          );
		CheckIt("ginger-brea d mAN"        ,	 "ginger_brea_d_man"        );

	 }

	 private static void CheckIt(string v1, string v2) {
		var sc = SnakeCase(v1);
		Console.WriteLine($"{sc == v2,-5} {sc,20} {v2,20} ");
	 }
  }

}