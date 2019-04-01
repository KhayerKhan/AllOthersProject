using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace MicrosoftVirtualAcamedy
{
    class NewClass
    {
        
        static void Main(string[] args)
        {

            WebClient client = new WebClient();
            string reply = client.DownloadString("Http://devskill.com");

            Console.WriteLine(reply);
            File.WriteAllText(@"D:\Text\WriteText.txt", reply);


            Console.ReadLine();

           


        
        

        }
    }
}
