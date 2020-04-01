using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Chandio GradeBook");
            book.AddGrade(60.12);
            book.AddGrade(68.12);
            book.AddGrade(66.67);

            // show statistics here
            var stats = book.GetStatistics();
            Console.WriteLine($"Average Grade: { stats.Average:N1}");
            Console.WriteLine($"Highest Grade: { stats.Highest }");
            Console.WriteLine($"Lowest Grade: { stats.Lowest }");
            Console.WriteLine($"Grade: {stats.Letter}");

        }
    }
}
