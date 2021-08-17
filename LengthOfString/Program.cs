using System;

namespace LengthOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckLength("Hello");
            CheckLength("Hello World");
        }

        private static void CheckLength(string input)
        {
            int countChar = 0;
            foreach (var character in input)
            {
                countChar++;
            }
            Console.WriteLine(countChar);
        }
    }
}