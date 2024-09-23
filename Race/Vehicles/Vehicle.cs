namespace Race.Vehicles
{
    public abstract class Vehicle
    {
        // Название транспорта
        protected string name;
        // Скорость движения
        protected float speed;

        // Симуляция проезда гонки
        public abstract float GetRideTime(float totalDistance);
    }
}
