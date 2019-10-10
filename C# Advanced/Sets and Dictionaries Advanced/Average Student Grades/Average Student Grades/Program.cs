using System;
using System.Collections.Generic;
using System.Linq;
namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                var parts = line.Split();
                var name = parts[0];
                var grade = double.Parse(parts[1]);
                if(!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());

                }

                students[name].Add(grade);

            }


            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ",student.Value.Select(x => x.ToString("F2")))} (avg: {student.Value.Average():f2})");
            }
        }
    }
}
