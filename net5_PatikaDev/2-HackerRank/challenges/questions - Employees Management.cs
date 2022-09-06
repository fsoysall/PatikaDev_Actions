
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace net5.hackerrank.Questions.EmployeesManagement {

	public class Solution {

		public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees) {
			return employees
				.GroupBy(g => g.Company)
				.OrderBy(o => o.Key)
				.Select(s => new { cn = s.Key, v = (int)Math.Round(s.Average(a => a.Age)) })
				.ToDictionary(d => d.cn, d => d.v);
			}

		public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees) {
			return employees
				.GroupBy(g => g.Company)
				.OrderBy(o => o.Key)
				.Select(s => new { cn = s.Key, v = s.Count() })
				.ToDictionary(d => d.cn, d => d.v);

			}

		public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees) {
			return employees.GroupBy(g => g.Company).OrderBy(o => o.Key)
			.Select(s => new { cn = s.Key, v = s.Where(ss => ss.Company == s.Key && ss.Age == s.Max(m => m.Age)).FirstOrDefault() })
			.ToDictionary(d => d.cn, v => v.v);


			}

		public static void Main() {
			var employees = new List<Employee>();

			int countOfEmployees = 12;// int.Parse(Console.ReadLine());
			var empList = @"Ainslee Ginsie Galaxy 28
Libbey Apdell Starbucks 44
Illa Stebbings Berkshire 49
Laina Sycamore Berkshire 20
Abbe Parnell Amazon 20
Ludovika Reveley Berkshire 30
Rene Antos Galaxy 44
Vinson Beckenham Berkshire 45
Reed Lynock Amazon 41
Wyndham Bamfield Berkshire 34
Loraine Sappson Amazon 49
Abbe Antonutti Starbucks 47
".Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

			var empList2 = @"Sybila Fulle Kimberly 24
Scarface Stork Tesla 22
Ashli Crosseland Kimberly 36
Allene Stebbings Galaxy 19
Valentin Harbert Amazon 28
Gracie Pappin Tesla 44
Sadye Orcott Rockwell 30
Timoteo Pook Amazon 35
Marris Apdell Rockwell 43
Pen Ghilardini Rockwell 38
Bern Aizikov Rockwell 20
Sela Farrier Amazon 47
".Split("\r\n", StringSplitOptions.RemoveEmptyEntries);


			for (int i = 0; i < countOfEmployees; i++) {
				string str = empList [i]; //Console.ReadLine();
				string [] strArr = str.Split(' ');
				employees.Add(new Employee {
					FirstName = strArr [0],
					LastName = strArr [1],
					Company = strArr [2],
					Age = int.Parse(strArr [3])
					});
				}

			foreach (var emp in AverageAgeForEachCompany(employees)) {
				Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
				}

			foreach (var emp in CountOfEmployeesForEachCompany(employees)) {
				Console.WriteLine($"The count of employees for company {emp.Key} is {emp.Value}");
				}

			foreach (var emp in OldestAgeForEachCompany(employees)) {
				Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
				}
			}
		}

	public class Employee {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public string Company { get; set; }
		}
	}

