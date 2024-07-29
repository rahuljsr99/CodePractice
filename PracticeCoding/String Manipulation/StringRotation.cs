using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding.String_Manipulation
{
    public class StringRotation
    {
        public static void main(string[] args)
        {
            string inputString1 = "abcd";
            string inputString2 = "abdc";
            Console.WriteLine(AreRotated(inputString1, inputString2));
            Console.ReadLine();
        }
        public static bool AreRotated(string inputString1, string inputString2)
        {
            string concatinatedString = inputString1 + inputString1;

            if (concatinatedString.Contains(inputString2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
