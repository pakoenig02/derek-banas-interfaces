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
            TelevisionRemoteControl televisionRemoteControl = new TelevisionRemoteControl(television);
            
            televisionRemoteControl.PressPowerButton();
            televisionRemoteControl.PressPowerButton();
            televisionRemoteControl.PressPowerButton();

            Console.WriteLine(television.isRunning);
            
            Console.ReadLine();
        }
    }
}
