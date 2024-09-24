using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    abstract class Transport
    {
        public abstract string Name { get; }
        public abstract double Speed { get; }

        // Метод для расчета времени прохождения дистанции
        public abstract double CalculateTime(double distance);
    }


}
