using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalc
{
    [TestFixture]
    class BookTests
    {

        [TestCase]
        public void CalculateAverageGrade()
        {
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            var result = book.CalcStatistics();

            Assert.AreEqual(85.6, result.Average, 1);
            Assert.AreEqual(90.5, result.High, 1);
            Assert.AreEqual(77.3, result.Low, 1);
        }
    }
}
