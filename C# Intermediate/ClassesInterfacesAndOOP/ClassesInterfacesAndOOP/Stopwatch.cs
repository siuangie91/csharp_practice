using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInterfacesAndOOP
{
    class Stopwatch
    {
        private static DateTime _startTime;
        private static DateTime _endTime;
        private static bool _isRunning;
        public static void Start()
        {
            if(_isRunning)
            {
                throw new InvalidOperationException("Stopwatch has already been started.");
            } 
            _startTime = DateTime.Now;
            _isRunning = true;
        }

        public static void Stop()
        {
            if (!_isRunning)
            {
                throw new InvalidOperationException("Stopwatch has not been started. No duration to calculate.");
            }
            _endTime = DateTime.Now;
            _isRunning = false;
        }

        public static void Reset()
        {
            if(_endTime == DateTime.MinValue)
            {
                throw new InvalidOperationException("No duration was calculated. Cannot reset.");
            } 
                
            _startTime = DateTime.MinValue;
            _endTime = DateTime.MinValue;
        }

        public static DateTime GetStartTime()
        {
            return _startTime;
        }

        public static DateTime GetEndTime()
        {
            return _endTime;
        }

        public static TimeSpan GetDuration()
        {
            return _endTime - _startTime;
        }
    }
}
