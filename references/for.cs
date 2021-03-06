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
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);    
            }
            else 
            {
                Console.WriteLine("Invalid Input must be between 0 - 100");
            }
            
            // Console.WriteLine($"Added Grade: {grade}");
        }

        public Statistics GetStatistics() {
            
            var result = new Statistics();
            result.Highest = double.MinValue;
            result.Lowest = double.MaxValue;

            // use of for loop
            //      initializer      condition        operation
            for(var index = 0; index < grades.Count; index += 1)
            {
                result.Highest = Math.Max(result.Highest, grades[index]);
                result.Lowest = Math.Min(result.Lowest, grades[index]);
                result.Average += grades[index];
                index += 1;
            }
            
            result.Average /=  grades.Count;
            return result;
        }
        
        private List<double> grades;
        public string Name;


    }
}