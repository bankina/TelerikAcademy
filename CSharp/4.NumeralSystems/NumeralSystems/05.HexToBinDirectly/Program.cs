using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.HexToBinDirectly
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string hex = Console.ReadLine();
            char[] array = hex.ToCharArray();
            string num = "";
            string result="";
            for (int i = 0; i < array.Length; i++)
            {
                switch (array[i])
                {
                    case 'A':
                        num = Convert.ToString(10, 2).PadLeft(4, '0');
                        result += num;
                        break;
                    case 'B':
                        num = Convert.ToString(11, 2).PadLeft(4, '0');
                        result += num;
                        break;
                    case 'C':
                        num = Convert.ToString(12, 2).PadLeft(4, '0');
                        result += num;
                        break;
                    case 'D':
                        num = Convert.ToString(13, 2).PadLeft(4, '0');
                        result += num;
                        break;
                    case 'E':
                        num = Convert.ToString(14, 2).PadLeft(4, '0');
                        result += num;
                        break;
                    case 'F':
                        num = Convert.ToString(15, 2).PadLeft(4, '0');
                        result += num;
                        break;
                    default:
                        break;
                }
                if (array[i] >= '0' && array[i] <= '9')
                {
                    num = Convert.ToString(array[i], 2).PadLeft(4, '0');
                    result += num;
                }
            }
            Console.WriteLine(result);
            
        }
    }
}
