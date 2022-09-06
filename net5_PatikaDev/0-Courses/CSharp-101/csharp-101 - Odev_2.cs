using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace net5.PatikaDev.Courses.CSharp_101 {

	internal class Odev_2 {

		public static void Main() {
			Soru_3();
			Console.WriteLine("");
			Console.WriteLine("");

			Soru_1();
			Console.WriteLine("");
			Console.WriteLine("");
			
			Soru_2();

			}

		public static void Soru_1() {

			var alloweds = "0123456789".ToCharArray().ToList();
			var Numaralar = new List<Int32>();


			for (int i = 0; i < 5; i++) {
			giriş:
				Console.Write($"{i + 1}./20 Sayı Giriniz: ");
				var n = Console.ReadLine().Trim();
				var na = n.Except(alloweds).ToList();
				if (na.Count > 0 || n.Length == 0) {
					Console.WriteLine($"geçersiz giriş: {string.Join(", ", na)}");
					goto giriş;
					}
				Numaralar.Add(Int32.Parse(n));
				Console.WriteLine($"   Sayı : {n} \r\n");

				}
			Console.WriteLine("");

			var Asallar = new List<Int32>();
			var NaAsallar = new List<Int32>();

			foreach (var n in Numaralar) {
				if (FSYS9.PrimeNumber_Checker.AsalMı(n)) { Asallar.Add(n); }
				else { NaAsallar.Add(n); }
				}

			Console.WriteLine($"Asallar: {string.Join(", ", Asallar.OrderByDescending(o => o))}");
			Console.WriteLine($"Asal Olmayanlar: {string.Join(", ", NaAsallar.OrderByDescending(o => o))}");

			Console.WriteLine($"Ortalama (Asal)        : {Asallar.Count}   / {Asallar.Average()} ");
			Console.WriteLine($"Ortalama (Asal Olmayan): {NaAsallar.Count} / {NaAsallar.Average()} ");
			Console.WriteLine("");
			Console.WriteLine("");

			}


		public static void Soru_2() {

			Console.Write($"20 Sayı Giriniz: ");
			var Numaralar = Console.ReadLine().Trim().Split(" ").Select(s => int.Parse(s)).ToList();
			Numaralar.Sort();

			var EB3 = Numaralar.TakeLast(3);
			var EK3 = Numaralar.Take(3);

			Console.WriteLine($"Ortalamalar; EB:{EB3.Average()} / EK3:{EK3.Average()}");
			Console.WriteLine($"Ortalama Toplamları: {EB3.Average() + EK3.Average()}  ");

			}



		public static void Soru_3() {

			Console.Write($"Bir CÜMLE YAZINIZ : ");

			var Sesliler = "aeıioöuü".ToCharArray();
			var Cümle = Console.ReadLine().Trim();
			var Cümle2 = Cümle.ToCharArray();

			var Sonuç = Cümle2.Where(s => Sesliler.Contains(s)).Distinct().ToList();
			Sonuç.Sort();
			Console.WriteLine($"{string.Join(" ", Sonuç)}");

			}
		}


	}
