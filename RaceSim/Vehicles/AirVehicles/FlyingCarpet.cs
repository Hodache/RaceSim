namespace RaceSim.Vehicles.AirVehicles
{
    // Ковер-самолет
    internal class FlyingCarpet : AirVehicle
    {
        public FlyingCarpet()
        {
            name = "Ковер-самолет";
            speed = 3f;
        }

        public override float GetAcceleration(float distanceLeft)
        {
            return (float)Math.Sin(5f * distanceLeft) + 4f;
        }
    }
}
