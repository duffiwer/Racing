using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Transports.AirTransports
{
    class Yaga : Air
    {
        public override string Name => "Ступа Бабы Яги";
        public override double Speed => 42;
        public override double AccelerationFactor => 0.5;
        
    }
}
