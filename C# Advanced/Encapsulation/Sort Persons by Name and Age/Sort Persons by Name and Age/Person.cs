using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        public Person(string firstName, string secondName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get
            {
                return this.FirstName;
            }
           private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
            }
        }
        public string SecondName
        {
            get
            {
                return this.SecondName;
            }
           private set
            {
                if(value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
            }
        }


        public int Age
        {
            get
            {
                return this.Age;
            }
           private set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
            }
        }

        public decimal Salary
        {
            get
            {
                return this.Salary;
            }
           private set
            {
                if(value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.SecondName} gets {this.Salary:f2} leva.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if(this.Age > 30)
            {
                this.Salary += this.Salary * percentage / 100;
            }
            else
            {
                this.Salary += this.Salary * percentage / 200;
            }
        }
    }
}
