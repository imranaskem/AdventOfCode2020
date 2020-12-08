using System.Collections.Generic;
using NUnit.Framework;
using Day02;

namespace Day02Tests
{
    public class PasswordRuleTests
    {
        private List<PasswordRule> rules { get; set; } = new List<PasswordRule>();

        [OneTimeSetUp]
        public void SetupTests()
        {
            var inputs = new string[] { "1-3", "a:", "1-3", "b:", "2-9", "c:", "1-4", "z:", "10-11", "i:" };            

            for (int i = 0; i < inputs.Length; i+=2)
            {
                var rule = new PasswordRule(inputs[i], inputs[i + 1]);

                rules.Add(rule);
            }
        }

        [Test]
        public void ConstructorTest()
        {
            var expectedNumbers = new List<int[]>();
            expectedNumbers.Add(new int[] { 1, 3 });
            expectedNumbers.Add(new int[] { 1, 3 });
            expectedNumbers.Add(new int[] { 2, 9 });

            var expectedLetters = new char[] { 'a', 'b', 'c' };
            
            for (int i = 0; i < 3; i++)
            { 
                Assert.AreEqual(expectedNumbers[i][0], rules[i].MinimumCount);
                Assert.AreEqual(expectedNumbers[i][1], rules[i].MaximumCount);
                Assert.AreEqual(expectedLetters[i], rules[i].NeededLetter);
                Assert.AreNotEqual(':', rules[i].NeededLetter);
            }
        }

        [Test]
        public void CheckPasswordTest()
        {
            var inputs = new string[] { "abcde", "cdefg", "ccccccccc", "zazaza", "iiiiiaiiiii" };
            var expecteds = new bool[] { true, false, true, true, true };

            for (int i = 0; i < inputs.Length; i++)
            {
                Assert.AreEqual(expecteds[i], rules[i].CheckPassword(inputs[i]));
            }
        }
    }
}