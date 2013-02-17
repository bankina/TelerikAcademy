using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.CheckIfBigger
{
    class Program
    {
        public static int CheckNeighbours(int[] array, int index)
        {
            if (array[index] > array[index + 1] && array[index] > array[index - 1])
            {
                return index;
            }
            
            return -1;
        }

        static void Main()
        {
            int[] array = { 1, 1, 1, 2, 1, 3, 2, 5, 1};
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (CheckNeighbours(array,i) != -1)
                {
                    Console.WriteLine(CheckNeighbours(array,i));
                    return;
                }
            }
            Console.WriteLine("-1");
        }
    }
}
