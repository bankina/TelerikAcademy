using System;
using System.IO;
using System.Text;

class Test
{
    public static void Main()
    {
        StreamReader reader = new StreamReader("../../../sometext.txt");
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);    
                }
                line = reader.ReadLine();
            }
        }



        //StreamReader reader = new StreamReader("cyr.txt", Encoding.GetEncoding("windows-1251"));
        // Read the file contents here ...
        //reader.Close();


    }
}