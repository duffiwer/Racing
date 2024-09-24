using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Transports.GroundTransports
{
    class Boots : Ground
    {
        public override string Name => "Сапоги-скороходы";
        public override double Speed => 20;
        public override double TimeBeforeRest => 50;

        public override double RestDuration(int restCount)
        {
            return restCount * 2; // 
        }
      
    }
}
