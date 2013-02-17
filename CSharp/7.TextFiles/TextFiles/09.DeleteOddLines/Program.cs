using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _09.DeleteOddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../sometextforoddlinedeleting.txt");
            string output = "";
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 == 0)
                    {
                        output += line + '\n';
                    }
                    line = reader.ReadLine();
                }
            }
            StreamWriter streamWriter = new StreamWriter("../../../sometextforoddlinedeleting.txt");
            using (streamWriter)
            {
                streamWriter.WriteLine(output);
            }
        }
    }
}
