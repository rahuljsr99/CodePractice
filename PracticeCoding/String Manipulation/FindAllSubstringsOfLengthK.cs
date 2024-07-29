using System;
using System.Collections.Generic;

namespace PracticeCoding.String_Manipulation
{
    public class FindAllSubstringsOfLengthK
    {
        public static void main(string[] args)
        {
            string inputString = "rahul";
            int k =4;
            List<string> result = FindUniqueSubstrings(inputString, k);
            Console.WriteLine(string.Join(", ", result));
            Console.ReadLine();
        }

        public static List<string> FindUniqueSubstrings(string s, int k)
        {
            HashSet<string> substrings = new HashSet<string>();

            if (string.IsNullOrEmpty(s) || k <= 0 || k > s.Length)
            {
                return new List<string>();
            }

            for (int i = 0; i <= s.Length - k; i++)
            {
                string substring = s.Substring(i, k);
                substrings.Add(substring);
            }

            return new List<string>(substrings);
        }
    }
}
