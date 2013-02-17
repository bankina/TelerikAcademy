using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _10.ParseXML
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../sometextfilewithsimplexmlinit.txt");
            StreamWriter streamWriter = new StreamWriter("../../../sometextfilewiththeextractedxmlinit.txt");
            string output = "";
            string file = reader.ReadToEnd();

            for (int i = 0; i < file.Length; i++)
            {
                if (file[i] == '<')
                {
                    while (file[i] != '>' && i+1 < file.Length)
                    {
                        i++;
                    }
                }
                else
                {
                    while (file[i] != '<' && i+1 < file.Length)
                    {
                        output += file[i];
                        i++;
                    }
                    if (i + 1 < file.Length)
                    {
                        i--;   
                    }
                    output += "\n";
                }                
            }

            using (streamWriter)
            {
                streamWriter.WriteLine(output);
            }
        }
    }
}
