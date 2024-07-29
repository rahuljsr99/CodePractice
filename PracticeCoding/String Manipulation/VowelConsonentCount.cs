using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding.String_Manipulation
{
    public class VowelsAndConsonents
    {
        public static void main(string[] args)
        {
            string inputString = "madam213124s";
            
            Console.WriteLine(CountVowelandConsonent(inputString));
            Console.ReadLine();

        }
        public static (int VowelCount, int Consonent, int Numbers) CountVowelandConsonent(string str)
        {
            if(string.IsNullOrEmpty(str)) return (0,0,0);
            else
            {
                str = str.ToLower();
                int vowelCount = 0, consonentCount = 0, numbers = 0;
                foreach(char c in str)
                {
                    if ("aeiou".Contains(c)) vowelCount++;
                    else if (char.IsLetter(c))
                    {
                        consonentCount++;
                    }
                    else if (char.IsDigit(c)) {
                        numbers++;
                    }
                }
                    
                return (vowelCount, consonentCount, numbers);
            }
        }
    }
}
