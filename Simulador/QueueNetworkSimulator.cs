using Simulator.Generators;
using Simulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    public class QueueNetworkSimulator
    {
        private int queue { get; set; }
        private TimeSpan lastTs { get; set; }
        private LinearCongruentialGenerator gen { get; set; }

        public QueueNetworkSimulator()
        {
            gen = new LinearCongruentialGenerator();
        }

        public void Run(TimeInterval clientArrival, TimeInterval clientAttendence, int serverCount, int queueCapacity)
        {
            // TODO: Como fazer o loop de execução?
            while (true)
            {
                // TODO: Como os eventos de CHEGADA e SAIDA entram/são gerados?
                float rnd = gen.Generate(5, 20, 5, 1, 1).First();
                if (rnd <= 0.5)
                {
                    handleArrival();
                }
                else
                {
                    handleExit();
                }
            }
        }

        private void handleArrival()
        {
            TimeSpan timeDelta = getTimeDelta();
            if (queue < 3)
            {
                queue++;
                
                if (queue <= 1)
                {
                    // TODO: Como funciona o agendamento de saida?
                    scheduleExit(timeDelta + rnd(3..6));
                }
            }

            // TODO: Como funciona o agendamento de entrada?
            scheduleArrival(timeDelta + rnd(1..2));
        }

        private void handleExit()
        {
            TimeSpan timeDelta = getTimeDelta();
            queue--;
            if (queue >= 1)
            {
                // TODO: Como funciona o agendamento de saida?
                scheduleExit(timeDelta + rnd(3..6));
            }
        }

        private TimeSpan getTimeDelta()
        {
            TimeSpan timeDelta = DateTime.Now.TimeOfDay.Subtract(lastTs);
            return timeDelta;
        }
    }
}
