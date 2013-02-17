using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st way:
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a binary number: ");
            string[] binary = new string[n];

            for (int i = 0; i < binary.Length; i++)
            {
                binary[i] = Console.ReadLine();
            }

            for (int i = 0; i < binary.Length; i++)
            {
                string dec = Convert.ToInt32(binary[i], 2).ToString();
                Console.WriteLine(dec);
            }

            //2nd way
            Console.WriteLine("Enter a binary number: ");
            string number = Console.ReadLine();
            char[] numToChar = number.ToCharArray();
            int result = 0;
            for (int i = 0; i < numToChar.Length; i++)
            {
                int num = (int)(numToChar[i] - '0');
                num = num * Convert.ToInt32(Math.Pow (2, (numToChar.Length-i-1)));
                result += num;
            }
            Console.WriteLine(result);
        }
    }
}
