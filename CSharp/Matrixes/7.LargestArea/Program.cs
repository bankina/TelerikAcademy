using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.LargestArea
{
    class Program
    {
        public static char[,] matrix = {  
                            {'1','3','2','2','2','4'},
                            {'3','3','3','2','4','4'},
                            {'4','3','1','2','3','3'},
                            {'4','3','1','3','3','1'},
                            {'4','3','3','3','1','1'}
                         };
        public static char[,] visited = matrix;
        public static char searched;
        public static int currLength = 0;

        public static bool indexInOfRange(int x, int y)
        {
            return (x < matrix.GetLength(0)) && (x >= 0) && (y < matrix.GetLength(1)) && (y >= 0);
        }
        public static void findPath(int x, int y, int length)
        {
            currLength++;
            //Console.WriteLine("HERE FOR {0} {1} -> {2}",x,y,searched);
            if (indexInOfRange(x+1,y) && matrix[x+1,y] == searched && visited[x+1,y] != '#')
            {
                visited[x + 1, y] = '#';
                findPath(x + 1, y,length + 1);
            }
            if (indexInOfRange(x, y + 1) && matrix[x, y + 1] == searched && visited[x, y + 1] != '#')
            {
                visited[x, y + 1] = '#';
                findPath(x , y + 1, length + 1);
            }
            if (indexInOfRange(x - 1, y) && matrix[x - 1, y] == searched && visited[x - 1, y] != '#')
            {
                visited[x - 1, y] = '#';
                findPath(x - 1, y, length + 1);
            }
            if (indexInOfRange(x, y - 1) && matrix[x, y - 1] == searched && visited[x, y - 1] != '#')
            {
                visited[x, y - 1] = '#';
                findPath(x, y - 1, length + 1);
            }
        }
        static void Main(string[] args)
        {
            int maxLength = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    searched = matrix[i, j];
                    matrix[i, j] = '#';
                    visited = matrix;
                    currLength = 0;
                    findPath(i, j, 0);
                    if (currLength > maxLength)
                    {
                        maxLength = currLength;
                    }
                }
            }
            Console.WriteLine(maxLength);
        }
    }
}
