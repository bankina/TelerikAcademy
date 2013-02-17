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
                string binary = Console.ReadLine();
                string output = "";

                int rest = binary.Length % 4;
                if (rest != 0)
                {
                    binary = new string('0', 4 - rest) + binary;
                }

                for (int i = 0; i <= binary.Length - 4; i += 4)
                {
                    output += string.Format("{0:X}", Convert.ToByte(binary.Substring(i, 4), 2));
                }
                Console.WriteLine(output);
            
           
            

        }
    }
}
