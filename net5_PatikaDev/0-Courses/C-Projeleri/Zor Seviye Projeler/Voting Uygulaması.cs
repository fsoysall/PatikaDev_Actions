using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net5.PatikaDev.Courses.C_Projeleri.Zor_Seviye_Projeler {

	internal class Voting_Uygulaması_Sorusu {

		public class Oy {
			public string Kullanıcı { get; set; }
			public eKategori Kategori { get; set; }
			//public int Değer { get; set; }
			}

		public class Üye {
			public string Kullanıcı { get; set; }
			//public string Parola { get; set; }
			//public bool AktifMi { get; set; }
			}

		public class İstatislik {
			public eKategori Kategori { get; set; }
			public decimal OySayısı { get; set; }
			public decimal OyOranı { get; set; }

			}

		public enum eKategori { Film, Tech, Spor }

		internal static List<Üye> Üyeler = new List<Üye>();
		internal static List<Oy> Oylar = new List<Oy>();
		internal static List<İstatislik> İstatislikler = new List<İstatislik>();

		public static string OyKullan(Üye pÜye, eKategori pKategori/*, int Oy*/) {
			if (!Üyeler.Contains(pÜye)) {
				if (!ÜyeYap(pÜye)) { throw new Exception("Üye Yapılamadı"); }
				}
			var oy = new Oy { /*Değer = Oy,*/ Kullanıcı = pÜye.Kullanıcı, Kategori = pKategori };
			Oylar.Add(oy);

			var r1 = Oylar.GroupBy(g => g.Kategori)
													.OrderBy(o => o.Key)
													.Select(s => new İstatislik { Kategori = s.Key, OySayısı = s.Count(), OyOranı = new decimal(0) })
													.ToList();
			var r = "";
			var r1_OySayısı = r1.Sum(s => s.OySayısı);
			for (var i = 0; i < r1.Count(); i++) {
				var q = r1 [i];
				q.OyOranı = q.OySayısı / r1_OySayısı;
				r += $"{q.Kategori}: {q.OySayısı} %:{q.OyOranı*100:0} \r\n";
				}

			r += "\r\n";
			return r;

			}

		private static bool ÜyeYap(Üye pÜye) {
			Üyeler.Add(new Üye() { Kullanıcı = pÜye.Kullanıcı });
			return true;
			}

		public static void Main() {

			Üyeler.AddRange(new List<Üye> { new Üye() { Kullanıcı = "q" },
													  new Üye() { Kullanıcı = "a" },
													  new Üye() { Kullanıcı = "s" },
													  new Üye() { Kullanıcı = "d" } });


			Console.WriteLine(OyKullan(Üyeler [0], eKategori.Film));
			Console.WriteLine(OyKullan(Üyeler [0], eKategori.Tech));
			Console.WriteLine(OyKullan(Üyeler [0], eKategori.Spor));
			Console.WriteLine(OyKullan(Üyeler [1], eKategori.Film));
			Console.WriteLine(OyKullan(Üyeler [1], eKategori.Spor));
			Console.WriteLine(OyKullan(Üyeler [3], eKategori.Film));

			}



		}

	}
