using System;
using System.Collections.Generic;
using System.Text;

namespace SolvedProblems.ArraysAndStrings
{
    public static class IsAStringPermutationOfOtherString
    {
        public static void Run()
        {
            string first = "abc";
            string second = "bca";
            bool result = Permutation2(first, second);
            Console.WriteLine(result);

            first = "abc";
            second = "abd";
            result = Permutation2(first, second);
            Console.WriteLine(result);
        }
        #region "Solution#1"
        private static bool Permutation1(String first, String second)
        {
            if (first.Length != second.Length) return false;

            return Sort(first).Equals(Sort(second));
        }
        private static string Sort(String input)
        {
            char[] content = input.ToCharArray();
            Array.Sort(content);

            return new string(content);
        }
        #endregion

        private static bool Permutation2(String first, String second)
        {
            if (first.Length != second.Length) return false;

            int[] letters = new int[128];   //Assumption charset

            char[] s_array = first.ToCharArray();
            foreach (Char c in s_array)
            {
                letters[c]++;
            }
            for (int i = 0; i < second.Length; i++)
            {
                int c = (int)second[i];
                letters[c]--;

                if (letters[c] < 0) return false;
            }
            return true;
        }
    }
}
