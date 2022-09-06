using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace net5.hackerrank.challenges {

	internal class birthday_cake_candles {

		class Result {

			/*
			 * Complete the 'birthdayCakeCandles' function below.
			 *
			 * The function is expected to return an INTEGER.
			 * The function accepts INTEGER_ARRAY candles as parameter.
			 */

			public static long birthdayCakeCandles ( List<long> candles ) {
				var r = candles.GroupBy( g => g ).ToList().Select( s => new { k = s.Key, xC = s.Count() } );
				return r.Max( m => m.xC );
				}

			}

		class Solution {
			public static void Main ( string [ ] args ) {
				TextWriter textWriter = new StreamWriter( "z:\\x.txt", true );

				//long candlesCount = 4; // Convert.ToInt64( Console.ReadLine().Trim() );

				//List<long> candles = Console.ReadLine().TrimEnd().Split( ' ' ).ToList().Select( candlesTemp => Convert.ToInt64( candlesTemp ) ).ToList();
				List<long> candles = "4 4 3 2".TrimEnd().Split( ' ' ).ToList().Select( candlesTemp => Convert.ToInt64( candlesTemp ) ).ToList();

				long result = Result.birthdayCakeCandles( candles );

				textWriter.WriteLine( result );

				textWriter.Flush();
				textWriter.Close();
				}

			}
		
			}
	}


