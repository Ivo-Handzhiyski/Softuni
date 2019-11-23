using System;
using System.Collections.Generic;
using System.Text;

namespace P02_CarsSalesman
{
   public class Car
    {
        private const string offset = "  ";

        public string Model;
        public Engine Engine;
        public int Weight;
        public string Color;

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = -1;
            this.Color = "n/a";
        }

        public Car(string model, Engine engine, int weight)
            : this(model,engine)
        {
         
            this.Weight = weight;
            this.Color = "n/a";
        }

        public Car(string model, Engine engine, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = -1;
            this.Color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}:\n", this.Model);
            sb.Append(this.Engine.ToString());
            sb.AppendFormat("{0}Weight: {1}\n", offset, this.Weight == -1 ? "n/a" : this.Weight.ToString());
            sb.AppendFormat("{0}Color: {1}", offset, this.Color);

            return sb.ToString();
        }
    }
}
