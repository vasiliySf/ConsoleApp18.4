using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18._4
{
    class ConcreteCommand : Command
    {
        Receiver receiver;
        public ConcreteCommand(Receiver r)
        {
            receiver = r;
        }
        public override void GetDescription()
        {
            Console.WriteLine("Получить описание видео!");
            receiver.GetDescription();
        }

        public override void VideoSave()
        {
            receiver.VideoSave();            
        }
    }
}
