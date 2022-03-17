﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalc
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("");

            //var done = false;

            while(true)
            {
                Console.WriteLine("Enter any grade or 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
                

            
            

            var stat = book.CalcStatistics();

            Console.WriteLine($"The average grade is {stat.Average}");
            Console.WriteLine($"The lowest grade is {stat.Low}");
            Console.WriteLine($"The highest grade is {stat.High}");
            Console.WriteLine($"The Letter grade is {stat.Letter}");

        }
    }
}
