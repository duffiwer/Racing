using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Races
{
   abstract class Race
    {
        public double Distance { get; set; }
        public List<Transport> participants = new List<Transport>();
        abstract public void RegisterTransport(Transport transport);
        public void StartRace()
        {
            if (participants.Count == 0)
            {
                throw new InvalidOperationException("В гонке должно участвовать хотя бы одно транспортное средство.");
            }

            Transport winner = null;
            double bestTime = double.MaxValue;

            foreach (var transport in participants)
            {
                double time = transport.CalculateTime(Distance);
                Console.WriteLine($"{transport.Name} прошел дистанцию за {Math.Round(time, 2)} единиц времени.");
                if (time < bestTime)
                {
                    bestTime = time;
                    winner = transport;
                }
            }
            Console.WriteLine($"Победитель: {winner.Name} с временем {Math.Round(bestTime, 2)}.");
        }
    }
}
