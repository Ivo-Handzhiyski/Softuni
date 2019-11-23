namespace P03_StudentSystem
{
    using System;
    using System.Collections.Generic;

    public class StudentSystem
    {

        private StudentDatabase students;

        public StudentSystem()
        {
            this.students = new StudentDatabase();
        }

        public void ParseCommand()
        {
            string[] args = Console.ReadLine().Split();
            var commandName = args[0];

            if (commandName == "Create")
            {
                this.Create(args);
            }
            else if (commandName == "Show")
            {
                this.Show(args);

            }
            else if (commandName == "Exit")
            {
                Environment.Exit(0);
            }
        }

        private void Show(string[] args)
        {
            var name = args[1];
            var student = this.students.Find(name);
            if(student != null)
            {
                Console.WriteLine(student);
            }
        }

        private void Create(string[] args)
        {
            var name = args[1];
            var age = int.Parse(args[2]);
            var grade = double.Parse(args[3]);
            this.students.Add(name, age, grade);
  
        }       
    }
}

