using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Transports.AirTransports
{
    class Ship : Air
    {
        public override string Name => "Летучий корабль";
        public override double Speed => 25;
        public override double AccelerationFactor => 1.05;
     
    }
}
