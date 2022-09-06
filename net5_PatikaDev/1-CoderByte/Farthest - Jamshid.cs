using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace net5.CoderByte.Farthest3Jamshid {

  class MainClass {

	 public static string FarthestNodes(string[] strArr) {

		var graph = new Dictionary<string, List<string>>();

		foreach (var edge in strArr) {
		  var parts = edge.Split('-');
		  if (!graph.ContainsKey(parts[0])) {
			 graph.Add(parts[0], new List<string>());
		  }
		  graph[parts[0]].Add(parts[1]);
		}

		var longestPathLength = 0;

		foreach (var key in graph.Keys) {
		  var path = key;
		  var pathLenght = 1;
		  var queue = new Queue<string>();
		  queue.Enqueue(key);

		  while (queue.Count > 0) {
			 var current = queue.Dequeue();
			 if (graph.ContainsKey(current)) {
				queue.Enqueue(graph[current].First());
				path += "-" + graph[current].First();
				pathLenght++;
			 }
		  }

		  if (pathLenght > longestPathLength) {

			 longestPathLength = pathLenght;
		  }

		}

		return longestPathLength + "";

	 }

	 static public void Main() {
		// keep this function call here
		//Console.WriteLine(FarthestNodes(Console.ReadLine()));


		Console.WriteLine(/* 1 == */ FarthestNodes( new string[] { "a-b" })); // 1
		Console.WriteLine(/* 4 == */ FarthestNodes( new string[] { "b-e", "b-c", "c-d", "a-b", "e-f" })); //4
		Console.WriteLine(/* 3 == */ FarthestNodes( new string[] { "b-a", "c-e", "b-c", "d-c" })); //3

		Console.WriteLine(/* 4 == */ FarthestNodes( new string[] { "a-b", "b-c", "c-e", "a-d" })); // 4
		Console.WriteLine(/* 6 == */ FarthestNodes( new string[] { "a-b", "b-c", "c-e", "a-d", "g-f", "f-d" })); // 6
		Console.WriteLine(/* 7 == */ FarthestNodes( new string[] { "a-b", "b-c", "c-e", "a-d", "g-f", "f-d", "h-i", "f-h" })); // 7
		Console.WriteLine(/* 9 == */ FarthestNodes( new string[] { "b-a", "a-c", "c-d", "e-d", "e-f", "f-g", "g-h", "i-h", "i-j" })); // 9
		Console.WriteLine(/* 4 == */ FarthestNodes( new string[] { "b-e", "b-c", "c-d", "a-b", "e-f" })); //4
		Console.WriteLine(/* 3 == */ FarthestNodes( new string[] { "b-a", "c-e", "b-c", "d-c" })); //3
		Console.WriteLine(/* 2 == */ FarthestNodes( new string[] { "a-b", "b-c", "b-d" })); //2 
		Console.WriteLine(/* 2 == */ FarthestNodes( new string[] { "b-a", "a-c" })); // 2
		Console.WriteLine(/* 3 == */ FarthestNodes( new string[] { "b-a", "a-c", "c-d" })); // 3

	 }
  }




}


