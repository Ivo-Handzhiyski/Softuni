using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class Car
    {
        private string model;
        private string make;
        private int year;


        public string Make
        {
            get
            {
                return this.Make;
            }
            set
            {
                if (value.Length < 2 || value.Length > 20)
                {
                    throw new ArgumentException("Must be more than 2 symbols");

                }

            }
        }

        public string Model
        {
            get
            {
                return this.model;

            }
            set
            {
                if(value.Length < 2 || value.Length > 20)
                {
                    throw new ArgumentException("Must be more than 2 symbols or less than 20");

                }
            }
        }
        public int Year
        {
            get
            {
                return this.year;

            }
            set
            {
                
            }
        }


        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }
        public Car()
            :this("VW", "Golf", 2025)
        {

        }
        public Car
            (
            string make,
            string model,
            int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;

        }
        public Car
           (
           string make,
           string model,
           int year,
            double fuelQuantity,
            double fuelConsumption)
            :this(make,model,year)
        {
            this.FuelConsumption = fuelConsumption;
            this.FuelQuantity = fuelQuantity;
        }

        public void Drive(double distance)
        {
            bool canContinue = this.FuelQuantity - (distance * this.FuelConsumption) >= 0;

            if(canContinue)
            {
                this.FuelQuantity -= distance * this.FuelConsumption;

            }
            else
            {
                throw new Exception("Not enough fuel to perform this trip!");
            }

        }
        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:f2}L");
            return sb.ToString();
        }
    }
}
