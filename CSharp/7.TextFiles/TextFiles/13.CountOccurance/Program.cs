using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _13.CountOccurance
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../test.txt");
            StreamReader searchForWords = new StreamReader("../../../words.txt");
            StreamWriter streamWriter = new StreamWriter("../../../result.txt");
            
            List<string> searched = new List<string>();
            List<int> occurence = new List<int>();

            using (searchForWords)
            {
                int lineNumber = 0;
                string line = searchForWords.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    searched.Add(line);
                    occurence.Add(0);
                    line = searchForWords.ReadLine();
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
                        int index = searched.IndexOf(currLine[i]);
                        if (index != -1)
                        {
                            occurence[index]++;       
                        }
                    }
                    line = reader.ReadLine();
                }
            }

            using (streamWriter)
            {
                for (int i = 0; i < occurence.Count; i++)
                {
                    int maxIndex = occurence.IndexOf(occurence.Max());
                    streamWriter.WriteLine(searched[maxIndex] + " - " +occurence[maxIndex]);
                    occurence[maxIndex] = -1;
                }
            }
        }
    }
}
