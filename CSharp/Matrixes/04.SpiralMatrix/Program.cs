using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14.Spriral
{
    class Spiral
    {
        static void Main(string[] args)
        {
            int numberOfRotation = 0;
            int n = 7;
            int[,] output = new int[n, n];
            int count = 0;
            while ((count <= n * n) && ((n + 1) / 2 > numberOfRotation))
            {
                for (int j = numberOfRotation; j < n - numberOfRotation; j++)
                {
                    count++;
                    //Console.WriteLine(count + " -- 1");
                    output[numberOfRotation, j] = count;
                }
                for (int j = numberOfRotation + 1; j < n - numberOfRotation; j++)
                {
                    count++;
                    //Console.WriteLine(count + " -- 2");
                    output[j, n - numberOfRotation - 1] = count;
                }
                for (int j = n - numberOfRotation - 1; j > numberOfRotation; j--)
                {
                    count++;
                    //Console.WriteLine(count + " -- 3");
                    output[n - numberOfRotation - 1, j - 1] = count;
                }
                for (int j = n - numberOfRotation - 1; j > numberOfRotation + 1; j--)
                {
                    count++;
                    //Console.WriteLine(count + " -- 4");
                    output[j - 1, numberOfRotation] = count;
                }
                numberOfRotation++;//kolko pati 6te vartqt tziklite
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(output[i, j].ToString().PadLeft(3, ' '));
                }
                Console.WriteLine();
            }
        }
    }
}
