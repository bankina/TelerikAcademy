using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = int.Parse(Console.ReadLine());
                }
            }

            int bestSum = int.MinValue;
            for (int rows = 0; rows < matrix.GetLength(0) -  2; rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - 2; cols++)
                {
                    int sum = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows, cols + 2] + matrix[rows + 1, cols] + matrix[rows + 1, cols + 1] + matrix[rows + 1, cols + 2] + matrix[rows+2,cols] + matrix[rows+2, cols+1] + matrix[rows+2,cols+2];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            }
            Console.WriteLine(bestSum);
           

        }
    }
}
