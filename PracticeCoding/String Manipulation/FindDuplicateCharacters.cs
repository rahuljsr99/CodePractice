using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding.String_Manipulation
{
    public class FindDuplicateCharacters
    {
        public static void main(string[] args)
        {
            string inputString = "LLLEEEPREvvKSS";
            char[] DuplicateDistinctCharacters = FindingDuplicateCharaters(inputString);
            Console.Write(DuplicateDistinctCharacters);

        }
        public static char[] FindingDuplicateCharaters(string str)
        {
            char[] stringArr = str.ToLower().ToCharArray();
            StringBuilder duplicateChar = new StringBuilder();
            if(string.IsNullOrEmpty(str)) return null;

            Array.Sort(stringArr);

            for(int i = 0; i < stringArr.Length - 1; i++)
            {
                if (stringArr[i] == stringArr[i + 1])
                {
                    duplicateChar.Append(stringArr[i]);
                }
            }

            return duplicateChar.ToString().ToCharArray();
        }
    }
}
//Self
