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

        public int[] FindTripletThatSumsTo(int sumTo)
        {
            var results = new HashSet<int>();
                        
            for (int i = 0; i < this.Expenses.Count - 1; i++)
            {
                var currentSum = sumTo - this.Expenses[i];

                for (int j = i + 1; j < this.Expenses.Count; j++)
                {
                    var nextSum = currentSum - this.Expenses[j];

                    if (results.Contains(nextSum))
                    {
                        return new int[] { this.Expenses[i], this.Expenses[j], nextSum };
                    }
                    results.Add(this.Expenses[j]);
                }
            }

            return new int[0];
        }
    }
}
