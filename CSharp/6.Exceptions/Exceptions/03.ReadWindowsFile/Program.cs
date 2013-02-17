using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security;

namespace _03.ReadWindowsFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string text = File.ReadAllText(@"C:\WINDOWS\win.ini");
                Console.WriteLine(text);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Null argument");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid argument");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("File path is too long");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("File directory was not found. Check twice your file path.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found! Check twice your path.");
            }
            catch (IOException)
            {
                Console.WriteLine("There was a problem reading the content of the file");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Make sure you have permission to read this file");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("This operation is not supported by our machine.");
            }
            catch (SecurityException)
            {
                Console.WriteLine("We think this file is a thread for your system.");
            }
        }
    }
}
