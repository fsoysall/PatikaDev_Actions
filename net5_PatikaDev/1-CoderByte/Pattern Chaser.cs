using System;
using System.Linq;

using System.Collections;
using System.Collections.Generic;



using static FSYS.MyAddons;
using System.Diagnostics;

namespace net5.CoderByte.PatternChaser {


	class MainClass {

		public static string lookPatterns4(string src) {
			var sLen = src.Length;
			var r = new List<string> { };
			if (sLen < 3) { return ""; }

			var pSrc = $"{src}|";
			sLen = pSrc.Length;

			for (int level = 2; level < 11 + 1; level++) {

				for (var i = 1; i < sLen - level + 1; i++) {

					var f = pSrc.Substring(i - 1, level);
					var f1 = pSrc.Substring(i - 1 + 1, level);
					if (f != f1) { r.Add(f); }
					else { /* log($"{f} : {f1}"); */  }
					}
				}

			var founds = new List<string>();
			founds = r;

			var r2 = founds.GroupBy(g => g).Select(s => new { s.Key, kCount = s.Count() }).ToList();
			var r3 = r2.Where(w => w.kCount > 1).OrderBy(o => (o.Key.Length, o.kCount)).ToList();
			var r4 = r3.LastOrDefault();
			return r4 == null ? "" : r4.Key;
			}


		public static string lookPatterns3(string src) {
			var sLen = src.Length;
			var r = new List<string> { };

			if (sLen < 3) return "";

			for (var level = 2; level < (sLen / 2) + 1; level++) {
				for (var i = 0; i < sLen - level + 1; i++) {
					r.Add(src.Substring(i, level));
					}
				}

			var founds = new List<string>();
			founds = r;
			// foreach (var s in r) {				if (src.Contains(s)) { founds.Add(s); }				}
			var r2 = founds.GroupBy(g => g).Select(s => new { s.Key, kCount = s.Count() }).ToList();
			var r3 = r2.Where(w => w.kCount > 1).OrderBy(o => (o.Key.Length, o.kCount)).ToList();
			var r4 = r3.LastOrDefault();
			return r4 == null ? "" : r4.Key;
			}


		public static string lookPatterns2(string src /* , int pLevel */) {
			var sLen = src.Length;
			if (sLen < 3) return "";

			var src2 = src;
			if (sLen % 2 != 0) { src2 += " "; }
			// src = src.PadRight(10);
			var srcMid = src2.Substring(src.Length / 2);

			var r = new List<string> {
				// src.Substring(0,2),           src.Substring(1,2),           src.Substring(2,2),           src.Substring(3,2),           src.Substring(4,2),
				// src.Substring(5,2),           src.Substring(6,2),           src.Substring(7,2),           src.Substring(8,2),           src.Substring(9,2),
				// src.Substring(10,2),          src.Substring(11,2),          src.Substring(12,2),          src.Substring(13,2),          src.Substring(14,2),
				// src.Substring(15,2),          src.Substring(16,2),          src.Substring(17,2),          src.Substring(18,2),          src.Substring(19,2)
				}.ToList().Distinct().ToList();

			for (var level = 10; level > 1; level--) {
				for (var i = 0; i < 11; i++) { r.Add(src.Substring(i, level).Trim()); }
				}
			//r.Sort();
			r = r.Distinct().OrderByDescending(o => o.Length).ToList();

			foreach (var s in r) { if (src.Contains(s)) { return s; } }
			return null;

			}



		public static string PatternChaser(string str) {
			var r = lookPatterns4(str);
			log($"{(r == "" ? "no" : $"yes {r}")}\r\n");
			// log($"{!string.IsNullOrEmpty(r),5} {r,10}  {str,20}\r\n");

			return r;
			//return str;

			}

		public static void Main() {
			// keep this function call here
			// Console.WriteLine(PatternChaser(Console.ReadLine()));
			PatternChaser("aabejiabkfabed");                   // yes abe
			PatternChaser("aabecaa");                          // yes aa
			PatternChaser("abbbaac");                          // no
			PatternChaser("aabbaa");                           // yes aa
			PatternChaser("abcdef12kkk12");                    // yes 12
			PatternChaser("ahhhkskshhh6");                     // yes hhh
			PatternChaser("yoop");                             // no
			PatternChaser("458933896893");                     // yes 893
			PatternChaser("nohere");                           // no
			PatternChaser("aaaakkdnrjsnur998aaaaks");          // yes aaaak
			PatternChaser("lettetr");                          // yes et
			PatternChaser("patterngaloratt");                  // yes att
			PatternChaser("urokklr9833rokklb");                // yes rokkl
			}

		}
	}














