﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Chandio GradeBook");

            book.GradeAdded += onGradeAdded;

            while (true) {
                Console.WriteLine("Enter Grade or enter 'Q' to stop entering grades");
                var input = Console.ReadLine();
                if (input == "Q") {
                    break;
                } 
                
                try 
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally 
                {
                    Console.WriteLine("****");
                }
                
            }
            
            var stats = book.GetStatistics();
            Console.WriteLine($"{book.Name} details:\nCategory: {Book.CATEGORY}");
            Console.WriteLine($"Average Grade: { stats.Average:N1}");
            Console.WriteLine($"Highest Grade: { stats.Highest }");
            Console.WriteLine($"Lowest Grade: { stats.Lowest }");
            Console.WriteLine($"Grade: {stats.Letter}");

        }

        static void onGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("New Grade Added!");
        }
    }
}
