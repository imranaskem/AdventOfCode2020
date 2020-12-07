using Day01;
using NUnit.Framework;
using System.Linq;

namespace Day01Tests
{
    public class Day01
    {
        [Test]
        public void FindTripletThatSumsToTest()
        {
            var stringNums = new string[] { "1721", "979", "366", "299", "675", "1456" };
            var sumTo = 2020;

            var expReport = new ExpenseReport(stringNums);
            var triplet = expReport.FindTripletThatSumsTo(sumTo);

            Assert.AreEqual(3, triplet.Length);
            Assert.AreEqual(sumTo, triplet.Sum());
        }
    }
}