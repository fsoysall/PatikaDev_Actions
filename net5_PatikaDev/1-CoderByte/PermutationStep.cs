using System;
using System.Linq;
using System.Text;

using static System.Net.Mime.MediaTypeNames;

namespace net5.CoderByte.PermutationStep {



	class MainClass {


		// public static int PermutationStep ( int num ) {

		public static long PermutationStep ( long num ) {
			Console.Write( $"{num} : " );

			if ( num.ToString().Length <= 1 ) { return -1; }
			if ( num < 0 ) { return -1; }


			var sNum = num.ToString().ToArray();
			var result = "";
			bool found = false;

			int i;

			var prev = new char();
			for ( i = sNum.Count() - 1; i > -1; i-- ) {
				var curr = sNum [ i ];
				if ( i > 0 ) { prev = sNum [ i - 1 ]; };

				if ( found == false && char.IsNumber( prev ) && curr > prev ) {
					result = $"{prev}{result}";
					found = true;
					i--;
					}
				//else { result += curr; }
				result += curr;

				}

			
			result = new String( result.Reverse().ToArray() );
			
			var newNum = long.Parse( result );
			if ( newNum == num ) { Console.Write( $" {result}" ); return -1; }
				return newNum;

			}


		public static void Main () {

			// keep this function call here
			//Console.WriteLine( PermutationStep( Console.ReadLine() ) );

			Console.WriteLine( PermutationStep( 897654321 ) );       // 912345678
			Console.WriteLine( PermutationStep( 111 ) );             // -1
			Console.WriteLine( PermutationStep( 12 ) );              // 21
			Console.WriteLine( PermutationStep( 44444444 ) );        // -1
			Console.WriteLine( PermutationStep( 76666666 ) );        // -1
			Console.WriteLine( PermutationStep( 999 ) );
			Console.WriteLine( PermutationStep( 123 ) );
			Console.WriteLine( PermutationStep( 41352 ) );
			Console.WriteLine( PermutationStep( 11121 ) );
			Console.WriteLine( PermutationStep( 0 ) );
			Console.WriteLine( PermutationStep( 8 ) );
			Console.WriteLine( PermutationStep( 12453 ) );
			Console.WriteLine( PermutationStep( 456789 ) );
			Console.WriteLine( PermutationStep( -1 ) );
			}

		}
	}