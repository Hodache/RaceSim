namespace Race.Vehicles
{
    public class RunningBoots : GroundVehicle
    {
        public RunningBoots(string name, float speed, float timeTillRest) : base(name, speed, timeTillRest)
        {
        }

        public override float GetRideTime(float totalDistance)
        {
            {
                float restToRestDistance = speed * timeTillRest;
                float coveredDistance = 0;
                float summaryTime = 0;
                int restCounter = 0;

                // Пока следующий отдых будет до финиша
                while (totalDistance - coveredDistance > restToRestDistance)
                {   
                    // Едем до следующего отдыха
                    coveredDistance += restToRestDistance;
                    summaryTime += timeTillRest;

                    // Останавливаемся на отдых
                    restCounter++;
                    summaryTime += baseRestDuration * restCounter;
                }

                // Проезжаем оставшуюся часть пути
                summaryTime += (totalDistance - coveredDistance) / speed;

                return summaryTime;
            }
        }
    }
}
