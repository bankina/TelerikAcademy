using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.SortArrayLargestString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Ruse", "Kaspichan", "Pernik", "Sofia", "Telerik" };
            int[] length=new int[array.Length];
            for (int i = 0; i < length.Length; i++)
            {
                length[i] = array[i].Length;
            }
            Array.Sort(length, array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            
        }
    }
}
