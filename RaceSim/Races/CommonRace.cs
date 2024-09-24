using RaceSim.Vehicles;

namespace RaceSim.Races
{
    internal class CommonRace : Race
    {
        public CommonRace() 
        { 
            name = "Общая гонка";
        }

        public override bool VehicleMathcesRace(Vehicle vehicle)
        {
            return true;
        }
    }
}
