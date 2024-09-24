using RaceSim.Vehicles;

namespace RaceSim.Races
{
    internal class AirRace : Race
    {
        public AirRace()
        {
            name = "Воздушная гонка";
        }

        public override bool VehicleMathcesRace(Vehicle vehicle)
        {
            return vehicle is AirVehicle;
        }
    }
}
