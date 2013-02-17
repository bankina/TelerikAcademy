using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.StringMatrixSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[,] matrix =  {{"s", "qq", "s",  "s"},
            //                     {"pp", "pp", "s", "s"},
            //                     {"pp", "qq", "s", "s"}};
            string[,] matrix = {{"ha","fifi","ho","hi"},
                                {"fo","ha","hi","xx"},
                                {"xxx","ho","ha","xx"}};
            int maxCount = 0;
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                count = 0;
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {

                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        count++;
                        //Console.WriteLine(count);
                    }
                    else
                    {
                        maxCount = maxCount < count ? count : maxCount;
                        count = 1;
                    }                    
                }
                maxCount = maxCount < count ? count : maxCount;
            }
            count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                count = 0;
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    
                    if (matrix[col, row] == matrix[col, row + 1])
                    {
                        count++;
                        //Console.WriteLine(count);
                    }
                    else
                    {
                        maxCount = maxCount < count ? count : maxCount;
                        count = 1;
                    }
                }
                maxCount = maxCount < count ? count : maxCount;
            }
            count = 0;
            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                int row = i;
                int col = 0;
                while (row < matrix.GetLength(0) - 1 && col < matrix.GetLength(0) - 1)
                {
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                        //Console.WriteLine(count);
                    }
                    else
                    {
                        maxCount = maxCount < count ? count : maxCount;
                        count = 1;
                    }
                    row++;
                    col++;
                }
                maxCount = maxCount < count ? count : maxCount;
            }

            count = 0;
            for (int i = 1; i < matrix.GetLength(1); i++)
            {
                int row = 0;
                int col = i;
                while (row < matrix.GetLength(1)-1 && col < matrix.GetLength(1)-1)
                {
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                        //Console.WriteLine(count);
                    }
                    else
                    {
                        maxCount = maxCount < count ? count : maxCount;
                        count = 1;
                    }
                    row++;
                    col++;
                }
                maxCount = maxCount < count ? count : maxCount;
            }

            Console.WriteLine("MAX COUNT == "+maxCount);
        }
    }
}
