using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _04.CompareFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../sometext.txt");
            StreamReader reader2 = new StreamReader("../../../someothertext.txt");
           
            int equalLines = 0;
            int diffLines = 0;

            using (reader)
            using (reader2)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                string line2 = reader2.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    if (line == line2)
                    {
                        equalLines++;
                    }
                    else
                    {
                        diffLines++;
                    }
                    line = reader.ReadLine();
                    line2 = reader2.ReadLine();
                }
            }

            Console.WriteLine("Equal lines = "+equalLines);
            Console.WriteLine("Different lines = "+diffLines);
        }
    }
}
