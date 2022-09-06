using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net5.PatikaDev.Courses.C_Projeleri.Orta_Seviye_Projeler {

	internal class Alan_Hesaplama_Sorusu {

		public enum eŞekil { Daire, Üçgen, Kare, DikDörtgen }
		public enum eİşlem { Çevre, Alan, Hacim }

		public static decimal Hesapla(eŞekil pŞekil, eİşlem pİşlem,
			decimal p1, decimal p2 = 0, decimal p3 = 0, decimal p4 = 0) {

			switch (pİşlem) {
				case eİşlem.Çevre: return Çevre_Hesapla(pŞekil, p1, p2, p3, p4);
				case eİşlem.Alan: return Alan_Hesapla(pŞekil, p1, p2, p3, p4);
				case eİşlem.Hacim: return Hacim_Hesapla(pŞekil, p1, p2, p3, p4);
				}
			return 0;
			}

		public static decimal Çevre_Hesapla(eŞekil pŞekil, decimal p1, decimal p2 = 0, decimal p3 = 0, decimal p4 = 0) {
			switch (pŞekil) {
				case eŞekil.Daire: return (decimal)(2 * 3.14) * p1;
				case eŞekil.Üçgen: return p1 + p3 + p3;
				case eŞekil.Kare: return p1 * 4;
				case eŞekil.DikDörtgen: return (p1 + p2) * 2;
				default: throw new ArgumentOutOfRangeException($"{pŞekil} :: Bilinmeyen Seçenek");
				}
			}

		public static decimal Alan_Hesapla(eŞekil pŞekil, decimal p1, decimal p2 = 0, decimal p3 = 0, decimal p4 = 0) {
			switch (pŞekil) {
				case eŞekil.Daire: return (decimal)3.14 * p1 * p1;
				case eŞekil.Üçgen: return p1 * p2 / 2;
				case eŞekil.Kare: return p1 * p1;
				case eŞekil.DikDörtgen: return p1 * p2;
				default: throw new ArgumentOutOfRangeException($"{pŞekil} :: Bilinmeyen Seçenek");
				}

			}

		public static decimal Hacim_Hesapla(eŞekil pŞekil, decimal p1, decimal p2 = 0, decimal p3 = 0, decimal p4 = 0) {
			switch (pŞekil) {
				//silindir case eŞekil.Daire: return (decimal)3.14 * p1 * p1 * p1 * 4 / 3;
				case eŞekil.Daire: return (decimal)3.14 * p1 * p1 * p2;
				case eŞekil.Üçgen: return p1 * p2 * p3 / 3;
				case eŞekil.Kare: return p1 * p1 * p1;
				case eŞekil.DikDörtgen: return p1 * p2 * p3;
				default: throw new ArgumentOutOfRangeException($"{pŞekil} :: Bilinmeyen Seçenek");
				}

			}



		public static void Main() {
			Console.WriteLine(Hesapla(eŞekil.Kare, eİşlem.Çevre, 10));
			Console.WriteLine(Hesapla(eŞekil.Kare, eİşlem.Alan, 10));
			Console.WriteLine(Hesapla(eŞekil.Kare, eİşlem.Hacim, 10, 10));
			
			Console.WriteLine();

			Console.WriteLine(Hesapla(eŞekil.Üçgen, eİşlem.Çevre, 10,15,20));
			Console.WriteLine(Hesapla(eŞekil.Üçgen, eİşlem.Alan, 10,15,20));
			Console.WriteLine(Hesapla(eŞekil.Üçgen, eİşlem.Hacim, 10, 15,20));

			Console.WriteLine();
			
			Console.WriteLine(Hesapla(eŞekil.Daire, eİşlem.Çevre, 10));
			Console.WriteLine(Hesapla(eŞekil.Daire, eİşlem.Alan, 10));
			Console.WriteLine(Hesapla(eŞekil.Daire, eİşlem.Hacim, 10, 10));

			Console.WriteLine();
			
			Console.WriteLine(Hesapla(eŞekil.DikDörtgen, eİşlem.Çevre, 10,15));
			Console.WriteLine(Hesapla(eŞekil.DikDörtgen, eİşlem.Alan, 10,15));
			Console.WriteLine(Hesapla(eŞekil.DikDörtgen, eİşlem.Hacim, 10, 15,25));

			}



		}

	}
