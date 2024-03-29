﻿namespace RawData
{
    public class Cargo
    {
        private string type;
        private int weight;
        public Cargo() { }
        public Cargo(string type, int weight) : this()
        {
            Type = type;
            Weight = weight;
        }
        public string Type { get => type; set => type = value; }
        public int Weight { get => weight; set => weight = value; }
    }
}
