using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _12.RemoveStringFromOtherFile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../sometextwhichwillendwithsomestringsremoved.txt");
            StreamReader removeWordsReader = new StreamReader("../../../removestringsfromthisfile.txt");
            StreamWriter streamWriter = new StreamWriter("../../../replacedtextwithstringsfromthatfileremoved.txt");
            string output = "";
            List<string> searched = new List<string>();

            using (removeWordsReader)
            {
                int lineNumber = 0;
                string line = removeWordsReader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    searched.Add(line);
                    line = removeWordsReader.ReadLine();
                }
            }

            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    string[] currLine = line.Split();
                    for (int i = 0; i < currLine.Length; i++)
                    {
                        if (searched.IndexOf(currLine[i]) == -1)
                        {
                            output += currLine[i] + " ";    
                        }
                    }
                    output += '\n'.ToString();
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
