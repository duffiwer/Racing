using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Racing.Transports;

namespace Racing.Races
{
    internal class AirRace:Race
    {
        override public void RegisterTransport(Transport transport)
        {

            if (!(transport is Air))
            {
                throw new InvalidOperationException("Это транспортное средство недоступно в воздушной гонке.");
            }
            else participants.Add(transport); ;
        }
    }
}
