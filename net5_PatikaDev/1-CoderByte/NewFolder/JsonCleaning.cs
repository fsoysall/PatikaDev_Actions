using System;
using System.IO;
using System.Net;
using System.Collections;
using System.Linq;

namespace net5.CoderByte.JsonCleaning {

	using System.Collections.Generic;
	using System.Diagnostics;
	using System.Diagnostics.CodeAnalysis;
	using System.Reflection.Metadata;
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

			Console.WriteLine($"{CheckKV(rsStr.Substring(1, rsStr.Length - 2))}");

			}

		internal static string CheckKV(string pJStr) {
			var result = "";
			var lookUp = new List<string> { "N/A", "N\\/A",  "\"-\"", ":\"\"" };

			var val = "";
			var key = pJStr.Trim()
						.Replace("\":[\""	, "\":\r[\r\"")
						.Replace(",\""		, "\r,\r\"")
						.Replace("\":{"	, "\":\r{\r")
						.Replace("\"},"	, "\"\r}\r,\r")
						.Replace("\":{\""	, "\":\r{\r\"")
						.Replace("\":["	, "\":\r[\r")
						.Replace("],\""	, "\r]\r,\r\"")
						.Replace("\"]"	, "\"\r]\r")
						;
			foreach(var k in key.Split('\r')) {
				var found = false;
				foreach(var l in lookUp) {
					if (k.Contains(l)) { found = true; };
					}
				if (!found) { val+= k+"\r"; }
				}
			result= val.Replace("\r,\r,", "\r,").Replace("\r \r,", "\r,").Replace("\r\r,", "\r,")
				.Replace("\r","")
				.Replace(",]", "]").Replace(",}", "}")
				.Replace("[,", "[").Replace("{,", "{");
			Debug.Print(result);



			//.Replace("],", "]\r\n,").Replace("},", "}\r\n,").Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
			//var tmp = "";
			//var result = "";

			return result;

			}
		}
	}

