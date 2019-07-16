using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DerekBanasInterfaces.Interfaces;

namespace DerekBanasInterfaces
{
    class Television : IElectronicDevice, IVolumeControl, IPowerButton
    {
        public int Volume { get; set; }
        public bool isRunning { get; set; }

        public void PressPowerButton()
        {
            if (isRunning) Off();
            else On();
        }

        public void Off()
        {
            Console.WriteLine("The TV is Off");
            this.isRunning = false;
        }

        public void On()
        {
            Console.WriteLine("The TV is On");
            this.isRunning = true;
        }

        public void VolumeDown()
        {
            if (Volume != 0) Volume--;
            Console.WriteLine($"The TV Volume is at {Volume}");
        }

        public void VolumeUp()
        {
            if (Volume != 100) Volume++;
            Console.WriteLine($"The TV Volume is at {Volume}");
        }
    }
}
