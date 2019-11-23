using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Models
{
   public abstract class Animal
    {
        public Animal(string name, double weight, int foodEaten)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = foodEaten;
        }

        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }


    }
}
