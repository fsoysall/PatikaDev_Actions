using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

using static System.Net.Mime.MediaTypeNames;

namespace net5.CoderByte.TransitivityRelations_2 {


	class MainClass {

		public static string TransitivityRelations_2 ( string [ ] strArr ) {
			string ArrList = String.Join( "|", strArr ).Replace( "(", "" ).Replace( ")", "" );
			Console.WriteLine( $"\r\n\r\n{ArrList}" );

			int mSize = strArr [ 0 ].Trim().Split( ',' ).Length;
			var matrix = new int [ mSize, mSize ];
			var needList = "";

			int X = 0; int Y = 0;
			foreach ( string r in ArrList.Split( "|" ) ) {
				foreach ( var c in r.Split( "," ) ) {
					matrix [ X, Y ] = int.Parse( c );
					Y++;
					}
				X++;
				Y = 0;
				}


			for ( X = 0; X < mSize; X++ ) {
				for ( Y = 0; Y < mSize; Y++ ) {

					 Console.Write( $"\r\n{X}:{Y} :: {matrix [ X, Y ]} " );
					
					if ( X != Y && matrix [ X, Y ] == 1 ) {
					
						for ( int Z = 0; Z < mSize; Z++ ) {
						
							Console.Write( $"  ||  {Y}:{Z} :: {matrix [ Y, Z ]} " );
							
							if ( X != Z && Y != Z & matrix [ Y, Z ] == 1 ) {
							
								if ( matrix [ X, Z ] == 0 ) {
								
									Console.Write( $"  || EKSİK->EKLE : ({X}:{Z})" );
									needList += $"({X},{Z})-";

									matrix [ X, Z ] = 1;		// BURASI SONRADAN EKLENENLERİ KONTROL ETMEYE YARIYOR !
																		// SÜRPRİZ BİR TOKAT !!!
									}
								}
							}
						}
					}
				}

			return "\r\n" + ( needList == "" ? "transitive" : needList.TrimEnd( '-' ) );

			}

		public static void Main () {
			// keep this function call here
			Console.WriteLine( TransitivityRelations_2( new string [ ] { "(0,0,0,0)", "(0,0,0,0)", "(0,0,0,0)", "(0,0,0,0)" } ) );
			Console.WriteLine( TransitivityRelations_2( new string [ ] { "(0,1,0,0)", "(0,0,1,0)", "(0,0,1,1)", "(0,0,0,1)" } ) );
			Console.WriteLine( TransitivityRelations_2( new string [ ] { "(1,1,1)", "(0,1,1)", "(0,1,1)" } ) );
			Console.WriteLine( TransitivityRelations_2( new string [ ] { "(1,1,1)", "(1,0,0)", "(0,1,0)" } ) );

			Console.WriteLine( TransitivityRelations_2( new string [ ] { "(1,1,1)", "(0,0,1)", "(0,0,1)" } ) );

			}

		}
	}