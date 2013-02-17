using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Subproblem a:
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[j, i] = i * n + j + 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(j == 0 ? "" : " ");
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }

            //Subproblem b:
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[j, i] = i * n + j + 1;
                }
                if (i + 1 >= n)
                {
                    break;
                }
                i++;
                for (int j = 0; j < n; j++)
                {
                    arr[j, i] = i * n + (n - j);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(j == 0 ? "" : " ");
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Subproblem c
            int count = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                int row = i;
                int col = 0;
                while (row < n && col < n)
                {
                    arr[row, col] = count;
                    count++;
                    row++;
                    col++;
                }
            }

            for (int i = 1; i < n; i++)
            {
                int row = 0;
                int col = i;
                while (row < n && col < n)
                {
                    arr[row, col] = count;
                    count++;
                    row++;
                    col++;
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,3}", arr[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Subprobem d:
            int numberOfRotation = 0;
            count = 0;
            while ((count <= n * n) && ((n + 1) / 2 > numberOfRotation))
            {
                for (int j = numberOfRotation; j < n - numberOfRotation; j++)
                {
                    count++;
                    arr[j, numberOfRotation] = count;
                }
                for (int j = numberOfRotation + 1; j < n - numberOfRotation; j++)
                {
                    count++;
                    arr[n - numberOfRotation - 1, j] = count;
                }
                for (int j = n - numberOfRotation - 1; j > numberOfRotation; j--)
                {
                    count++;
                    arr[j - 1, n - numberOfRotation - 1] = count;
                }
                for (int j = n - numberOfRotation - 1; j > numberOfRotation + 1; j--)
                {
                    count++;
                    arr[numberOfRotation, j - 1] = count;
                }
                numberOfRotation++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j].ToString().PadLeft(3, ' '));
                }
                Console.WriteLine();
            }
        }

    

       
            
        }
    }



