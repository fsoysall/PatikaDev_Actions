using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net5.PatikaDev.Courses.C_Projeleri.Kolay_Seviye_Projeler {

	// https://app.patika.dev/courses/c-projeleri/daire-cizme

	internal static class Üçgen_Çizimi_Sorusu {

		public static string Üçgen_Çiz(int pBoy, bool ConClear = false) {

			if (ConClear) { Console.Clear(); }

			//Console.Clear();

			int cw = Console.WindowWidth;
			int cw2 = cw / 2;
			bool TekMi = cw2 % 2 == 1;
			//if (TekMi) { cw2--; }


			string line = "";
			line = "*".PadLeft(cw2);
			Console.WriteLine(line);

			for (int i = 2; i < pBoy; i++) {
				//           cw/2
				// pad-Left    *    pad-Right
				// pad-Left   * *   pad-Right
				// pad-Left  *   *  pad-Right
				// pad-Left ******* pad-Right

				line = "*".PadRight(i) + $"{i}" + "*".PadLeft(i);
				line = line.PadLeft(cw2 + line.Length / 2);
				Console.WriteLine(line); Debug.WriteLine(line);
				}
			line = new string('*', (pBoy * 2) + (TekMi ? -1 : 0)).PadLeft(cw2 + pBoy + (TekMi ? -1 : 0));
			Console.WriteLine(line); Debug.WriteLine(line);
			Console.WriteLine(""); Debug.WriteLine("");
			return "";
			}

		public static void Main() {
			Console.WriteLine($"2  : {Üçgen_Çiz(12, true)}");
			Console.WriteLine($"2  : {Üçgen_Çiz(2)}");
			Console.WriteLine($"5  : {Üçgen_Çiz(5)}");
			//Console.WriteLine($"34 : {Üçgen_Çiz(34)}");
			}



		}

	}
