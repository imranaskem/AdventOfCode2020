using System;
using System.Collections.Generic;
using System.Text;

namespace Day02
{
    public class PasswordChecker
    {
        public Dictionary<PasswordRule, string> RulesPasswords { get; set; }

        public PasswordChecker(IEnumerable<string> passwords)
        {
            this.RulesPasswords = new Dictionary<PasswordRule, string>();

            foreach (var password in passwords)
            {
                var passwordParts = password.Split(' ');

                this.RulesPasswords.Add(new PasswordRule(passwordParts[0], passwordParts[1]), passwordParts[2]);
            }
        }

        public int NumberOfValidPasswords()
        {
            var validPasswords = 0;

            foreach (KeyValuePair<PasswordRule,string> kvp in this.RulesPasswords)
            {
                if (kvp.Key.CheckPassword(kvp.Value))
                {
                    validPasswords++;
                }
            }

            return validPasswords;
        }
    }
}
