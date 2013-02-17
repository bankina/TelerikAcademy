using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //vij dali e vqrna
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int result;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            int position = Array.BinarySearch(array, k);

            if (array[0] > k)
            {
                Console.WriteLine("There is no number in this array less or equal to number k.");
            }
            else if (position < 0)
            {
                result = array[~position - 1];
                Console.WriteLine(result);
            }
            else if (position >= 0)
            {
                result = array[position];
                Console.WriteLine(result);
            }
        }
    }
}
