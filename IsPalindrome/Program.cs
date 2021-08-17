using System;

namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckPalindrome("eye");
            CheckPalindrome("home");
        }

        private static void CheckPalindrome(string input)
        {
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            string reverse = new string(array);
            Console.WriteLine(input + " " + reverse);

            if (input.Equals(reverse))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}