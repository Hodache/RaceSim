using RaceSim.Vehicles;

namespace RaceSim.Races
{
    public abstract class Race
    {
        public string name;
        public float distance;
        List<Vehicle> vehicles { get; } = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            if (!VehicleMathcesRace(vehicle))
            {
                throw new System.ArgumentException("Vehicle does not match");
            }
            vehicles.Add(vehicle);
        }

        public void SetDistance(float distance)
        {
            if (distance <= 0)
            {
                throw new System.ArgumentException("Distance must be greater than 0");
            }

            this.distance = distance;
        }

        public List<RaceResult> StartRace()
        {
            List<RaceResult> results = new List<RaceResult>();
            foreach (var vehicle in vehicles)
            {
                RaceResult vehicleResult = new(vehicle, vehicle.GetRideTime(distance));
                results.Add(vehicleResult);
            }
            return results;
        }

        public override string ToString()
        {
            return name;
        }

        public abstract bool VehicleMathcesRace(Vehicle vehicle);

        public class RaceResult
        {
            public Vehicle vehicle;
            public float time;

            public RaceResult(Vehicle vehicle, float time)
            {
                this.vehicle = vehicle;
                this.time = time;
            }
        }
    }
}
