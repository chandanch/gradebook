using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Chandio GradeBook");
            book.AddGrade(30.12);
            book.AddGrade(32.12);
            book.AddGrade(30.67);
            book.AddGrade(34.97);
            book.AddGrade(33.12);
            book.AddGrade(29.67);
            book.AddGrade(31.32);

            // show statistics here
            book.ShowStatistics();

        }
    }
}
