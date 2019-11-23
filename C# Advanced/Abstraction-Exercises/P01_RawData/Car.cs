using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    public class Car
    {
        public Car(string model,Cargo cargo, Engine engine, Tire[] tires)
        {
            this.Model = model;
            this.Cargo = cargo;
            this.Engine = engine;
           
            this.Tires = tires;
        }
            public string Model;

        public Cargo Cargo;
        public Engine Engine;
            public Tire[] Tires;       
    }
}
