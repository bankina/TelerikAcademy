using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.BinToHexDirectly
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a base of a numeral system from 2 to 16: ");
            int sourceBase =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a base of a numeral system from 2 to 16: ");
            int destinationBase=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number: ");
            string number = Console.ReadLine();
            char[] numToChar = number.ToCharArray();
            int result = 0;
            int num;
            for (int i = 0; i < numToChar.Length; i++)
            {
                num = 0;
                if (numToChar[i] >= 'A' && numToChar[i] <= 'F')
                {
                    num = (int)(numToChar[i]);
                    num = num - 55;
                    num = num * Convert.ToInt32(Math.Pow(sourceBase, (numToChar.Length - i - 1)));
                    result += num;
                }
                else if (numToChar[i] >= '0' && numToChar[i] <= '9')
                {
                    num = numToChar[i] - '0';
                    num = num * Convert.ToInt32(Math.Pow(sourceBase, (numToChar.Length - i - 1)));
                    result += num;
                } 
            }
            //Console.WriteLine(result);

            int valueHolder;
            char[] array;
            string finalResult = "";
            int[] resultTochar = new int[result];
            char[] digits = resultTochar.ToString().ToCharArray();

            for (int i = 0; i < digits.Length; i++)
            {
                while (result > 0)
                {
                    valueHolder = result % destinationBase;
                    if (valueHolder == 10)
                    {
                        finalResult += 'A';
                        result = result / destinationBase;
                    }
                    else if (valueHolder == 11)
                    {
                        finalResult += 'B';
                        result = result / destinationBase;
                    }
                    else if (valueHolder == 12)
                    {
                        finalResult += 'C';
                        result = result / destinationBase;
                    }
                    else if (valueHolder == 13)
                    {
                        finalResult += 'D';
                        result = result / destinationBase;
                    }
                    else if (valueHolder == 14)
                    {
                        finalResult += 'E';
                        result = result / destinationBase;
                    }
                    else if (valueHolder == 15)
                    {
                        finalResult += 'F';
                        result = result / destinationBase;

                    }
                    else if (valueHolder>=0 && valueHolder<=9)
                    {
                        finalResult += valueHolder;
                        result = result / destinationBase;
                    }
                    
                }

            }
            array = finalResult.ToCharArray();
            Array.Reverse(array);
            finalResult = new string(array);
            Console.WriteLine(finalResult);
        }

    }

}       
       
