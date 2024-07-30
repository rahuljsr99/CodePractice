using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding.Array_Manipulation
{
    public class AlternateSum
    {
        public static void main(string[] args)
        {
            int size = 6;
            string input = "6 8 5 4 2 3";

            Console.WriteLine(GetAlternateSum(input,size));
        }
        public static int GetAlternateSum(string input,int size)
        {
            int sum = 0;
            
            string[] arr  = input.Split(" ");
            Array.Sort(arr);

            int sum1 = 0, sum2 = 0;

            for(int i = 0; i<arr.Length; i++)
            {
                if(i%2 == 0)
                {
                    sum1 += Convert.ToInt32(arr[i]);
                }
                else
                {
                    sum2 += Convert.ToInt32(arr[i]);
                }
            }
            

            if (sum1 > sum2)
            {
                sum = sum1;
            }
            else
            {
                sum = sum2;
            }
            return sum;
        }
    }
}
