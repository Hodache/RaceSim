namespace RaceSim.Vehicles
{
    abstract class GroundVehicle : Vehicle
    {
        // Время до отдыха
        protected float timeTillRest;
        // Базовая длительность отдыха
        protected float baseRestDuration;

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
