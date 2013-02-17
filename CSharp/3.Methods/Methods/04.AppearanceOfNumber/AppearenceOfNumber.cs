using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.AppearanceOfNumber
{
    class AppearenceOfNumber
    {
        public static void FindNumberOccurences(int[] array,int number)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 2, 6, 8, 7, 7, 7, 9, 6, 2, 3, 4, 5, 6, 6, 8 };
            Console.WriteLine("Enter a number [1 to 9] and find out how many times it apears in the array: ");
            int number = int.Parse(Console.ReadLine());
            FindNumberOccurences(array, number);
        }
    }
}
