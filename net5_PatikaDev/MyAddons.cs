using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSYS {

	public static class MyAddons {

		public static void logl(object what) { logL(what.ToString()); }
		public static void logL(object what) { Console.WriteLine(what.ToString()); }
		public static void log(object what) { Console.Write(what.ToString()); }

		}
	}
