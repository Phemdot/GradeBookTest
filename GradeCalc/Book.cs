using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalc
{
    public class Book : NamedObject
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddLetterGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        }

        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid{nameof(grade)}");
            }
        }

        public Statistics CalcStatistics()
        {
            //var grades = new List<double>() { 12.7, 23.0, 45.6, 15.3 };
            //grades.Add(34.1);

            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            var index = 0;
            if (index < grades.Count) 
            {
                foreach (var grade in grades)
                {
                    result.Low = Math.Min(grades[index], result.Low);
                    result.High = Math.Max(grades[index], result.High);
                    result.Average += grades[index];
                    index += 1;
                }
            }
            

            result.Average /= grades.Count;

            switch(result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;

                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;

                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;

                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;

                default:
                    result.Letter = 'F';
                    break;


            }

            return result;
        }

        private List<double> grades;
        public string Name;

        
    }
}
