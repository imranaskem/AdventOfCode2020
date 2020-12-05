using System;
using System.Collections.Generic;
using System.Text;

namespace Day01
{
    public class ExpenseReport
    {
        private IList<int> Expenses { get; set; }

        public ExpenseReport(IEnumerable<string> expenses)
        {
            this.Expenses = new List<int>();

            foreach (var exp in expenses)
            {
                int numExp;

                if (int.TryParse(exp, out numExp))
                {
                    this.Expenses.Add(numExp);
                }
                else
                {
                    throw new FormatException($"Number parsing failed for {exp}");
                }
            }
        }

        public int[] FindPairThatSumsTo(int sumTo)
        {
            var pairs = new Dictionary<int, int>();

            foreach (var exp in this.Expenses)
            {
                var key = sumTo - exp;
                if (pairs.ContainsKey(key))
                {
                    return new int[] { key, exp };
                }
                else
                {
                    pairs.Add(exp, 0);
                }
            }

            return new int[0];
        }
    }
}
