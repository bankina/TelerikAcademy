using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.HexadecimalToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            char[] array = hex.ToCharArray();
            int dec;
            int result = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                if (array[i] == 'A')
                {
                    int num = 10;
                    dec = (int)Math.Pow(16, hex.Length - i - 1) * num;
                    result += dec;
                }
                if (array[i] == 'B')
                {
                    int num = 11;
                    dec = (int)Math.Pow(16, hex.Length - i - 1) * num;
                    result += dec;
                }
                if (array[i] == 'C')
                {
                    int num = 12;
                    dec = (int)Math.Pow(16, hex.Length - i - 1) * num;
                    result += dec;
                }
                if (array[i] == 'D')
                {
                    int num = 13;
                    dec = (int)Math.Pow(16, hex.Length - i - 1) * num;
                    result += dec;
                }
                if (array[i] == 'E')
                {
                    int num = 14;
                    dec = (int)Math.Pow(16, hex.Length - i - 1) * num;
                    result += dec;
                }
                if (array[i] == 'F')
                {
                    int num = 15;
                    dec = (int)Math.Pow(16, hex.Length - i - 1) * num;
                    result += dec;
                }
                if (array[i] >='0'&& array[i] <='9')
                {
                    dec = (int)Math.Pow(16, hex.Length-i-1) * (array[i] - '0');
                    result += dec;
                }
            }   
            Console.WriteLine(result);

        }
    }
}
