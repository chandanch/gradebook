﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Chandio GradeBook");
            book.AddGrade(12.343);
            book.AddGrade(34.67);
            book.AddGrade(43.90);

            var grades = new List<double>() { 10.21, 10.12, 10.52, 8.45 };
            grades.Add(10.42);

            var result = 0.0;
            var highestGrade = double.MinValue;
            var lowestGrade = double.MaxValue;
            foreach (double grade in grades)
            {
                highestGrade = Math.Max(highestGrade, grade);
                lowestGrade = Math.Min(lowestGrade, grade);
                result += grade;
            }
            Console.WriteLine($"No. of Grades: {grades.Count}");
            Console.WriteLine($"Average Grade: {result / grades.Count:N1}");
            Console.WriteLine($"Highest Grade: {highestGrade}");
            Console.WriteLine($"Lowest Grade: {lowestGrade}");

        }
    }
}
