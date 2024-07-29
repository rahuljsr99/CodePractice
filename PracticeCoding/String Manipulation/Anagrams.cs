using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding.String_Manipulation
{
    public class Anagrams
    {
        public static void main(string[] args)
        {
            string inputString1 = "Astronomer";
            string inputString2 = "Moon starer";
            Console.WriteLine(AreAnagrams(inputString1, inputString2));
            Console.ReadLine();
        }
        public static bool AreAnagrams(string inputString1, string inputString2)
        {
            char[] inputArray1 = inputString1.ToLower().Replace(" ","").ToCharArray();
            char[] inputArray2 = inputString2.ToLower().Replace(" ", "").ToCharArray();

            Array.Sort(inputArray1);
            Array.Sort(inputArray2);

            string check1 = new string(inputArray1);
            string check2 = new string(inputArray2);

            if (check1 == check2) return true;
            else return false;
        }
    }
}
