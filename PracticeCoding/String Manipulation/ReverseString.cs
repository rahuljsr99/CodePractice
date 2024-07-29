using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding.String_Manipulation
{
    public class ReverseString
    {
        public static void main(string[] args)
        {
            string inputString = "Hi I AM";
            string reversedString = ReversingString(inputString);
            Console.Write(reversedString);
            Console.ReadLine();

        }
        public static string ReversingString(string str)
        {
            char[] charArray = str.ToCharArray();
            char[] reversedArray = new char[charArray.Length];
            for (int i = 0; i < charArray.Length; i++)
            {
                reversedArray[i] = charArray[charArray.Length-1 - i]; 
            }
            string reversedString = new string(reversedArray);
            return reversedString;
        }
    }
}
