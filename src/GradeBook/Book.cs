using System;
using System.Collections.Generic;

namespace GradeBook 
{
    
    public class Book 
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade) 
        {
            grades.Add(grade);
            // Console.WriteLine($"Added Grade: {grade}");
        }

        public Statistics GetStatistics() {
            
            var result = new Statistics();
            result.Highest = double.MinValue;
            result.Lowest = double.MaxValue;
            foreach (double grade in grades)
            {
                result.Highest = Math.Max(result.Highest, grade);
                result.Lowest = Math.Min(result.Lowest, grade);
                result.Average += grade;
            }
            
            result.Average /=  grades.Count;
            return result;
        }
        
        private List<double> grades;
        public string Name;


    }
}