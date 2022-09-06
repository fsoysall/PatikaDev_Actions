using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace net5.app.patika.dev.courses.csharp_101 {

	internal class _15_odev_2 {
		const int c = 20;

		public void Main() {
			var given = new ArrayList(c);
			int tInt;
			string tmp = "";
			try {
				for (int i = 0; i < given.Count - 1; i++) {
					tmp = Console.ReadLine().Trim();
					if (!int.TryParse(tmp, out tInt)) { Console.WriteLine("geçersiz giriş, sadece pozitif sayılar giriniz."); }
					else { given [i] = tInt; }
					}

				given.Sort();
				given.Reverse();
				foreach (var item in given) { Console.WriteLine($"{item}"); }

				}
			catch (Exception) { throw; }




			}


		}
	}
