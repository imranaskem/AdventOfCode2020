using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day02
{
    public class PasswordRule
    {
        public int MinimumCount { get; set; }
        public int MaximumCount { get; set; }
        public char NeededLetter { get; set; }

        public PasswordRule(string minMax, string letter)
        {
            var countParts = minMax.Split('-');
            this.MinimumCount = int.Parse(countParts[0]);
            this.MaximumCount = int.Parse(countParts[1]);
            this.NeededLetter = letter[0];
        }

        public bool CheckPassword(string password)
        {
            var countOfLetter = password.Count(c => c == this.NeededLetter);

            if (countOfLetter >= this.MinimumCount && countOfLetter <= this.MaximumCount)
            {
                return true;
            }

            return false;
        }
    }
}
