# Moral_Scenario A - Green Transit Fleet Manager | BSIT 3.2

The Green-Transit Fleet Manager is a C# console application designed to manage and calculate the range of different types of vehicles in a fleet. It demonstrates the use of Object-Oriented Programming (OOP) principles such as inheritance, polymorphism, and encapsulation, and includes robust error handling for invalid inputs or low energy levels.


Scenario:
Scenario A: The "Green-Transit" Fleet Manager 

Base Class: Vehicle (Properties: VehicleID, ModelName).

Sub-Classes: ElectricBus (Battery %) and GasPoweredVan (Fuel Level).

Logic: Implement a CalculateRange() method. The Bus calculates based on battery, the Van based on fuel.

Exception: Throw an error if the energy level is below 5% during a range check.

Base class Vehicle with properties VehicleID and ModelName.

Subclasses:

ElectricBus – Calculates range based on Battery Percentage.

GasPoweredVan – Calculates range based on Fuel Level.

Encapsulation: Sensitive data (BatteryPercentage and FuelLevel) is protected using private fields and validated public properties.

Polymorphism: The program uses a single Vehicle reference to handle multiple vehicle types.

Exception Handling:

Throws an error if energy level is below 5% during range calculation.

Handles invalid user input gracefully (FormatException, ArgumentException, InvalidOperationException).
