namespace Race.Vehicles
{
    public abstract class GroundVehicle : Vehicle
    {
        // Время до отдыха
        protected float timeTillRest;
        // Базовая длительность отдыха
        protected float baseRestDuration;

        public GroundVehicle(string name, float speed, float timeTillRest)
        {
            this.name = name;
            this.speed = speed;
            this.timeTillRest = timeTillRest;
        }
    }
}
