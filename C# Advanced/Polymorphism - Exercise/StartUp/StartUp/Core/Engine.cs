namespace StartUp.Engine.Core
{
    using System;
    using System.Linq;
    public class Engine
    {
        public void Run()
        {
            var carArray = Console.ReadLine().Split().ToList();
            var truckArray = Console.ReadLine().Split().ToList();
            var busArray = Console.ReadLine().Split().ToList();

            Car car = new Car(double.Parse(carArray[1]), double.Parse(carArray[2]), double.Parse(carArray[3]));
            Truck truck = new Truck(double.Parse(truckArray[1]), double.Parse(truckArray[2]), double.Parse(truckArray[3]));
            Bus bus = new Bus(double.Parse(busArray[1]), double.Parse(busArray[2]), double.Parse(busArray[3]));
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var arg = Console.ReadLine().Split();
                string command = arg[0];
                string type = arg[1];
                double km = double.Parse(arg[2]);


                if (command == "Drive")
                {
                    if (type == "Truck")
                    {
                        Console.WriteLine(truck.Drive(km));
                    }
                    else if (type == "Car")
                    {
                        Console.WriteLine(car.Drive(km));
                    }
                    else if (type == "Bus")
                    {
                        Console.WriteLine(bus.Drive(km));
                    }
                }
                else if (command == "Refuel")
                {
                    if (type == "Car")
                    {
                        car.Refuel(km);
                    }
                    else if (type == "Truck")
                    {
                        truck.Refuel(km);
                    }
                    else if (type == "Bus")
                    {
                        bus.Refuel(km);
                    }
                }
                else if (command == "DriveEmpty")
                {
                    Console.WriteLine(bus.DriveEmpty(km));
                }

            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
       
    }
}
