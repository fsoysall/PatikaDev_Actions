using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace net5.CoderByte.Farthest {

  class MainClass {
	 private static List<string> getSubsByC(char c) => CheckPool.Where(w => w.StartsWith(c)).ToList() ?? new List<string>();

	 private static List<string> CheckPool;
	 private static List<string> AllPool = new List<string>();

	 public static int FarthestNodes(string[] strArr) => FarthestNodes(0, strArr);

	 public static int FarthestNodes(int a, string[] strArr) {
		CheckPool = new List<string>();
		strArr.ToList().ForEach(f => {
		  CheckPool.Add($"{f.First()}{f.Last()}");
		  CheckPool.Add($"{f.Last()}{f.First()}");
		});

		AllPool.Clear();
		var pool = new List<string>();
		//ActiveArr = string.Join(" ", strArr);

		foreach (string t in CheckPool) {
		  var str = t.Replace("-", "");

		  var rs = GetFullTreeS(str.First(), "");
		  //AllPool.Add(rs);
		  //AllPool = normalize(AllPool);

		  rs = GetFullTreeS(str.Last(), "");
		  //AllPool.Add(rs);
		}

		AllPool = normalize(AllPool);

		var r = AllPool.FirstOrDefault(); //.OrderByDescending(o => o.Length).FirstOrDefault();

		//Console.Write($"OK:{a == r.Length - 1} Must :{a} :: {r.Length - 1} : {r.PadRight(10)} :: {string.Join(" ", strArr)} ");
		return r.Length - 1;

	 }

	 private static string GetFullTreeS(char c, string path) {
		if (path.Length == 0) { path = c.ToString(); }
		if (path.EndsWith($"{c}{c}")) { return ""; }

		//var PathS = new List<string>();
		var SubS = getSubsByC(c);

		foreach (var item in SubS) {
		  var itemRev = string.Join("", item.Reverse());
		  if (!(path.EndsWith(item) || path.EndsWith(itemRev))) {
			 var path2 = path + item.Last(); AllPool.Add(path2);
			 var SubS2 = GetFullTreeS(item.Last(), path2); AllPool.Add(SubS2);
		  }
		}
		//PathS = normalize(PathS);
		//AllPool.AddRange(PathS);
		return ""; // PathS.OrderBy(o => o.Length).LastOrDefault() + "";
	 }

	 //private static List<string> RemoveSelf(List<string> subS, string path) {
	 //if (path.Length < 2) { return subS; }
	 //var s = string.Join("", path.TakeLast(2));
	 //var sr = string.Join("", path.TakeLast(2).Reverse());
	 //subS.Remove(s);
	 //subS.Remove(sr);
	 //return subS;
	 //}

	 public static void Main() {
		// keep this function call here
		//Console.WriteLine(FarthestNodes(Console.ReadLine()));
		Console.WriteLine(/* 1 == */ FarthestNodes(1, new string[] { "a-b" })); // 1
		Console.WriteLine(/* 4 == */ FarthestNodes(4, new string[] { "b-e", "b-c", "c-d", "a-b", "e-f" })); //4
		Console.WriteLine(/* 3 == */ FarthestNodes(3, new string[] { "b-a", "c-e", "b-c", "d-c" })); //3

		Console.WriteLine(/* 4 == */ FarthestNodes(4, new string[] { "a-b", "b-c", "c-e", "a-d" })); // 4
		Console.WriteLine(/* 6 == */ FarthestNodes(6, new string[] { "a-b", "b-c", "c-e", "a-d", "g-f", "f-d" })); // 6
		Console.WriteLine(/* 7 == */ FarthestNodes(7, new string[] { "a-b", "b-c", "c-e", "a-d", "g-f", "f-d", "h-i", "f-h" })); // 7
		Console.WriteLine(/* 9 == */ FarthestNodes(9, new string[] { "b-a", "a-c", "c-d", "e-d", "e-f", "f-g", "g-h", "i-h", "i-j" })); // 9
		Console.WriteLine(/* 4 == */ FarthestNodes(4, new string[] { "b-e", "b-c", "c-d", "a-b", "e-f" })); //4
		Console.WriteLine(/* 3 == */ FarthestNodes(3, new string[] { "b-a", "c-e", "b-c", "d-c" })); //3
		Console.WriteLine(/* 2 == */ FarthestNodes(2, new string[] { "a-b", "b-c", "b-d" })); //2 
		Console.WriteLine(/* 2 == */ FarthestNodes(2, new string[] { "b-a", "a-c" })); // 2
		Console.WriteLine(/* 3 == */ FarthestNodes(3, new string[] { "b-a", "a-c", "c-d" })); // 3


	 }

	 private static List<string> normalize(List<string> pool2) {

		var tPool = pool2.Distinct().ToList();
		var mid = CheckPool.Count / 2;
		foreach (var item in pool2) {
		  if ((CheckPool.IndexOf(item) + 1) > mid) {
			 tPool.Remove(item);
			 tPool.Add($"{item[1]}{item[0]}");
		  }
		}
		tPool = tPool.OrderByDescending(o => o.Length).Distinct().ToList();
		//tPool.Sort();
		return tPool;
	 }



  }

}


