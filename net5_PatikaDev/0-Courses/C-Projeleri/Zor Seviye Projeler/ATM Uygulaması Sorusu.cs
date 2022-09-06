using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Encodings.Web;

namespace net5.PatikaDev.Courses.C_Projeleri.Zor_Seviye_Projeler {

	internal class ATM_Uygulaması_Sorusu {


		class Üye {
			public string Kullanıcı { get; set; }
			public string Parola { get; set; }
			public bool AktifMi { get; set; }
			public int HatalıŞifre { get; set; } = 0;
			}

		class Atmİşlem {
			public DateTime Tarih { get; set; }
			public Üye Kullanıcı { get; set; }
			public eİşlem İşlem { get; set; }
			public string Operand { get; set; } // json tipli tümleç / operand
			public bool Hata { get; set; }
			}

		enum eİşlem { Para_Çekim, Para_Yatırma, ÖdemeyeYapış };

		const string DosyaAdıDeseni = "EOD_#Tarih#.txt";
		string LogDosyası() => DosyaAdıDeseni.Replace("#Tarih#", DateTime.Now.ToString("ddMMyyy"));

		List<Üye> Üyeler = new List<Üye>();
		List<Atmİşlem> İşlemler = new List<Atmİşlem>();


		bool ÜyeYap(Üye pÜye) { Üyeler.Add(new Üye() { Kullanıcı = pÜye.Kullanıcı }); return true; }
		bool ÜyeKontrol(Üye pÜye) => Üyeler.FirstOrDefault(w => w.Kullanıcı == pÜye.Kullanıcı && w.Parola == pÜye.Parola) != null;

		bool Atmİşlemi(Üye pÜye, eİşlem pİşlem, string pOperand) {
			if (!ÜyeKontrol(pÜye)) { throw new UnauthorizedAccessException($"Bilinmeyen Üye: {pÜye.Kullanıcı}"); }
			bool hata = DateTime.Now.Millisecond % 2 == 0 ? true : false;
			İşlemler.Add(new Atmİşlem { Kullanıcı = pÜye, Tarih = DateTime.Now, İşlem = pİşlem, Operand = pOperand, Hata = hata });
			return !hata;
			}

		string GünSonu() {
			var frauds = İşlemler.Where(w => w.Hata == true).ToList();
			if (frauds == null) { return ""; }
			
			var data = JsonSerializer.Serialize(frauds, new JsonSerializerOptions() { WriteIndented = true}).ToString();
			File.WriteAllText(LogDosyası(), data);
			return data;
			}

		public void Main() {

			Üyeler.AddRange(new List<Üye> { new Üye() { Kullanıcı = "q" },
													  new Üye() { Kullanıcı = "a" },
													  new Üye() { Kullanıcı = "s" },
													  new Üye() { Kullanıcı = "d" } });


			Console.WriteLine(Atmİşlemi(Üyeler [0], eİşlem.Para_Yatırma, "{'hesap':'1. hesap'    ,'meblağ':'123.45'}"));
			Console.WriteLine(Atmİşlemi(Üyeler [0], eİşlem.Para_Çekim, "{'hesap':'1. hesap'    ,'meblağ':'23.45' }"));
			Console.WriteLine(Atmİşlemi(Üyeler [1], eİşlem.Para_Yatırma, "{'hesap':'2. hesap'    ,'meblağ':'234.56'}"));
			Console.WriteLine(Atmİşlemi(Üyeler [1], eİşlem.Para_Çekim, "{'hesap':'2. hesap'    ,'meblağ':'34.56' }"));
			Console.WriteLine(Atmİşlemi(Üyeler [0], eİşlem.ÖdemeyeYapış, "{'firma':'qwe elektrik','meblağ':'10'    }"));
			Console.WriteLine(Atmİşlemi(Üyeler [3], eİşlem.ÖdemeyeYapış, "{'firma':'qwe elektrik','meblağ':'12.45' }"));

			Console.WriteLine(GünSonu());

			}



		}

	}
