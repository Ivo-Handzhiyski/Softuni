using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Articles = Console.ReadLine()
                .Split(", ")
            .ToList();

            string title = Articles[0];
            string content = Articles[1];
            string author = Articles[2];

            Article article = new Article(title, content, author);

            int countOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfCommands; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(": ");

                string command = commandArgs[0];
                string value = commandArgs[1];

                if (command == "Edit")
                {
                    string xdcontent = commandArgs[1];
                    article.Edit(xdcontent);
                }
                else if (command == "ChangeAuthor")
                {
                    string xdAutorr = commandArgs[1];
                    article.ChangeAuthor(xdAutorr);

                }
                else if (command == "Rename")
                {
                    string namexd = commandArgs[1];
                    article.Rename(namexd);

                }
            }
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
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
        public void Edit(string newContent)
        {
            this.Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }
    }




}