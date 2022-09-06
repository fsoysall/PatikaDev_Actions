
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
using System.Diagnostics;

namespace net5.hackerrank.challenges {

	namespace breaking_best_and_worst_records {


		class Result {

			/*
			 * Complete the 'breakingRecords' function below.
			 *
			 * The function is expected to return an INTEGER_ARRAY.
			 * The function accepts INTEGER_ARRAY scores as parameter.
			 */

			public static List<int> breakingRecords ( List<int> scores ) {
				int topHigh = scores [ 0 ], topLow = scores [ 0 ];
				int topHighC = 0, topLowC = 0;
				int CurrScore;
				for ( int i = 1; i < scores.Count; i++ ) {
					CurrScore = scores [ i ];
					if ( CurrScore > topHigh ) { topHighC++; topHigh = CurrScore; }
					else if ( CurrScore < topLow ) { topLowC++; topLow = CurrScore; }
					}
				List<int> result = new List<int>();
				result.Add( topHighC );
				result.Add( topLowC );
				return result;

				}

			}

		class Solution {
			public static void Main ( string [ ] args ) {
				// TextWriter textWriter = new StreamWriter( @System.Environment.GetEnvironmentVariable( "OUTPUT_PATH" ), true );

				//int n = Convert.ToInt32( Console.ReadLine().Trim() );
				//List<int> scores = Console.ReadLine().TrimEnd().Split( ' ' ).ToList().Select( scoresTemp => Convert.ToInt32( scoresTemp ) ).ToList();

				List<int> scores;
				List<int> result;
				/* 2 4 */
				scores = "10 5 20 20 4 5 2 25 1".TrimEnd().Split( ' ' ).ToList().Select( scoresTemp => Convert.ToInt32( scoresTemp ) ).ToList();
				result = Result.breakingRecords( scores );
				Debug.Assert( "2 4" == $"{result [ 0 ]} {result [ 1 ]}" );
				Console.Write( $"1: {result [ 0 ]} {result [ 1 ]}" );

				/* 4 0 */
				scores = "3 4 21 36 10 28 35 5 24 42".TrimEnd().Split( ' ' ).ToList().Select( scoresTemp => Convert.ToInt32( scoresTemp ) ).ToList();
				result = Result.breakingRecords( scores );
				Debug.Assert( "4 0" == $"{result [ 0 ]} {result [ 1 ]}" );
				Console.Write( $"2: {result [ 0 ]} {result [ 1 ]}" );

				// textWriter.WriteLine( String.Join( " ", result ) );
				// 
				// textWriter.Flush();
				// textWriter.Close();
				}
			}


		}
	}
