using System;
using System.Linq;

using System.Collections;
using System.Collections.Generic;
using static FSYS.MyAddons;


namespace net5.CoderByte {

	namespace HappyNumbers {


		class MainClass {

			static int GetSumS(int num) {
				var digits = num.ToString().ToCharArray()
					.Select(s => int.Parse(s.ToString()))
					;
				return digits.Sum(s => s * s);
				}

			public static bool HappyNumbers(int num) {

				var Sums = GetSumS(num);
				while (/* Sums.ToString().Length > 1 &&  */ Sums != 1 && Sums > 9) {
					Sums = GetSumS(Sums);
					}
				logl($"HN: {num,5} {Sums,5} {Sums==1} ");
				return Sums == 1;

				}

			public static void Main() {
				// keep this function call here
				// Console.WriteLine(HappyNumbers(Console.ReadLine()));
				Console.Clear();
				/* Console.WriteLine ( */ HappyNumbers(101)  /* ) */;
				/* Console.WriteLine ( */ HappyNumbers(5525) /* ) */;
				/* Console.WriteLine ( */ HappyNumbers(5255) /* ) */;
				/* Console.WriteLine ( */ HappyNumbers(2555) /* ) */;
				/* Console.WriteLine ( */ HappyNumbers(5552) /* ) */;
				/* Console.WriteLine ( */ HappyNumbers(1)    /* ) */;
				/* Console.WriteLine ( */ HappyNumbers(7)    /* ) */;
				/* Console.WriteLine ( */ HappyNumbers(13)   /* ) */;
				/* Console.WriteLine ( */ HappyNumbers(368)  /* ) */;
				/* Console.WriteLine ( */ HappyNumbers(94)   /* ) */;
				/* Console.WriteLine ( */ HappyNumbers(81)   /* ) */;
				/* Console.WriteLine ( */ HappyNumbers(130)  /* ) */;
				}

			}
		}
	}