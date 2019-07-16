using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Television television = new Television();
            TelevisionRemoteControl televisionRemoteControl = new TelevisionRemoteControl();

            televisionRemoteControl.VolumeUp();
            televisionRemoteControl.PressPowerButton();

            televisionRemoteControl.setTelevision(television);
            televisionRemoteControl.PressPowerButton();
            televisionRemoteControl.VolumeUp();

            Console.WriteLine(television.isRunning);

            Console.ReadLine();
        }
    }
}
