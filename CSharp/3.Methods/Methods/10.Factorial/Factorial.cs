using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _10.Factorial
{
    class Factorial
    {
        public static BigInteger FactorialNumbers(int number)
        {
            
            BigInteger factorial = 1;
            for (int i = 1; i < number; i++)
			{
			    factorial *= (BigInteger)i;
			}
            factorial *= number;
            return factorial;
        }
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(FactorialNumbers(i));
                Console.WriteLine();
            }
        }
    }
}
