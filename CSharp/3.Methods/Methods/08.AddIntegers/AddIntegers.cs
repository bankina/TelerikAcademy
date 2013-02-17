using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _08.AddIntegers
{
    class AddIntegers
    {
        static void Main(string[] args)
        {
            BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
            BigInteger secondNum = BigInteger.Parse(Console.ReadLine());
            char[] smallerArray = firstNum.ToString().Length >= secondNum.ToString().Length ?  secondNum.ToString().ToCharArray() : firstNum.ToString().ToCharArray();
            Array.Reverse(smallerArray);

            char[] biggerArray = firstNum.ToString().Length < secondNum.ToString().Length ? secondNum.ToString().ToCharArray() : firstNum.ToString().ToCharArray();
            Array.Reverse(biggerArray);

            char[] result = new char[biggerArray.Length+1];

            int carry = 0;
            
            for (int i = 0; i < smallerArray.Length; i++)
            {
                int c_sum = smallerArray[i] - '0' + biggerArray[i] - '0' + carry;
                if (c_sum > 9)
                {
                    carry = 1;
                    result[i] = (char)((c_sum % 10) + '0');
                }
                else
                {
                    carry = 0;
                    result[i] = (char)(c_sum + '0');
                }
            }

            if (smallerArray.Length != biggerArray.Length)
            {
                //Add longer array
                for (int i = smallerArray.Length; i < biggerArray.Length; i++)
                {
                    result[i] = (char)(biggerArray[i] + carry);
                    carry = 0;
                }
            }
            else
            {
                result[result.Length - 1] = carry != 0 ? (char)(carry + '0') : ' ';
            }

            Array.Reverse(result);
            for (int i = smallerArray.Length == biggerArray.Length ? 0 : 1; i < result.Length; i++)
            {
                
                Console.Write(result[i] != ' ' ? result[i].ToString() : "");
            }
            Console.WriteLine();
        }
    }
}
