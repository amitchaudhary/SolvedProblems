using System;

namespace SolvedProblems.ArraysAndStrings
{
    public static class URLify
    {
        public static void Run()
        {
            string input = "Mr Amit Chaudhary    "; //Case what of no sufficient space at the end of string
            int trueLength = 17;
            
            bool result = ReplaceSpaces(input, trueLength);
            Console.WriteLine(result);

        }
        private static bool ReplaceSpaces(string input, int trueLength)
        {
            char[] inputChars = input.ToCharArray();
            int spaceCount = 0, index = 0;

            for (int i = 0; i < trueLength; i++)
                if (inputChars[i] == ' ') spaceCount++;

            index = trueLength + spaceCount * 2;

            if (trueLength < inputChars.Length) inputChars[trueLength] = '\0';  //Ending array in case of excess spaces
            
            for (int i = trueLength - 1; i >= 0; i--)
            {
                if (inputChars[i] == ' ')
                {
                    inputChars[index - 1] = '0';
                    inputChars[index - 2] = '2';
                    inputChars[index - 3] = '%';

                    index = index - 3;
                }
                else
                {
                    inputChars[index - 1] = inputChars[i];
                    index--;
                }
            }
            return true;
        }
    }
}
