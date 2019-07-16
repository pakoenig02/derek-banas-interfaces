using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasInterfaces.Interfaces
{
    interface IVolumeControl
    {
        int Volume { get; set; }
        void VolumeUp();
        void VolumeDown();
    }
}
