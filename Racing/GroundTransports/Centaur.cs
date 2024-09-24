using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Transports.GroundTransports
{
    class Centaur : Ground
    {
        public override string Name => "Кентавр";
        public override double Speed => 40;
        public override double TimeBeforeRest => 20;

        public override double RestDuration(int restCount)
        {
            return Math.Pow(2,restCount ); 
        }
        

    }
}
