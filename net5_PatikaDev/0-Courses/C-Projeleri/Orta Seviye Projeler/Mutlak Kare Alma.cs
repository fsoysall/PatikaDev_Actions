using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net5.PatikaDev.Courses.C_Projeleri.Orta_Seviye_Projeler {

	internal class Integer_İkililerin_Toplamı_Sorusu {

		public static string Hesapla(string pParam) {
			var list = pParam.Split(' ');
			var r = "";

			for (var i = 0; i < list.Length; i = i + 2) {
				var a = long.Parse(list [i]);
				var b = long.Parse(list [i + 1]);
				if (a == b) { r += $"{a * a * a * a} "; }
				else { r += $"{a + b} "; }
				}
			return r;
			}



		public static void Main() {
			//var param = Console.ReadLine();
			var param = "2 3 1 5 2 5 3 3";

			Console.WriteLine(param);
			Console.WriteLine(Hesapla(param));

			}



		}

	}
