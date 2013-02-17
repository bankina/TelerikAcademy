using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _06.SortName
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../names.txt");
            StreamWriter streamWriter = new StreamWriter("../../../sortedNames.txt");
            List<string> names = new List<string>();
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    names.Add(line);
                    line = reader.ReadLine();
                }
            }
            names.Sort();
            using (streamWriter)
            {
                for (int i = 0; i < names.Count; i++)
                {
                    streamWriter.Write(names.ElementAt(i) + '\n');
                }
            }
        }
    }
}
