namespace RaceSim.Vehicles.AirVehicles
{
    // Метла
    internal class Broom : AirVehicle
    {
        public Broom() 
        {
            name = "Метла";
            speed = 4f;
        }

        public override float GetAcceleration(float distanceLeft)
        {
            
            return Math.Min(0.05f * distanceLeft, 6.5f);
        }
    }
}
