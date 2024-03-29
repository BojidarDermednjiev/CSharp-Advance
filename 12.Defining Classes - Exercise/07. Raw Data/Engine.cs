﻿namespace RawData
{
    public class Engine
    {
        private double speed;
        private double power;
        public Engine() { }
        public Engine(double speed, double power) : this()
        {
            Speed = speed;
            Power = power;
        }
        public double Speed { get => speed; set => speed = value; }
        public double Power { get => power; set => power = value; }
    }
}
