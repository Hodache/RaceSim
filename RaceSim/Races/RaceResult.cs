using RaceSim.Vehicles;

namespace RaceSim.Races
{
    public class RaceResult
    {
        public Vehicle vehicle { get; set; }
        public float time { get; set; }

        public RaceResult(Vehicle vehicle, float time)
        {
            this.vehicle = vehicle;
            this.time = time;
        }
    }
}
