using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _11.DeletePrefixWords
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../sometesttexttoreplace.txt");
            StreamWriter streamWriter = new StreamWriter("../../../replacedtextOnlyTextWordsReplaced.txt");
            string output = "";
            string searched = "test";

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
                        if (currLine[i].IndexOf(searched) == 0)
                        {
                            bool notWord = false;
                            for (int j = 0; j < currLine[i].Length; j++)
                            {
                                if ((currLine[i][j] < 'a' || currLine[i][j] > 'z') && (currLine[i][j] < 'A' || currLine[i][j] > 'Z') && (currLine[i][j] < '0' || currLine[i][j] > '9') && currLine[i][j] != '_')
                                {
                                    notWord = true;
                                    break;
                                }
                            }
                            output += notWord ? currLine[i] + " " : "";
                        }
                        else
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
