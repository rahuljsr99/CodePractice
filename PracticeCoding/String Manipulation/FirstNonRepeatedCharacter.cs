using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding.String_Manipulation
{
    public class FirstNonRepeatedCharacter
    {
        public static void main(string[] args)
        {
            string inputString = "swiss";
            Console.WriteLine(FindFirstNonRepeatedCharacter(inputString));
            Console.ReadLine();
        }
        public static char? FindFirstNonRepeatedCharacter(string input)
        {
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (keyValuePairs.ContainsKey(c))
                {
                    keyValuePairs[c]++;

                }
                else
                {
                    keyValuePairs[c] = 1;
                }
            }

            foreach (char c in input)
            {
                if (keyValuePairs[c] == 1)
                {
                    return c;
                }
            }
            
            return null;
        }
    }
}
