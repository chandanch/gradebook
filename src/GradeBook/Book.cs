using System;
using System.Collections.Generic;

namespace GradeBook 
{
    
    class Book 
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade) 
        {
            grades.Add(grade);
            // Console.WriteLine($"Added Grade: {grade}");
        }

        public List<double> grades;
        private string name;


    }
}