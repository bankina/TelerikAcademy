using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _05.MatrixMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =  new int[0,0];
            StreamReader reader = new StreamReader("../../../matrix.txt");
            StreamWriter streamWriter = new StreamWriter("../../../matrixMaxSum.txt");
            int maxSum = 0;
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    if (lineNumber == 1)
                    {
                        matrix = new int[int.Parse(line), int.Parse(line)];
                    }
                    else
                    {
                        string[] matrixLine = line.Split();
                        for (int i = 0; i < matrixLine.Length; i++)
                        {
                            matrix[lineNumber - 2, i] = int.Parse(matrixLine[i]);
                        }
                    }
                    line = reader.ReadLine();
                }
            }

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int sum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];
                    maxSum = sum > maxSum ? sum : maxSum;
                }
            }

            using (streamWriter)
            {
                streamWriter.WriteLine(maxSum);
            }
        }
    }
}
