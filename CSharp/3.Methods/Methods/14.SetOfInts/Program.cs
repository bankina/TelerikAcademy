using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14.SetOfInts
{
    class Program
    {
        public static int Min(params int[] elements)
        {
            if (elements.Length <= 0)
            {
                return 0;
            }
            int min = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] < min)
                {
                    min = elements[i];
                }
            }
            return min;
        }

        public static int Max(params int[] elements)
        {
            if (elements.Length <= 0)
            {
                return 0;
            }
            int max = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }
            return max;
        }

        public static double Avrg(params int[] elements)
        {
            long sum = Sum(elements);
            return sum / elements.Length;
        }

        public static long Sum(params int[] elements)
        {
            long sum = 0;
            foreach (int element in elements)
            {
                sum += element;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Min(2, 3, 6, -2, 6, 20, -23, 32, 0, 2, -4));
            Console.WriteLine(Max(2, 3, 6, -2, 6, 20, -23, 32, 0, 2, -4));
            Console.WriteLine(Sum(2, 3, 6, -2, 6, 20, -23, 32, 0, 2, -4));
            Console.WriteLine(Avrg(2, 3, 6, -2, 6, 20, -23, 32, 0, 2, -4));
        }
    }
}
