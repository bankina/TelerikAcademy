using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            char[] array;
            string result="";
            int binaryHolder;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                while (numbers[i] > 0)
                {
                    binaryHolder = numbers[i] % 16;
                    result += binaryHolder;
                    numbers[i] = numbers[i] / 16;
                    if (binaryHolder == 10)
                    {
                        binaryHolder = 'A';
                    }

                }
           
                    array = result.ToCharArray();
                    Array.Reverse(array);
                    result = new string(array);
                    Console.WriteLine(result);                
            }
            
            
        }
    }
}
