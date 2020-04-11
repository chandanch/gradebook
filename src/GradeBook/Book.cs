using System;
using System.Collections.Generic;

namespace GradeBook 
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public interface IBook
    {
        void AddGrade(double grade);
        Statistics GetStatistics();
        string Name {
            get;
        }
        event GradeAddedDelegate GradeAdded;
    }

    public abstract class Book : NamedObject, IBook
    {
        public Book(string name) : base(name)
        {
        }

        public virtual event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        public virtual Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
    
    public class InMemoryBook : Book
    {
        public InMemoryBook(string name) : base(name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(char letter) {
            switch(letter) {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                case 'D':
                    AddGrade(60);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }

        public override void AddGrade(double grade) 
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);   
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs()); 
                }
                
            }
            else 
            {
                throw new ArgumentException($"Invalid input for {nameof(grade)}"); 
            }
            // Console.WriteLine($"Added Grade: {grade}");
        }

        public override event GradeAddedDelegate GradeAdded;

        public override Statistics GetStatistics() {
            
            var result = new Statistics();
            result.Highest = double.MinValue;
            result.Lowest = double.MaxValue;

            for(var index = 0; index < grades.Count; index += 1)
            {
                result.Highest = Math.Max(result.Highest, grades[index]);
                result.Lowest = Math.Min(result.Lowest, grades[index]);
                result.Average += grades[index];
            }
            
            result.Average /=  grades.Count;

            switch(result.Average) {
                case var d when d >= 90:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }

            return result;
        }

        private List<double> grades;
        public const string CATEGORY = "Science";

    }
}