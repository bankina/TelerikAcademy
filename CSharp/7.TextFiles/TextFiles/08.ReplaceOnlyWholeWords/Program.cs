using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _08.ReplaceOnlyWholeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../sometexttoreplace.txt");
            StreamWriter streamWriter = new StreamWriter("../../../replacedtextOnlyWholeWords.txt");
            string output = "";
            string searched = "start";
            string replaceWith = "finish";
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
                        if (currLine[i] == searched)
                        {
                            currLine[i] = replaceWith;
                        }
                        output += currLine[i]+" ";
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
