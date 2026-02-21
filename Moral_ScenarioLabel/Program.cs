using System;

namespace Moral_ScenarioLabel
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // This displays the vehicle type
                Console.WriteLine("Green Transit Fleet Manager");
                Console.WriteLine("Choose The Following Vehicle Type Below:");
                Console.WriteLine("1 - Electric Bus");
                Console.WriteLine("2 - Gas Powered Van");

                // USER INPUT FOR THE USER
                Console.Write("Please enter the number here: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                // IF statement to display a error, incase if the user inputs a incorrect number
                if (choice != 1 && choice != 2)
                {
                    Console.WriteLine("Error! Please choose between 1-2.");
                    return;
                }

                // VEHICLE ID FOR THE USER
                Console.Write("Enter your Vehicle ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                // MODEL NAME FOR THE USER
                Console.Write("Enter the Vehicle Model Name: ");
                string model = Console.ReadLine();

                // Polymorphism: base class reference
                Vehicle vehicle;

                if (choice == 1)
                {
                    Console.Write("Enter your Battery Percentage: ");
                    double battery = Convert.ToDouble(Console.ReadLine());


                    // I applied INHERITANCE HERE for the ElectricBus to inherit from the vehicle
                    vehicle = new ElectricBus(id, model, battery);
                }
                else
                {
                    Console.Write("Enter your Fuel Level: ");
                    double fuel = Convert.ToDouble(Console.ReadLine());

                    // Same with ElectricBus, I applied Inheritance for GasPoweredVan from the vehicle
                    vehicle = new GasPoweredVan(id, model, fuel);
                }

                //POLYMORPHISM is applied where It can store either ElectricBus or GasPoweredVan object.
                double range = vehicle.CalculateRange();
                Console.WriteLine("Calculated Range: " + range + " km");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Energy Error: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Input Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR! Please enter numbers only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }
            finally
            {
               

                Console.WriteLine("System Shutdown");
            }
        }
    }
}