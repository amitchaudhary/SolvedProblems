using System;
using System.Collections.Generic;
using System.Text;

namespace SolvedProblems.ArraysAndStrings
{
    public static class PalindromePermutation
    {
        public static void Run()
        {
            string input = "tact coa";

            bool result = IsPermutationOfPalindrome(input);
            Console.WriteLine(result);
        }
        private static bool IsPermutationOfPalindrome(string phrase)
        {
            int[] table = BuildCharFrequencyTable(phrase);
            return CheckMaxOneOdd(table);
        }
        private static int[] BuildCharFrequencyTable(string phrase)
        {
            int[] table = new int[(int)'z' - (int)'a' + 1];

            int a = (int)'a';   //Assumption: a-z lowercase
            int z = (int)'z';

            foreach (Char c in phrase.ToCharArray())
            {
                int x = 0; 

                if (a <= (int)c && (int)c <= z)
                    x = (int)c - a;
                else
                    x = -1;

                if (x != -1)
                    table[x]++;
            }
            return table;
        }

        private static bool CheckMaxOneOdd(int[] table)
        {
            bool foundOdd = false;
            foreach (int count in table)
            {
                if (count % 2 == 1)
                {
                    if (foundOdd)
                        return false;

                    foundOdd = true;
                }
            }
            return true;
        }
    }
}
