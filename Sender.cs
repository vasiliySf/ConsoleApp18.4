using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18._4
{
    class Sender
    {
        Command command;
        public Sender() 
        { }

        public void SetCommand(Command com)
        {
            command = com;
        }

        public void Description()
        {
            command.GetDescription();
        }
        public void SaveDisk()
        {
            command.VideoSave();
        }
    }
   
}
