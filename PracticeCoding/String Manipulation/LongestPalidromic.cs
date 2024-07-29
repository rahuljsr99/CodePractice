using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding.String_Manipulation
{
    public class LongestPalindromic
    {//To beCompleted
        public static void main(string[] args)
        {
            string inputString = "madam";
            string longestPalindromicString = LongestPalindromicString(inputString);
            Console.Write("");

        }
        public static string LongestPalindromicString(string str)//babad
        {
            if(string.IsNullOrEmpty(str)) return "";
            char[] strArray = str.ToCharArray();

            return null;
        }
    }
}
