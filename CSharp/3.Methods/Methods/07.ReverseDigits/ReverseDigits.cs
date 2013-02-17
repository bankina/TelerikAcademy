using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.ReverseDigits
{
    class ReverseDigits
    {
        public static string Reverse(decimal number)
        {
            string num = number.ToString();
            char[] reversed = num.ToCharArray();
            Array.Reverse(reversed);
            return new string(reversed);
            
        }
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine(Reverse(number));
            
        }
    }
}
