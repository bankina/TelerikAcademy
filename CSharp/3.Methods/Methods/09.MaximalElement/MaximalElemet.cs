using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.MaximalElement
{
    class MaximalElemet
    {
          public static int[] SortArray(int[] numbers, bool desc = false)
          {
              for (int i = 0; i < numbers.Length; i++)
              {
                  int max = getMax(numbers, i, numbers.Length);
                  int index = Array.IndexOf(numbers, max, i);
                  int temp = numbers[i];
                  numbers[i] = numbers[index];
                  numbers[index] = temp;
              }

              if (desc)
              {
                  Array.Reverse(numbers);
              }
              return numbers;
          }
        
        static void Main(string[] args)
        {
            int[] array = {9,7,1,2,3,4,5,8,6,1,2};
            Console.WriteLine("Enter the array index from which the search for the maximal element starts");
            int start = int.Parse(Console.ReadLine());
            int end = array.Length;

            Console.WriteLine(getMax(array,start, end));

            array = SortArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
        }

        private static int getMax(int[] array, int start, int end)
        {
            int max = int.MinValue;
            for (int i = start; i < end; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
    }
}
