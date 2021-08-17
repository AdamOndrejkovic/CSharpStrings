using System;
using System.Linq;

namespace AddSeparator
{
    class Program
    {
        static void Main(string[] args)
        {
            SplitBySeparator("ABCD", "^");
            SplitBySeparator("chocolate", "-");
        }

        private static void SplitBySeparator(string text, string separator)
        {
            char[] words = text.ToCharArray();
            Console.Write(words[0]);
            foreach (var word in words.Skip(1))
            {
                Console.Write(separator+word);
            }

            Console.WriteLine("\n");
        }
    }
}