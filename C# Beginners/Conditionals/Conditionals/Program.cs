using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var speedCamera = new SpeedCamera();

            speedCamera.setSpeedLimit();
            speedCamera.getCurrentSpeed();

            speedCamera.checkIfSpeeding();
        }
    }
}
