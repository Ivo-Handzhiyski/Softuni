using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp
{
    class Truck : IUsageOfLiters
    {
        public Truck(double FuelQuantity, double fuelConsumption,double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelConsumption = fuelConsumption;
            this.FuelQuantity = FuelQuantity;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; private set; }

        public double TankCapacity { get; private set; }

        public string Drive(double kms)
        {
            this.FuelConsumption += 1.6;
            if (kms * this.FuelConsumption < this.FuelQuantity)
            {
                this.FuelQuantity -= kms * this.FuelConsumption;
                this.FuelConsumption -= 1.6;
                return $"Truck travelled {kms} km";
            }
            else
            {
                this.FuelConsumption -= 1.6;
                return "Truck needs refueling";
            }


        }


        public void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                
                if (fuel + this.FuelQuantity < this.TankCapacity)
                {
                    this.FuelQuantity += fuel * 0.95;
                }
                else
                {
                    Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
                }
            }
            
        }
    }
}
