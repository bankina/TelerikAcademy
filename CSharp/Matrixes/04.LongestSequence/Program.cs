using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.LongestSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix = {
                                   {"s","qq", "s"},
                                   {"pp","q", "s"},
                                   {"qq","qq", "s"}
                               };
            int count = 0;
            int longest = 0;
            string longestSymbol = "";
            string currSymbol = "";
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                count = 1;
                for (int cols = 0; cols < matrix.GetLength(1)-1; cols++)
                {
                    if (count == 1)
                    {
                        currSymbol = matrix[rows, cols].ToString();
                    }

                    if (matrix[rows, cols] == matrix[rows, cols + 1])
                    {
                        count++;
                    }
                    else
                    {
                        if (count > longest)
                        {
                            longest = count;
                            longestSymbol = currSymbol;
                        }
                        count = 1;
                    }
                }
            }
            Console.WriteLine(longest);
            Console.WriteLine(longestSymbol);


        }
    }
}
