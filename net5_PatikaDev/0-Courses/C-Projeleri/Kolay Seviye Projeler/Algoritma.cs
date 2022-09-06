using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net5.PatikaDev.Courses.C_Projeleri.Kolay_Seviye_Projeler {

	// https://app.patika.dev/courses/c-projeleri/string-ve-sayi-alan

	internal static class Algoritma_Sorusu {

		public static string Algoritma(string pParam, bool ConClear = false) {

			if (ConClear) { Console.Clear(); }

			var r = "";

			var lParam = pParam.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			foreach (var f in lParam) {
				if (f.Length > 0) {
					var f2 = f.Split(',');
					var f20 = f2 [0].ToString();
					var f21 = int.Parse(f2 [1]);
					if (f21 >= f20.Length) {
						r += f20 + " ";
						}
					else {
						r += f20.Substring(0, f21) + f20.Substring(f21+1) + " ";
						}
					}
				}
			return r;

			}


		public static void Main() {
			//var param = Console.ReadLine();
			var param = "Algoritma,3 Algoritma,5 Algoritma,22 Algoritma,0 Algoritma,9";
			Console.WriteLine(param);
			Console.WriteLine(Algoritma(param));
			}



		}

	}
