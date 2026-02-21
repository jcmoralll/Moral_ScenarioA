using System;

namespace Moral_ScenarioLabel
{
    public class GasPoweredVan : Vehicle
    {
        // Private
        private double fuelLevel;

        // Public property with validation
        public double FuelLevel
        {
            get { return fuelLevel; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("FuelLevel must be between 0% and 100%.");
                fuelLevel = value;
            }
        }

        // Constructor
        public GasPoweredVan(int id, string model, double fuel)
            : base(id, model)
        {
            FuelLevel = fuel;
        }

        // Calculate range based on fuel %
        public override double CalculateRange()
        {
            if (FuelLevel < 5)
                throw new InvalidOperationException("Fuel below 5%. Cannot calculate range.");
            return FuelLevel * 1.5; 
        }
    }
}