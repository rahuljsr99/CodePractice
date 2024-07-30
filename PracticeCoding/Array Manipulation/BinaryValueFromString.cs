using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding.Array_Manipulation
{
    public class BinaryValueFromString
    {
        public static void main(string[] args)
        {
            string input = "zoo";

            Console.WriteLine(GetBinaryNumber(input));
            Console.ReadLine();
        }
        public static int GetBinaryNumber(string input)
        {
            int binaryNumber = GetBinarynumberFromString(input);
            return binaryNumber;
        }
        public static int GetBinarynumberFromString(string input)
        {
            string binaryNumber = "";
            foreach(char ch in input)
            {
                if ("aeiou".Contains(ch))
                {
                    binaryNumber += "0";
                }
                else
                {
                    binaryNumber += "1";
                }
            }
            return Convert.ToInt32(binaryNumber, 2);
        }
    }
}
