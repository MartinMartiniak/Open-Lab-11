using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11
{
    class Library
    {
        internal static Library schoolLibrary;


        public List<string> StudentsList { get; set; }
        public List<Book> BooksList { get; set; }
        public Library( List<string> studentslist, List<Book> bookslist)
        {
            
            StudentsList = studentslist;
            BooksList = bookslist;
        }
        public Library()
        {
            Book book = new Book();
           
            StudentsList = new List<string>();
            BooksList = new List<Book>();

        }
        public override string ToString()
        {
            return $"{StudentsList}\n{BooksList}";
        }
        public void Discribe()
        {
           

            Console.WriteLine("-----------");
            Console.WriteLine("Vypis studentov:");

            foreach (string Pupil in StudentsList)
            {
                Console.WriteLine(Pupil);
            }

            Console.WriteLine("----------");
            Console.WriteLine("Vypis knih:");

            foreach (Book book in BooksList)
            {
                Console.WriteLine(book.ToString());
                Console.WriteLine();
            }
        }
    }
}

