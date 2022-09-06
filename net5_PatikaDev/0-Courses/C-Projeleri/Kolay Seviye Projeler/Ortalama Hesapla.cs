using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using net5.PatikaDev.CoderByte;

namespace net5.PatikaDev.Courses.C_Projeleri.Kolay_Seviye_Projeler {

	// https://app.patika.dev/courses/c-projeleri/ortalama-hesaplama

	internal static class Ortalama_Hesapla_Sorusu {

		internal static bool IsFibonacci(int num, bool ConLog = false) {
			if (num >= 0 && num < 4) { return true; }

			int sum = 0, a = 2, b = 3;

			while (b < num) {
				sum = a + b; if (ConLog) { Console.Write($"{sum} "); }
				a = b;
				b = sum;
				if (sum == num) { return true; }
				}
			return false;
			}


		public static void Main() {
			Console.WriteLine($"2  : {IsFibonacci(2)}");
			Console.WriteLine($"5  : {IsFibonacci(5)}");
			Console.WriteLine($"34 : {IsFibonacci(34)}");
			Console.WriteLine($"54 : {IsFibonacci(54)}");
			Console.WriteLine($"54 : {IsFibonacci(1024, true)}");
			}

		}

	}
