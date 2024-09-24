namespace RaceSim.Vehicles
{
    internal abstract class AirVehicle : Vehicle
    {
        public override float GetRideTime(float totalDistance)
        {
            return totalDistance / (speed + GetAcceleration(totalDistance));
        }

        public abstract float GetAcceleration(float distanceLeft);
    }
}
