using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Transports.GroundTransports
{
    class Carriage:Ground
    {
        public override string Name => "Карета-тыква";
        public override double Speed => 10;
        public override double TimeBeforeRest => 30;

        public override double RestDuration(int restCount)
        {
            return restCount == 1 ? 5 : 10;
        }
      
    }
}
