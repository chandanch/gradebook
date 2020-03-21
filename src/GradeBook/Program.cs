﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() { 10.21, 10.12, 10.52 };
            grades.Add(10.42);


            var result = 0.0;
            foreach (double grade in grades)
            {
                result += grade;
            }
            Console.WriteLine($"No. of Grades: {grades.Count}");
            Console.WriteLine($"Average Grade: {result / grades.Count}");

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }

        }
    }
}
