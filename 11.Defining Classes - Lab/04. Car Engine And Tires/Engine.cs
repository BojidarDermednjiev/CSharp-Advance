namespace CarManufacturer
{
    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;
        public Engine(int hoursePower, double cubicCapacity)
        {
            HorsePower = hoursePower;
            CubicCapacity = cubicCapacity;
        }
        public int HorsePower { get => horsePower; protected set => horsePower = value; }
        public double CubicCapacity { get => cubicCapacity; protected set => cubicCapacity = value; }
    }
}
