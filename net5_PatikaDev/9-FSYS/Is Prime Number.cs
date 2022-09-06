using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace net5.FSYS9 {

	public static class PrimeNumber_Checker {

		public static bool AsalMı(int n) => Is_PrimeNumber(n);

		public static bool Is_PrimeNumber(int n) {
			if (n < 4) { return true; }
			if ((n & 1) == 0) { return false; }

			for (var k = 2; k < n; k++) {
				if ((n & 1) == 0) { return false; }

				var t = n % k;
				if (t == 0) { return false; }

				}

			return true;

			}

		internal static void Main() {
			var pList = new List<int>();
			for (var i = 4; i < 123; i++) {
				var p = Is_PrimeNumber(i);
				if (p) {
					Console.WriteLine($"{i}: {p} ");
					pList.Add(i);
					}
				}
			Console.WriteLine(String.Join(", ", pList));
			}
		}

	}
