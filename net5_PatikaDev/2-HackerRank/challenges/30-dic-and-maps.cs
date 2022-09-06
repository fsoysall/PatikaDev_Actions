using System;
using System.Collections.Generic;
using System.IO;


namespace net5.hackerrank.challenges {

  public class Solution__30_dic_and_maps {

	 public static void Main(string[] args) {
		/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

		var c = int.Parse(Console.ReadLine());
		var phones = new Dictionary<string, string>();

		for (int i = 0; i < c; i++) {
		  var user = Console.ReadLine().Trim().Split();
		  phones.Add(user[0], user[1]);
		}

		string[] query = new string[c];
		for (int i = 0; i < c; i++) {
		  query[i] = Console.ReadLine();
		}

		for (int i = 0; i < c; i++) {
		  if (!phones.ContainsKey(query[i])) { Console.WriteLine($"Not found"); }
		  else { Console.WriteLine($"{query[i]}={phones[query[i]]}"); }
		}
	 }

  }

}
