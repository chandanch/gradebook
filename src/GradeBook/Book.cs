using System;
using System.Collections.Generic;

namespace GradeBook 
{
    
    class Book 
    {
        public Book()
        {
            grades = new List<double>();
        }
        public void AddGrade(double grade) 
        {
            grades.Add(grade);
            Console.WriteLine($"Added Grade: {grade}");
        }

        List<double> grades;

    }
}