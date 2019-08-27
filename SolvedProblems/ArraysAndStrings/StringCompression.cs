using System;
using System.Collections.Generic;
using System.Text;

namespace SolvedProblems.ArraysAndStrings
{
    public static class StringCompression
    {
        public static void Run()
        {
            // aabcccccaaa    -> a2b1c5a3

            string input = "abcd";  // "aabcccccaaa";

            string result = Compress(input);
            Console.WriteLine(result);
        }
        private static string Compress(string input)
        {
            StringBuilder compressed = new StringBuilder();
            int countConsecutive = 0;

            for (int i = 0; i < input.Length; i++)
            {
                countConsecutive++;

                if (compressed.Length > input.Length) 
                    return input;

                if (i + 1 >= input.Length || input[i] != input[i + 1])
                {
                    compressed.Append(input[i]);
                    compressed.Append(countConsecutive);

                    countConsecutive = 0;
                }
            }
            return compressed.ToString();
        }
    }
}
