namespace StartUp
{
    using System;
    class Bus
    {
        
        public Bus(double FuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelConsumption = fuelConsumption;
            this.FuelQuantity = FuelQuantity;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; private set; }

        public double TankCapacity { get; private set; }

        public string Drive(double kms)
        {
            this.FuelConsumption += 1.4;
            if (kms * this.FuelConsumption < this.FuelQuantity)
            {
                this.FuelQuantity -= kms * this.FuelConsumption;
                this.FuelConsumption -= 1.4;
                return $"Bus travelled {kms} km";
            }
            else
            {
                this.FuelConsumption -= 1.4;
                return "Bus needs refueling";
            }


        }
        public string DriveEmpty(double kms)
        {
           
            if (kms * this.FuelConsumption < this.FuelQuantity)
            {
                this.FuelQuantity -= kms * this.FuelConsumption;                
                return $"Bus travelled {kms} km";
            }
            else
            {               
                return "Bus needs refueling";
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
