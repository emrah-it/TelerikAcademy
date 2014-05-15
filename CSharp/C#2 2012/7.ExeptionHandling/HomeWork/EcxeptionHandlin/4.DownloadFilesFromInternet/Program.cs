using System;
using System.Net;
using System.IO;
class Program
{
    static void Main()
    {
        using (WebClient webClient = new WebClient())
        {
            string folder = Directory.GetCurrentDirectory() + "aaa.jpg";
            try
            {
                webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", folder);
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("No files to download");
            }
            catch (WebException)
            {
                Console.WriteLine("WebExpetion");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("NotSupportedException");
            }
        }
    }
}
