using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Racing.Transports
{
    // Наземный транспорт
    abstract class Ground : Transport
    {
        public abstract double TimeBeforeRest { get; }
        public abstract double RestDuration(int restCount);

        public override double CalculateTime(double distance)
        {
            double time = 0;
            double traveledDistance = 0;
            int restCount = 0;

            while (traveledDistance < distance)
            {

                if (distance - traveledDistance < Speed * TimeBeforeRest)
                {
                    time += (distance - traveledDistance) / Speed;
                    traveledDistance = distance;
                }
                else
                {
                    time += TimeBeforeRest;
                    traveledDistance += Speed * TimeBeforeRest;
                    restCount++;
                    time += RestDuration(restCount);
                }
            }
            return time;
        }

    }
}
