using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DerekBanasInterfaces.Interfaces;

namespace DerekBanasInterfaces
{
    class TelevisionRemoteControl : IVolumeControl, IPowerButton
    {
        private Television Television { get; set; }
        public int Volume { get; set; }

        public TelevisionRemoteControl()
        {
            Console.WriteLine("The television remote control has no television to control, please assign one.");
        }

        public TelevisionRemoteControl(Television television)
        {
            setTelevision(television);
        }

        public void setTelevision(Television television)
        {
            this.Television = television;
            this.Volume = television.Volume;
        }

        public void VolumeUp()
        {
            this.Television.VolumeUp();
        }

        public void VolumeDown()
        {
            this.Television.VolumeDown();
        }

        public void PressPowerButton()
        {
            this.Television.PressPowerButton();
        }
    }
}
