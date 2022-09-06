using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using net5;

namespace net5 {

	class Calculator {

		public Calculator () { }

		public int power ( int n, int p ) {
			if ( n < 0 || p < 0 ) { Console.WriteLine( "n and p should be non-negative." ); return 0; }
			return ( int )Math.Pow( n, p );
			}


		public T PrintArray<T> ( params T [ ] param ) {
			return param.First();
			}

		}



	class Solution {
		static void Main ( String [ ] args ) {
			Calculator myCalculator = new Calculator();
			int T = Int32.Parse( Console.ReadLine() );
			while ( T-- > 0 ) {
				string [ ] num = Console.ReadLine().Split();
				int n = int.Parse( num [ 0 ] );
				int p = int.Parse( num [ 1 ] );
				try {
					int ans = myCalculator.power( n, p );
					Console.WriteLine( ans );
					}
				catch ( Exception e ) {
					Console.WriteLine( e.Message );

					}
				}



			}
		}
	}
