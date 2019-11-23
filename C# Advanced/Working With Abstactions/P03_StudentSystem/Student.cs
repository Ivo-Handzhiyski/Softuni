using System.Text;

namespace P03_StudentSystem
{
    public class Student
    {
        public Student(string name, int age, double grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }

        public double Grade { get; set; }

        public int Age { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {

            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"{this.Name} is {this.Age} years old. ");

            if (this.Grade >= 5.00)
            {
                stringBuilder.Append("Excellent student.");
            }
            else if (this.Grade < 5.00 && this.Grade >= 3.50)
            {
                stringBuilder.Append("Average student.");
            }
            else
            {
                stringBuilder.Append("Very nice person.");
            }

            return stringBuilder.ToString();
        }
    }
}   