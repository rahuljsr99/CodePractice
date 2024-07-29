using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding.String_Manipulation
{
    public class Palindrome
    {
        public static void main(string[] args)
        {
            string inputString = "madam";
            bool IsPalindromeValue = IsPalindrome(inputString);
            Console.Write(IsPalindrome);

        }
        public static bool IsPalindrome(string str)
        {
            if(string.IsNullOrEmpty(str)) return false;

            char[] charArray = str.ToCharArray();
            char[] reversedArray = new char[charArray.Length];
            
            for(int i = 0; i<= charArray.Length-1; i++)
            {
                reversedArray[i] = charArray[charArray.Length-1-i];
            }
            string reversedString = new string(reversedArray);

            if (reversedString.Equals(str)) return true;
            else return false;
        }
    }
}
