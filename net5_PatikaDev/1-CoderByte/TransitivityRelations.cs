using System;
using System.Linq;



namespace net5.CoderByte.TransitivityRelations {


	class MainClass {

		public static string TransitivityRelations ( string [ ] strArr ) {


			return strArr [ 0 ];

			}

		public static void Main () {
			// keep this function call here
			Console.WriteLine( TransitivityRelations( new string [ ] { "(1,1,1)", "(0,1,1)", "(0,1,1)" } ) );
			}

		}
	}