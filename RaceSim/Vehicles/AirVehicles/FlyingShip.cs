namespace RaceSim.Vehicles.AirVehicles
{
    // Летающий корабль
    internal class FlyingShip : AirVehicle
    { 
        public FlyingShip()
        {
            name = "Летающий корабль";
            speed = 5f;
        }

        public override float GetAcceleration(float distanceLeft)
        {
            return (float)Math.Log(distanceLeft);
        }
    }
}
