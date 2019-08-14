using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());

            List<Students> students = new List<Students>();

            for (int i = 0; i < studentCount; i++)
            {
                string[] studentArcs = Console.ReadLine()
                    .Split();

                string firstName = studentArcs[0];
                string lastName = studentArcs[1];
                double grade = double.Parse(studentArcs[2]);

                Students student = new Students(firstName, lastName, grade);

                students.Add(student);


            }

            List<Students> sortedStudents = students
                .OrderByDescending(x => x.Grade)
                .ToList();

            foreach (var sortedStudent in sortedStudents)
            {
                Console.WriteLine($"{sortedStudent.FirstName} {sortedStudent.LastName}: {sortedStudent.Grade:f2}");
            }
        }
    }
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Students(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;

        }

    }




}