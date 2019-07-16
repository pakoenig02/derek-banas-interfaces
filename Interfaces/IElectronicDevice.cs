using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasInterfaces
{
    interface IElectronicDevice
    {
        bool isRunning { get; set; }
        void On();
        void Off();
    }
}
