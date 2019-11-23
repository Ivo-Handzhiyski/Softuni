using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp
{
    public class Car : IUsageOfLiters
    {
        public Car(double FuelQuantity,double fuelConsumption,double tankCapacity)
        {
            this.FuelConsumption = fuelConsumption;
            this.FuelQuantity = FuelQuantity;
            this.TankCapacity = tankCapacity;
        }

        

        public double FuelQuantity
        {
            get { return FuelQuantity; }
            set { FuelQuantity = value; }
        }


        public double FuelConsumption { get; private set; }

        public double TankCapacity { get; private set; }

        public string Drive(double kms)
        {
            this.FuelConsumption += 0.9;
            if(kms * this.FuelConsumption < this.FuelQuantity)
            {
                this.FuelQuantity -= kms * this.FuelConsumption;
                this.FuelConsumption -= 0.9;
                return $"Car travelled {kms} km";
            }
            else
            {
                this.FuelConsumption -= 0.9;
                return "Car needs refueling";
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
                if(fuel + this.FuelQuantity < this.TankCapacity)
                {
                    this.FuelQuantity += fuel;
                }
                else
                {
                    Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
                }
                
            }
        }
    }
}
