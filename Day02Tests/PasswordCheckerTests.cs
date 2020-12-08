using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Day02;

namespace Day02Tests
{
    public class PasswordCheckerTests
    {
        private PasswordChecker pc { get; set; }

        [OneTimeSetUp]
        public void SetupTests()
        {
            var inputs = new string[] { "1-3 a: abcde", "1-3 b: cdefg", "2-9 c: ccccccccc", "1-4 z: zazaza" };

            pc = new PasswordChecker(inputs);
        }
        
        [Test]
        public void ConstructorTest()
        {
            Assert.AreEqual(4, pc.RulesPasswords.Count);
        }

        [Test]
        public void NumberOfValidPasswordsTest()
        {
            Assert.AreEqual(3, pc.NumberOfValidPasswords());
        }
    }
}
