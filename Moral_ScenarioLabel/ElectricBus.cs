using System;

namespace Moral_ScenarioLabel
{
    public class ElectricBus : Vehicle
    {
        // Private
        private double batteryPercentage;

        // Public property with validation
        public double BatteryPercentage
        {
            get { return batteryPercentage; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("BatteryPercentage must be between 0% and 100%.");
                batteryPercentage = value;
            }
        }

        // Constructor
        public ElectricBus(int id, string model, double battery)
            : base(id, model)
        {
            BatteryPercentage = battery;
        }

        // Calculate range based on battery %
        public override double CalculateRange()
        {
            if (BatteryPercentage < 5)
                throw new InvalidOperationException("Battery below 5%. Cannot calculate range.");
            return BatteryPercentage * 2; 
        }
    }
}