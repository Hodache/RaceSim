using RaceSim.Vehicles;

namespace RaceSim.Races
{
    internal class GroundRace : Race
    {
        public GroundRace()
        {
            name = "Назменая гонка";
        }

        public override bool VehicleMathcesRace(Vehicle vehicle)
        {
            return vehicle is GroundVehicle;
        }
    }
}
