using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Article> article = new List<Article>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ");

                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article articles = new Article(title, content, author);

                article.Add(articles);
            }
            string command = Console.ReadLine();

            if (command == "title")
            {
                List<Article> sortedTitles = article.OrderBy(x => x.Title)
                    .ToList();
                foreach (var student in sortedTitles)
                {
                    Console.WriteLine($"{student.Title} - {student.Content}: {student.Author}");
                }
            }
            else if (command == "content")
            {
                List<Article> sortedContents = article.OrderBy(x => x.Content)
                    .ToList();
                foreach (var student in sortedContents)
                {
                    Console.WriteLine($"{student.Title} - {student.Content}: {student.Author}");
                }
            }
            else if (command == "author")
            {
                List<Article> sortedAutors = article.OrderBy(x => x.Author)
                    .ToList();
                foreach (var student in sortedAutors)
                {
                    Console.WriteLine($"{student.Title} - {student.Content}: {student.Author}");
                }
            }

        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;

        }

    }
}
