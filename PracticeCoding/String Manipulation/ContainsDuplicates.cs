using System;

namespace PracticeCoding.String_Manipulation
{
    public class ContainsDuplicates
    {
        public static void main(string[] args)
        {
            string inputString = "Astronomer";
            Console.WriteLine(DoesContainDuplicates(inputString));
            Console.ReadLine();
        }

        public static bool DoesContainDuplicates(string inputString)
        {
            char[] chars = inputString.ToCharArray();
            Array.Sort(chars);
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] == chars[i - 1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
