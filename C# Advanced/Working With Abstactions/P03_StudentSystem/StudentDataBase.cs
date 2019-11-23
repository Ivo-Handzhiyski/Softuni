using System;
using System.Collections.Generic;
using System.Text;

namespace P03_StudentSystem
{
   public class StudentDatabase
    {
        public StudentDatabase()
        {
            this.collection = new Dictionary<string, Student>();
        }

        private Dictionary<string, Student> collection { get; set; }

        public void Add(string name, int age, double grade)
        {
            if (!this.collection.ContainsKey(name))
            {
                var student = new Student(name, age, grade);
                collection[name] = student;
            }
        }
        public Student Find(string name)
        {
            if(this.collection.ContainsKey(name))
            {
                return this.collection[name];
            }

            return null;
        }
    }
}
