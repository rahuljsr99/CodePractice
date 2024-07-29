﻿using System;

namespace PracticeCoding.String_Manipulation
{
    public class LongestCommonPrefix
    {
        public static void main(string[] args)
        {
            string[] inputString = { "tree", "trout", "trench", "troll", };
            Console.WriteLine(GetLongestCommonPrefix(inputString));
            Console.ReadLine();
        }

        public static string GetLongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix))
                    {
                        return "";
                    }
                }
            }

            return prefix;
        }
    }
}
