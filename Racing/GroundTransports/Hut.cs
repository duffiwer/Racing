using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Racing.Transports;
namespace Racing
{
    internal class Hut : Ground
    {
        public override string Name => "Избушка на курьих ножках";
        public override double Speed => 20;
        public override double TimeBeforeRest => 50;

        public override double RestDuration(int restCount)
        {
            return restCount * 3; // 
        }
       
    }
}
