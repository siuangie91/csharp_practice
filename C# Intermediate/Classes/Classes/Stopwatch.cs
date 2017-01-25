using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Stopwatch
    {
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public TimeSpan duration { get; set; }

        public void Start()
        {
            if(startTime != DateTime.MinValue)
            {
                throw new InvalidOperationException("Cannot start Stopwatch multiple times without stopping.");
            }
            startTime = DateTime.Now;
        }

        public void Stop()
        {
            if(startTime == DateTime.MinValue)
            {
                throw new InvalidOperationException("Stopwatch was never started.");
            }
            endTime = DateTime.Now;
        }

        public TimeSpan CalcDuration()
        {
            if(startTime == DateTime.MinValue || endTime == DateTime.MinValue)
            {
                throw new InvalidOperationException("Invalid startTime or endTime");
            }
            else
            {
                return (endTime - startTime);
                Clear();
            }
        }

        public void Clear()
        {
            startTime = DateTime.MinValue;
            endTime = DateTime.MinValue;
        }
    }
}
