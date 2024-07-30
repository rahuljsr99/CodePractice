using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding.Array_Manipulation
{
    public class Checksum
    {
        public static void main(string[] args)
        {
            int[] arr = { 1223, 234, 4556, 7235 };
            Console.WriteLine(GetCheckSum(arr));
        }
        public static int GetCheckSum(int[] arr)
        {
            int result = 0;

            foreach (int arrayElement in arr)
            {
                string element = arrayElement.ToString();

                char minSubElement = element.Min();
                char maxSubElement = element.Max();

                element = element.Replace(minSubElement.ToString(),"").Replace(maxSubElement.ToString(), "");

                int elementSum = element.Sum(x => x - '0');
                result += elementSum;
            }

            return result;
        }
    }
}
