using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasInterfaces
{
    class Program
    {
        //TODO implement DevicesStates enums for electric devices (tv)

        static void Main(string[] args)
        {
            Television television = new Television();
            TelevisionRemoteControl televisionRemoteControl = new TelevisionRemoteControl();

            televisionRemoteControl.VolumeUp();
            televisionRemoteControl.PressPowerButton();

            televisionRemoteControl.SetTelevision(television);
            televisionRemoteControl.PressPowerButton();
            televisionRemoteControl.VolumeUp();

            Console.WriteLine(television.isRunning);

            Console.ReadLine();
        }
    }
}
