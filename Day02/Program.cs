using System;
using System.Collections.Generic;
using AdventOfCode2020;

namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                throw new InvalidOperationException("Missing argument");
            }

            var passwordChecker = LoadFromFile(args[0]);

            Console.WriteLine(passwordChecker.NumberOfValidPasswords());
        }

        static PasswordChecker LoadFromFile(string path)
        {
            var passwords = new List<string>();

            FileHandling.Load(path, l =>
            {
                passwords.Add(l);
            });

            return new PasswordChecker(passwords);
        }
    }
}
