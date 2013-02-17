using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.PrintName
{
    class PrintName
    {
        public static void Print(string name)
        {
            Console.WriteLine("Hello, {1}!", name);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter you name: ");
            string yourName = Console.ReadLine();
            Print(yourName);

        }
    }
}
