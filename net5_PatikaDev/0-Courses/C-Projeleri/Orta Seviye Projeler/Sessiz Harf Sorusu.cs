using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net5.PatikaDev.Courses.C_Projeleri.Orta_Seviye_Projeler {

	internal class Karakter_Değiştirme_Sorusu {

		public static string Hesapla(string pParam, bool ConClear = false) {

			if (ConClear) { Console.Clear(); }

			var r = "";

			var lParam = pParam.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			foreach (var f in lParam) {
				if (f.Length < 2) { r += f; }
				else {
					r += $"{f.Last()}{f.Substring(1,f.Length-2)}{f.First()} ";
					}
				}
			return r;

			}



		public static void Main() {
			//var param = Console.ReadLine();
			var param = "Merhaba Hello Algoritma x";

			Console.WriteLine(param);
			Console.WriteLine(Hesapla(param));

			}



		}

	}
