using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.CheckIfBigger
{
    class CheckIfBigger
    {
        public static void CheckNeighbours(int[] array, int index)
        {
            if (index == 0 || index == array.Length - 1)
            {
                Console.WriteLine("The elements at first and last position cannot be compared.");
            }
            else if(index < 0 || index > array.Length)
            {
                Console.WriteLine("You must enter index in the given range");
            }
            else
            {
                if (array[index] > array[index + 1] && array[index] > array[index - 1])
                {
                    Console.WriteLine("The element is bigger than his 2 neighbours.");
                }
                else
                {
                    Console.WriteLine("The element is not bigger than his 2 neighbours.");
                }
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter an index and find out if the number is bigger than his two neighbour elements: ");
            int index = int.Parse(Console.ReadLine());
            int[] array = { 1, 2, 1, 3, 3, 4, 3, 5, 2 };
            CheckNeighbours(array, index);           
        }
    }
}
