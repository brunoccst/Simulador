using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Models
{
    public class TimeInterval
    {
        private const int startIdx = 0;
        private const int endIdx = 1;

        private float[] array = new float[2];

        public float Start
         {
            get
            {
                return array[startIdx];
            }
            set  
            {
                array[startIdx] = value;
            }
        }

        public float End
        {
            get
            {
                return array[endIdx];
            }
            set
            {
                array[endIdx] = value;
            }
        }

        public TimeInterval(float start, float end)
        {
            Start = start;
            End = end;
        }

        public bool IsValid()
        {
            return
                    Start >= 0
                &&  End >= 0
                &&  Start <= End;
        }
    }
}
