using System.Linq;

using System.Collections;
using System.Collections.Generic;

using System;


using static FSYS.MyAddons;

namespace net5.CoderByte.TripleDouble {

	public class MainClass {

		public static string find3ple(long num1) {
			if (num1 < 100) { return ""; }

			var triple = "";
			var s1 = $"{num1}|".ToCharArray();
			//if (s1.Length < 3+1) { return ""; }

			for (int i = 0; i < s1.Length - 1; i++) {
				if (s1 [i] == s1 [i + 1]) {
					if (triple.Length == 0) { triple = $"{s1 [i]}{s1 [i+1]}"; }
					else {
						if (triple [0] == s1 [i+1]) { triple += s1 [i+1]; }
						else { triple = $"{s1 [i]}{s1 [i+1]}"; }
						}
					if(triple.Length==3) { break; }
					}
				}
			log($"f3: {num1,10} {triple,10} ");
			return triple;
			}

		public static int TripleDouble(long num1, long num2) {

			if (num1 < 100 || num2 < 10) {
				log($"TD: {num1,15} {num2,15} {0} ");
				return 0;
				}

			var r = find3ple(num1);
			if (r.Length < 3) { return 0; }

			var tween = r.Substring(0, 2);
			log($"TD: {num1,15} {num2,15} {num2.ToString().Contains(tween)} ");
			if (num2.ToString().Contains(tween)) { return 1; }
			return 0;

			}

		public static void Main() {
			// keep this function call here
			Console.WriteLine(TripleDouble(451999277, 41177722899));
			Console.WriteLine(TripleDouble(8, 8));
			Console.WriteLine(TripleDouble(465555, 5579));
			Console.WriteLine(TripleDouble(67844, 66237));
			Console.WriteLine(TripleDouble(1234, 1234));
			Console.WriteLine(TripleDouble(333, 33));
			Console.WriteLine(TripleDouble(556668, 556886));
			Console.WriteLine(TripleDouble(17555, 55144));
			Console.WriteLine(TripleDouble(800000006, 7800));
			}

		}
	}