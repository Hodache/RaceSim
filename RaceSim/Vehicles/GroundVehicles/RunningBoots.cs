namespace RaceSim.Vehicles.GroundVehicles
{
    // Сапоги-скороходы
    internal class RunningBoots : GroundVehicle
    {
        public RunningBoots()
        {
            name = "Сапоги-скороходы";
            speed = 20f;
            timeTillRest = 0.5f;
            baseRestDuration = 0.25f;
        }
    }
}
