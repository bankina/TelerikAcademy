using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.ReadNumber
{
    class Program
    {
        public static int ReadNumber(int start, int end)
        {
            int n;
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n < start || n > end)
                {
                    throw new ArgumentException();
                }
            }
            catch (System.FormatException)
            {
                throw new ArgumentException();
            }
            return n;
        }
        static void Main(string[] args)
        {
            try
            {
                int a = 1;
                for (int i = 0; i < 10; i++)
                {
                    a = ReadNumber(a, 100);    
                }
                
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid number");
            }
            
        }
    }
}
