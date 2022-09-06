using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net5.PatikaDev.Courses.C_Projeleri.Orta_Seviye_Projeler {

	internal class Mutlak_Kare_Alma {

		public static string Hesapla(string pParam) {
			var rT = 0;
			var rK = 0;

			var list = pParam.Split(' ');
			foreach (var f in list) {
				var a = int.Parse(f);
				if (a < 67) { rT += 67 - a; }
				else if (a > 67) { rK += (a - 67) * (a - 67); }

				}
			return $"{rT} {rK}";
			}



		public static void Main() {
			//var param = Console.ReadLine();
			var param = "56 45 68 77";

			Console.WriteLine(param);
			Console.WriteLine(Hesapla(param));

			}



		}

	}
