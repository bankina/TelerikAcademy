using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace InsertLineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../sometext.txt");
            StreamWriter streamWriter = new StreamWriter("../../../lineNumbers.txt");
            string output = "";
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    output += lineNumber + ". " + line + '\n';
                    line = reader.ReadLine();
                }
            }

            using (streamWriter)
            {
                streamWriter.WriteLine(output);
            }
        }
    }
}
