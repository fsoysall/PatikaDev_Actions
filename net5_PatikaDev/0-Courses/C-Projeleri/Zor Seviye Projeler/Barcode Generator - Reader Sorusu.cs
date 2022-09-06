using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using BarcodeLib;

namespace net5.PatikaDev.Courses.C_Projeleri.Zor_Seviye_Projeler {

	internal class Barcode_Generator_Reader_Sorusu {

		public void Main() {

			var bilgi = "";

			BarcodeLib.Barcode b = new BarcodeLib.Barcode();
			var brk = string.Join("", DateTime.Now.ToString("yyMMddHHmmss").Take(12));
			var AppDizini = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
			var DosyaAdı = $"{AppDizini}\\barcode-{brk}.png";

			Image img = b.Encode(BarcodeLib.TYPE.UPCA, brk, Color.Black, Color.White, 290, 120);
			b.SaveImage(DosyaAdı, BarcodeLib.SaveTypes.PNG);

			bilgi = $"{brk} Kodlu Barkod {DosyaAdı} ile Kaydedildi.";


			Process.Start("explorer.exe", AppDizini);

			Console.WriteLine(bilgi);

			}



		}

	}
