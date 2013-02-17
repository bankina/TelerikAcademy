using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.GetMax
{
    class GetMax
    {
        public static int getMax(int first, int second)
        {
            return first > second ? first : second;
        }
        static void Main()
        {
            Console.WriteLine("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int num3 = int.Parse(Console.ReadLine());

            int biggest = getMax(num1, num2);
            biggest = getMax(biggest, num3);
            Console.WriteLine("The biggest number of three is {0}:", biggest);
        }
    }
}
