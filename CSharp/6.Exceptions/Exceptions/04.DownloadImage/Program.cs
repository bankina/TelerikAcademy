using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace _04.DownloadImage
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string remoteUri = "http://www.devbg.org/img/";
                string fileName = "Logo-BASD.jpg", myStringWebResource = null;

                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + fileName;
                Console.WriteLine("Downloading \"{0}\" from \"{1}\" ..\n", fileName, myStringWebResource);

                myWebClient.DownloadFile(myStringWebResource, fileName);
                Console.WriteLine("Successfully Downloaded File \"{0}\" ", fileName);
            }
            catch (WebException)
            {
                Console.WriteLine("Make sure you are connected to the internet.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("You system does not support operations from this type");
            }
            
        }
    }
}
