using System;

namespace Moral_ScenarioLabel
{
    // Base Class
    public abstract class Vehicle
    {
        public int VehicleID { get; set; }
        public string ModelName { get; set; }

        // Constructor
        public Vehicle(int id, string model)
        {
            VehicleID = id;
            ModelName = model;
        }

        public abstract double CalculateRange();
    }
}