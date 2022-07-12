using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;
using YoutubeExplode.Converter;

namespace ConsoleApp18._4
{
    class Receiver:Command
    {
        
        YoutubeClient youtubeClient;
        string videoUrl {get; set;}
        string outputFilePath {get; set;}   
        public Receiver(string videoUrl, string OutputFilePath)
        {
            this.videoUrl = videoUrl;            
            outputFilePath = OutputFilePath;
            youtubeClient = new YoutubeClient();
        }
        public override void GetDescription()
        {
            var video = youtubeClient.Videos.GetAsync(videoUrl);
            
            Console.WriteLine($"Заголовок {video.Result.Title}");
            Console.WriteLine($"Автор {video.Result.Author}");
            Console.WriteLine($"Продолжительность {video.Result.Duration}");
        }
        public override async void VideoSave()
        {
            Console.WriteLine("Запись видео на жесткий диск!");
            await youtubeClient.Videos.DownloadAsync(videoUrl, outputFilePath/*, builder => builder.SetPreset(ConversionPreset.UltraFast)*/);
        }
    }
}
