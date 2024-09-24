using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSim.Vehicles.GroundVehicles
{
    // Кентавр
    internal class Centaur : GroundVehicle
    {
        public Centaur()
        {
            name = "Кентавр";
            speed = 16f;
            timeTillRest = 6f;
            baseRestDuration = 1f;
        }
    }
}
