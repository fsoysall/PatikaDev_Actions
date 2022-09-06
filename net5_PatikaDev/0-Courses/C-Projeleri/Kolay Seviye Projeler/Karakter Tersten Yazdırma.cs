using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net5.PatikaDev.Courses.C_Projeleri.Kolay_Seviye_Projeler {

	// https://app.patika.dev/courses/c-projeleri/karakter

	internal static class Karakter_Tersten_Yazdırma_Sorusu {

		public static string Karakter_Tersten(string pParam, bool ConClear = false) {

			if (ConClear) { Console.Clear(); }

			var r = "";

			var lParam = pParam.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			foreach (var f in lParam) {
				//r += String.Join("", f.Reverse()) + " ";
				r += $"{f.Substring(1)}{f.First() } ";
				}
			return r;

			}


		public static void Main() {
			//var param = Console.ReadLine();
			var param = "Merhaba Hello Question";
			Console.WriteLine(param);
			Console.WriteLine(Karakter_Tersten(param));
			}



		}

	}
