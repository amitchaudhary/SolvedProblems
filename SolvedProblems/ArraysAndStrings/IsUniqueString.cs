using System;
using System.Collections.Generic;
using System.Text;

namespace SolvedProblems.ArraysAndStrings
{
    public static class IsUniqueString
    {
        public static void Run()
        {
            //ASCII vs Extended ASCII vs Unicode string @ https://www.ascii-code.com/
            //ASCII defines 128 characters, which map to the numbers 0–127
            //ASCII Extended defines 256 characters, which map to the numbers 0–255

            string input = "abcd";
            bool isUnique = IsUniqueChars2(input);
            Console.WriteLine(isUnique);

            input = "abca";
            isUnique = IsUniqueChars2(input);
            Console.WriteLine(isUnique);
        }
        public static bool IsUniqueChars1(string input)
        {
            if (input.Length > 128) return false;   //length check according to character set type

            bool[] char_set = new bool[128];
            for (int i = 0; i < input.Length; i++)
            {
                int value = input[i];
                if (char_set[value])
                {
                    return false;
                }
                char_set[value] = true;
            }
            return true;
        }

        public static bool IsUniqueChars2(string input)
        {
            int checker = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int value = input[i] - 'a';
                if ((checker & (1 << value)) > 0)
                {
                    return false;
                }
                checker |= (1 << value);
            }
            return true;
        }
    }
}
