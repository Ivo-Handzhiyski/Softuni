using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_RawData
{
   public class RawData
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                Tire[] tires = new Tire[4];

                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string model = parameters[0];

                int engineSpeed = int.Parse(parameters[1]);
                int enginePower = int.Parse(parameters[2]);

                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(parameters[3]);
                string cargoType = parameters[4];

                Cargo cargo = new Cargo(cargoWeight, cargoType);

                double firstTirePressure = double.Parse(parameters[5]);
                int firstTireAge = int.Parse(parameters[6]);

                tires[0] = new Tire(firstTireAge, firstTirePressure);

                double secondTirePressure = double.Parse(parameters[7]);
                int secondTireAge = int.Parse(parameters[8]);

                tires[1] = new Tire(secondTireAge, secondTirePressure);

                double thirdTirePressure = double.Parse(parameters[9]);
                int thirdTireAge = int.Parse(parameters[10]);

                tires[2] = new Tire(thirdTireAge, thirdTirePressure);

                double forthTirePressure = double.Parse(parameters[11]);
                int forthTireAge = int.Parse(parameters[12]);

                tires[3] = new Tire(forthTireAge, forthTirePressure);

                cars.Add(new Car(model, cargo, engine, tires));
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                List<string> fragile = cars
                    .Where(x => x.Cargo.CargoType == "fragile" && x.Tires.Any(y => y.TirePressure < 1))
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, fragile));
            }
            else
            {
                List<string> flamable = cars
                    .Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250)
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, flamable));
            }
        }
    }
}
