using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Transports.AirTransports
{
    class Carpet : Air
    {
        public override string Name => "Ковер-самолет";
        public override double Speed => 15;
        public override double AccelerationFactor => 1.1;
      
    }

}
