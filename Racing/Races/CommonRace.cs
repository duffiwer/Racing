using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Races
{
    internal class CommonRace:Race
    {
        override public void RegisterTransport(Transport transport) {
           participants.Add(transport); 
        }   
            
    }
}
