using System;
using System.IO;
using System.Net;
using System.Collections;
using System.Linq;

namespace net5.CoderByte.JsonCleaning2 {

	using System.Collections.Generic;
	using System.Security.Cryptography;

	using static System.Net.Mime.MediaTypeNames;

	class MainClass {

		public static void Main() {

			// WebRequest request = WebRequest.Create("https://coderbyte.com/api/challenges/json/json-cleaning");
			// WebResponse rs = request.GetResponse();
			// 
			// var sr = new System.IO.StreamReader(rs.GetResponseStream());
			// var rsStr = sr.ReadToEnd();
			// Console.WriteLine(rsStr);
			// rs.Close();
			var rsStr = "{\"name\":{\"first\":\"Robert\",\"middle\":\"\",\"last\":\"Smith\"},\"age\":25,\"DOB\":\"-\",\"hobbies\":[\"running\",\"coding\",\"-\"],\"education\":{\"highschool\":\"N\\/A\",\"college\":\"Yale\"}}";



			var lookUp = new List<string>();
			lookUp.Add("N/A");
			lookUp.Add("N\\/A");
			lookUp.Add("-");
			lookUp.Add("\"-\"");
			lookUp.Add("");

			var q = rsStr.Replace("],", "]\r\n,").Replace("},", "}\r\n,").Trim('{').Trim('}').Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
			var tmp = "";
			var result = "";


			foreach (var s in q) {
				var s2 = s.Split(":{", StringSplitOptions.RemoveEmptyEntries);
				if (s2.Length == 1) { result += s; }
				else if (s2.Length == 2) {
					tmp = "";
					var s3 = s2 [1].Trim('{').Trim('}').Replace("\",", "\",\r\n").Split(",\r\n", StringSplitOptions.RemoveEmptyEntries);
					foreach (var s4 in s3) {
						var s5 = s4.Split("\":\"");
						if (s5.Length == 1 && s5 [0].Length > 0) { tmp += s + ","; }
						else if (s5.Length == 2 && !lookUp.Contains(s5 [1].Trim('\"'))) { tmp += s4 + ","; }
						else { }//Console.WriteLine(s4); }
						}
					result += $"{s2 [0]}:{{{tmp.TrimEnd(',')}}}";

					}
				// Console.WriteLine($"{result}");
				}
			Console.WriteLine($"\r\n\r\n{result}");

			}
		}
	}

