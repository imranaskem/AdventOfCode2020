using System;
using System.Collections.Generic;
using AdventOfCode2020;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            var expenseReport = new ExpenseReport(LoadFromFile(args[0]));

            var triplet = expenseReport.FindTripletThatSumsTo(2020);

            Console.WriteLine($"Triplet result is {(triplet[0] * triplet[1] * triplet[2])}");
            
        }

        private static List<string> LoadFromFile(string path)
        {
            var expenses = new List<string>();

            FileHandling.Load(path, l =>
            {
                expenses.Add(l);
            });

            return expenses;
        }
    }
}
