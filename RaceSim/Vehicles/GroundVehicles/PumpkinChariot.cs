namespace RaceSim.Vehicles.GroundVehicles
{
    // Карета-тыква
    internal class PumpkinChariot : GroundVehicle
    {
        public PumpkinChariot()
        {
            name = "Карета-тыква";
            speed = 13f;
            timeTillRest = 1.5f;
            baseRestDuration = 0.75f;
        }
    }
}
