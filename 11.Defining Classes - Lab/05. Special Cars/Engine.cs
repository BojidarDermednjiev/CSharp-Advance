namespace CarManufacturer
{
    public class Engine
    {
        private int hoursePower;
        private double cubicCapacity;
        public Engine(int hoursePower, double cubicCapacity)
        {
            HorsePower = hoursePower;
            CubicCapacity = cubicCapacity;
        }
        public int HorsePower { get => hoursePower;  set => hoursePower = value; }
        public double CubicCapacity { get => cubicCapacity; set => cubicCapacity = value; }
    }
}
