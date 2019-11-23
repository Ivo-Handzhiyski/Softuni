using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp
{
    public class Animal
    {
        public Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }

        private string Name { get; set; }
        private string FavouriteFood { get; set; }


        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
        }
    }
}
