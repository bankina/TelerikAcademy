using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st way
            //int n = int.Parse(Console.ReadLine());
            //int[] numbers = new int[n];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    string binary = Convert.ToString(numbers[i], 2).PadLeft(32, '0');
            //    Console.WriteLine(binary);
            //}

            // 2nd way
            int BinaryHolder;
            char[] BinaryArray;
            string BinaryResult = "";
            int @decimal = int.Parse(Console.ReadLine());

            while (@decimal > 0)
            {
                BinaryHolder = @decimal % 2;
                BinaryResult += BinaryHolder;
                @decimal = @decimal / 2;
            }

            BinaryArray = BinaryResult.ToCharArray();
            Array.Reverse(BinaryArray);
            BinaryResult = new string(BinaryArray);
            Console.WriteLine(BinaryResult);

           
        }
    }
}
