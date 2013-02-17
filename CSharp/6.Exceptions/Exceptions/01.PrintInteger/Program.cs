using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.PrintInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Invalid argument");
                }
                else
                {
                    Console.WriteLine(Math.Sqrt(n));
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Invalid argument");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
