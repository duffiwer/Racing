using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Transports.AirTransports
{
    class Broom: Air
    {
        public override string Name => "Метла";
        public override double Speed => 11;
        public override double AccelerationFactor => 1.4;
        
    }
}
