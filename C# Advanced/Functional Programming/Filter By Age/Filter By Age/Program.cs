using System;
using System.Linq;
using System.Collections.Generic;

namespace Filter_By_Age
{
    class Person
    {

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;

        }
        public string Name { get; set; }

        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();



            for (int i = 0; i < n; i++)
            {
                var names = Console.ReadLine().Split(", ");
                string name = names[0];
                int age = int.Parse(names[1]);

                var person = new Person(name, age);
                people.Add(person);

            }

            var conditionString = Console.ReadLine();
            var conditionPara = int.Parse(Console.ReadLine());
            Func<Person, bool> predicate = null;
            if(conditionString == "older")
            {
                predicate = p => p.Age >= conditionPara;
            }
            else if(conditionString == "younger")
            {
                predicate = p => p.Age < conditionPara;
            }

            var filteredpeople = people.Where(predicate);
            var format = Console.ReadLine();

            foreach (var person in filteredpeople)
            {
                if(format == "name age")
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");

                }
                else if(format == "name")
                {
                    Console.WriteLine($"{person.Name}");
                }
                else if(format == "age")
                {
                    Console.WriteLine($"{person.Age}");
                }
            }

        }
    }
}
