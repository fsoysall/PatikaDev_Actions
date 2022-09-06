using System;
using System.Linq;

using static FSYS.MyAddons;



namespace net5.CoderByte {
	namespace HappyNumbers2 {


		public static class program {

			public static void main() {
				logL(IsHappyNumber(130));
				logL(IsHappyNumber(97));
				logL(IsHappyNumber(94));
				logL(IsHappyNumber(7));
				logL(IsHappyNumber(1));
				logL(IsHappyNumber(8));
				logL(IsHappyNumber(11));
				logL(IsHappyNumber(49));

				}

			private static bool IsHappyNumber(int num) {
				log($"is: {num,3} ");

				int d1 = 0; int sum = 0;

				while (num > 0) {
					d1 = num % 10;
					sum += d1 * d1;
					num = num / 10;
					}

				log($" {sum,3}  {sum == 1} ");

				return sum == 1;

				}


			}
		}
	}
