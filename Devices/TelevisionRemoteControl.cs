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

        private readonly string exceptionMessageBeginning = "No television is connected.";

        public TelevisionRemoteControl()
        {
            Console.WriteLine(exceptionMessageBeginning);
        }

        public TelevisionRemoteControl(Television television)
        {
            SetTelevision(television);
        }

        public void SetTelevision(Television television)
        {
            this.Television = television;
            this.Volume = television.Volume;
        }

        public void VolumeUp()
        {
            try
            {
                this.Television.VolumeUp();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine($"{exceptionMessageBeginning} Increase volume not possible.");
            }
        }

        public void VolumeDown()
        {
            try
            {
                this.Television.VolumeDown();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine($"{exceptionMessageBeginning} Decrease volume not possible.");
            }
        }

        public void PressPowerButton()
        {
            try
            {
                this.Television.PressPowerButton(); 
            }
            catch (NullReferenceException)
            {
                Console.WriteLine($"{exceptionMessageBeginning} Powerbutton press has no effect");
            }
        }
    }
}
