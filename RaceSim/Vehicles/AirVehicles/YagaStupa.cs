namespace RaceSim.Vehicles.AirVehicles
{
    // Ступа Бабы Яги
    internal class YagaStupa : AirVehicle
    {
        public YagaStupa()
        {
            name = "Ступа Бабы Яги";
            speed = 6f;
        }

        public override float GetAcceleration(float distanceLeft)
        {
            return 3f;
        }
    }
}
