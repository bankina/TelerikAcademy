using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _02.ConcatFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../sometext.txt");
            StreamReader reader2 = new StreamReader("../../../someothertext.txt");
            StreamWriter streamWriter = new StreamWriter("../../../concat.txt");
            string output = "";
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    output += line+'\n';
                    line = reader.ReadLine();
                }
            }

            using (reader2)
            {
                int lineNumber = 0;
                string line = reader2.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    output += line + '\n';
                    line = reader2.ReadLine();
                }
            }
            
            using (streamWriter)
            {
                streamWriter.WriteLine(output);
            }
        }
    }
}
