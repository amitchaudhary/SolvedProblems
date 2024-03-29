﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SolvedProblems.ArraysAndStrings
{
    public static class OneAway
    {
        public static void Run()
        {
            // pale, ple    -> true
            // pales, pale  -> true
            // pale, bale   -> true
            // pale, bae    -> false

            string first = "pale";
            string second = "ple";

            bool result = OneEditAway(first, second);
            Console.WriteLine(result);
        }
        private static bool OneEditAway(string first, string second)
        {
            if (first.Length == second.Length)
                return OneEditReplace(first, second);
            else if (first.Length + 1 == second.Length)
                return OneEditInsert(first, second);
            else if (first.Length - 1 == second.Length)
                return OneEditInsert(second, first);

            return false;
        }
        private static bool OneEditReplace(string s1, string s2)
        {
            bool foundDifference = false;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    if (foundDifference)
                        return false;

                    foundDifference = true;
                }
            }
            return true;
        }
        private static bool OneEditInsert(string s1, string s2)
        {
            int index1 = 0, index2 = 0;
            
            while(index2 < s2.Length && index1 < s1.Length)
            {
                if(s1[index1] != s2[index2])
                {
                    if (index1 != index2)
                        return false;

                    index2++;
                }
                else
                {
                    index1++;
                    index2++;
                }
            }
            return true;
        }
    }
}
