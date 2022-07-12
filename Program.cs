using System;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace ConsoleApp18._4
{

    class Program
    {
        static void Main(string[] args)
        {           
            string outputFilePath = "E:/R/";

            //string videoUrl = "https://www.youtube.com/watch?v=EJr3uAQwGek";
            string videoUrl = "https://www.youtube.com/watch?v=1La4QzGeaaQ";

            Sender sender = new Sender();
            Receiver receiver = new Receiver(videoUrl, outputFilePath);
            sender.SetCommand(receiver);
            sender.Description();
            sender.SaveDisk();
                      
            Console.ReadKey();

        }
    }
}