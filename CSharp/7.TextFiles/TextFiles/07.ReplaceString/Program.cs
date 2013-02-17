using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _07.ReplaceString
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../sometexttoreplace.txt");
            StreamWriter streamWriter = new StreamWriter("../../../replacedtext.txt");
            StringBuilder text = new StringBuilder();
            text.Append(reader.ReadToEnd());            
            text.Replace("start","finish");

            using (streamWriter)
            {
                streamWriter.WriteLine(text);
            }
        }
    }
}
