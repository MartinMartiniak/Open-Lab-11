using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11
{
    class Book
    {
        public string Title { get; set; }

        public int Pages { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }

        public int ReleaseDate { get; set; }

        public static List<string> CategoryList = new List<string>() { "detské", "romantické", "náučné", "sci-fi", "dobrodružné" };


        public Book(string title, int pages, string category, string author, int releaseDate)
        {

            Title = title;

            Pages = pages;

            Category = category;

            Author = author;

            ReleaseDate = releaseDate;
        }
        public Book()
        {
            Title = "-1";
            Pages = -1;
            Category = "-1";
            Author = "-1";
            ReleaseDate = -1;
        }
        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
            Category = "-1";
            Author = "-1";
            ReleaseDate = -1;
        }
        public override string ToString()
        {
            return $"{Title}\n{Pages}\n{Category}\n{Author}\n{ReleaseDate}";
        }
    }
}
