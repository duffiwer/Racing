using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Transports
{
    // Воздушный транспорт
    abstract class Air : Transport
    {
        public abstract double AccelerationFactor { get; }

        public override double CalculateTime(double distance)
        {
            return distance / (Speed * AccelerationFactor);
        }
    }
}
