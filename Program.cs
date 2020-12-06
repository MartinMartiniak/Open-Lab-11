using System;
using System.Collections.Generic;

namespace Open_Lab_11
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Book chemia = new Book("Chemia pre gymnazia a druhy stupen zakladnych skol", 92, Book.CategoryList[2], "Zdeno Chara", 1999);
            Book triPrasiatka = new Book("Tri prasiatka", 500, Book.CategoryList[0], "Gizka Onova", 2003);

            List<Book> books = new List<Book>() { chemia, triPrasiatka };
            List<string> students = new List<string>() { "John", "Paul", };

            Library schoolLibrary = new Library(2, 2, students, books);
            schoolLibrary.Discribe();
        }
    }
}
/// musim potrenovat 