using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net5.PatikaDev.Courses.C_Projeleri.Kolay_Seviye_Projeler {

	// https://app.patika.dev/courses/c-projeleri/ucgen-cizme

	internal static class Daire_Çizimi_Sorusu {

		public static string Daire_Çiz(int pYÇap, bool ConClear = false) {

			if (ConClear) { Console.Clear(); }

			int cw = Console.WindowWidth;
			int cw2 = cw / 2;
			bool TekMi = cw2 % 2 == 1;
			//if (TekMi) { cw2--; }


			//           r:5
			//             *
			//            ***
			//           *****
			//          *******
			//         *********
			//          *******
			//           *****
			//            ***
			//             *

			string line = "";

			for (int i = 1; i < pYÇap; i++) {
				line = new string((i % 10).ToString() [0], (i * 2) - 1);
				line = line.PadLeft(cw2 + i);
				Console.WriteLine(line); Debug.WriteLine(line);
				}
			for (int i = pYÇap ; i > 0; i--) {
				line = new string((i % 10).ToString() [0], (i * 2) - 1);
				line = line.PadLeft(cw2 + i);
				Console.WriteLine(line); Debug.WriteLine(line);
				}

			return "";
			}

		public static void Main() {
			Console.WriteLine($"5  : {Daire_Çiz(5, true)}");
			Console.WriteLine($"12  : {Daire_Çiz(12)}");
			Console.WriteLine($"34 : {Daire_Çiz(34)}");
			}

		}

	}
