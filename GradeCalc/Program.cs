using System;
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
            var book = new Book();
            book.AddGrade(89.1);
            book.AddGrade(32.5);
            book.AddGrade(30.7);

            var stat = book.CalcStatistics();

            Console.WriteLine($"The average grade is {stat.Average}");
            Console.WriteLine($"The lowest grade is {stat.Low}");
            Console.WriteLine($"The highest grade is {stat.High}");

        }
    }
}
