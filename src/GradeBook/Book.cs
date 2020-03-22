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

        public void ShowStatistics() {
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
        
        private List<double> grades;
        private string name;


    }
}