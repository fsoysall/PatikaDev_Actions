using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net5.PatikaDev.Courses.C_Projeleri.Orta_Seviye_Projeler {

	internal class Sessiz_Harf_Sorusu {

		public static string SessizHarf(string pParam, bool ConClear = false) {

			if (ConClear) { Console.Clear(); }

			var r = "";

			var sesliler = "aeıioöuü";

			var list = pParam.ToLower().Split(' ');
			foreach (var f in list) {
				var found = false;
				for (var i = 0; i < f.Length - 1; i++) {
					if (!sesliler.Contains(f [i]) && !sesliler.Contains(f [i + 1])) { found = true; }
					}
				r += found ? "true " : "false ";
				}

			return r;

			}



		public static void Main() {
			//var param = Console.ReadLine();
			var param = "Merhaba Umut Arya";

			Console.WriteLine(param);
			Console.WriteLine(SessizHarf(param));

			}



		}

	}
