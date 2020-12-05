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

            var pair = expenseReport.FindPairThatSumsTo(2020);

            Console.WriteLine($"Pair is {pair} and the result is {(pair[0] * pair[1])}");
            
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
