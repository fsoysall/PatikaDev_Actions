using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace net5.CoderByte.Farthest2 {


    class MainClass {
        private static List<string> getSubsC(char c) => CheckPool.Where(w => w.StartsWith(c)).ToList() ?? new List<string>();
        private static List<string> getSubsC2(char c) => CheckPool.Where(w => w.EndsWith(c)).ToList() ?? new List<string>();

        static int ll = 0;
        private static string ActiveArr;
        private static List<string> CheckPool;
        private static List<string> fullPool = new List<string>();
        private static List<string> fullPool2 = new List<string>();
        //private static List<string> pool = new List<string>();
        //private static List<string> pool2 = new List<string>();
        //private static List<string> pool3 = new List<string>();
        private static List<List<string>> pooll = new List<List<string>>();

        public static int FarthestNodes(int a, string[] strArr) {
            try {

                CheckPool = strArr.ToList();
                fullPool.Clear();
                var pool = new List<string>();
                ActiveArr = String.Join(" ", strArr);
                foreach (string t in strArr) {
                    var str = t.Replace("-", "");

                    var rs = GetFullTreeS(str.First(), "");
                    fullPool2.Add(rs);

                    rs = GetFullTreeS(str.Last(), "");
                    fullPool2.Add(rs);
                    fullPool2 = normalize(fullPool2);
                    var r = fullPool2.OrderBy(o => o.Length).Last();
                    Console.Write($"{a} :: {r.Length - 1} : {r.PadRight(10)} :: {string.Join(" ", strArr)} ");
                    return r.Length - 1;

                    //pool = GetFullTree(str.First(), "");
                    //fullPool.AddRange(pool);

                    //pool = GetFullTree(str.Last(), "");
                    //fullPool.AddRange(pool);
                    //fullPool = normalize(fullPool);
                    //fullPool2 = normalize(fullPool2);
                    //var r2 = fullPool2.OrderBy(o => o.Length).Last().Length - 1;
                    //Console.Write($"{r2} : ");
                    //return r2;
                }

                return 0;
            } catch  { throw; }

        }

        private static string GetFullTreeS(char c, string path) {
                var fullPool3 = new List<string>();
                var r = getSubsC(c);
                //if (path.Length == 0) { r.AddRange(getSubsC2(c))};
                ll = r.Count > 0 ? 1 : 0;
                if (path.EndsWith($"{c}{c}" )) { return ""; }
                if (path.Length == 0) { path = c.ToString(); }
                foreach (var item in r) {
                    var path2 = path + item.Last();
                    fullPool3.Add(path2);
                    var r2 = GetFullTreeS(item.Last(), path2);
                    fullPool3.Add(r2);
                }
                fullPool3 = normalize(fullPool3);
                fullPool2.AddRange(fullPool3);
                return fullPool3.OrderBy(o => o.Length).LastOrDefault() + "";
        }


        private static List<string> GetFullTree(char c, string path) {
                var result = new List<string>();
                var r = getSubsC(c);
                result.AddRange(r);
                ll = r.Count > 0 ? 1 : 0;
                if (path.Length == 0) { path = c.ToString(); }
                foreach (var item in r) {
                    path += item.Last();
                    fullPool2.Add(path);
                    var r2 = GetFullTree(item.Last(), path);
                    result.AddRange(r2);
                }
                result = normalize(result);
                return result;
            //} catch (Exception ex) { throw; }
        }

        private static List<string> getSubsC(List<string> pool) {
            var pool2 = new List<string>();
            pool.ForEach(f => pool2.AddRange(getSubsC(f.Last())));
            pool2 = normalize(pool2);
            if (pool2.Count > 0 && !CheckEqual(pool, pool2)) {
                pool2.AddRange(getSubsC(pool2));
            }
            pool2 = normalize(pool2);
            return pool2;
        }

        private static bool CheckEqual(List<string> pool, List<string> pool2) {
            if (pool.Count != pool2.Count) { return false; }
            foreach (var item in pool) {
                if (!pool2.Contains(item)) { return false; }
            }
            return true;
        }

        private static List<string> normalize(List<string> pool2) {

            var tPool = pool2.Distinct().ToList();
            var mid = CheckPool.Count / 2;
            foreach (var item in pool2) {
                if ((CheckPool.IndexOf(item) + 1) > mid) {
                    tPool.Remove(item);
                    tPool.Add($"{item[2]}-{item[0]}");
                }
            }
            tPool = tPool.Distinct().ToList();
            tPool.Sort();
            return tPool;
        }


        public static void Main() {
            // keep this function call here
            //Console.WriteLine(FarthestNodes(Console.ReadLine()));

            Console.WriteLine(
            4 == FarthestNodes(4, new string[] { "a-b", "b-c", "c-e", "a-d" })); // 4

            Console.WriteLine(
            2 == FarthestNodes(2, new string[] { "a-b", "b-c", "b-d" })); //2 


            Console.WriteLine(
            2 == FarthestNodes(2, new string[] { "b-a", "a-c" })); // 2

            Console.WriteLine(
            3 == FarthestNodes(3, new string[] { "b-a", "a-c", "c-d" })); // 3

            Console.WriteLine(
            6 == FarthestNodes(6, new string[] { "a-b", "b-c", "c-e", "a-d", "g-f", "f-d" })); // 6

            Console.WriteLine(
            7 == FarthestNodes(7, new string[] { "a-b", "b-c", "c-e", "a-d", "g-f", "f-d", "h-i", "f-h" })); // 7

            Console.WriteLine(
            9 == FarthestNodes(9, new string[] { "b-a", "a-c", "c-d", "e-d", "e-f", "f-g", "g-h", "i-h", "i-j" })); // 9

            Console.WriteLine(
            4 == FarthestNodes(4, new string[] { "b-e", "b-c", "c-d", "a-b", "e-f" })); //4

            Console.WriteLine(
            3 == FarthestNodes(3, new string[] { "b-a", "c-e", "b-c", "d-c" })); //3

            Console.WriteLine(
            1 == FarthestNodes(1, new string[] { "a-b" })); // 1

        }

    }

}


