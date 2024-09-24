namespace RaceSim.Vehicles.GroundVehicles
{
    // Избушка на курьих ножках
    internal class ChickenHut : GroundVehicle
    {
        public ChickenHut()
        {
            name = "Избушка на курьих ножках";
            speed = 9f;
            timeTillRest = 10f;
            baseRestDuration = 0f;
        }
    }
}
