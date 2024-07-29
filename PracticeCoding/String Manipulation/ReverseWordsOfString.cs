using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding.String_Manipulation
{
    public class ReverseWordsOfString
    {
        public static void main(string[] args)
        {
            string inputString = "The quick brown fox";
            Console.WriteLine(ReverseWords(inputString));
            Console.ReadLine();
        }
        public static string ReverseWords(string inputString)
        {
            string[] words = inputString.Split(" ");
            Array.Reverse(words);

            string reversed = string.Join(" ", words);
           
            return reversed;
          
        }
    }
}
