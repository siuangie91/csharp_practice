using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class SpeedCamera
    {
        private int SpeedLimit;
        private int CurrentSpeed;
        private int DemeritPoints;

        public void setSpeedLimit()
        {
            Console.WriteLine("Enter the speed limit:");
            SpeedLimit = Convert.ToInt32(Console.ReadLine());
        }

        public void getCurrentSpeed()
        {
            if(SpeedLimit != 0)
            {
                Console.WriteLine("Enter the current speed of the car:");
                CurrentSpeed = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("You must first set a speed limit.");
                setSpeedLimit();
            }
        }

        private void setDemeritPoints()
        {
            double division = (CurrentSpeed - SpeedLimit) / 5;
            DemeritPoints = Convert.ToInt32(Math.Floor(division));
            Console.WriteLine("Demerit points: " + DemeritPoints);
        }

        private void suspendLicense()
        {
            Console.WriteLine("License Suspended");
        }

        public void checkIfSpeeding()
        {
            if(SpeedLimit == 0 || CurrentSpeed == 0)
            {
                if(SpeedLimit == 0)
                {
                    setSpeedLimit();
                }
                else
                {
                    getCurrentSpeed();
                }
            }
            else
            {
                if(SpeedLimit >= CurrentSpeed)
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    setDemeritPoints();

                    if (DemeritPoints >= 12)
                    {
                        suspendLicense();
                    }
                }
            }
        }
    }
}
