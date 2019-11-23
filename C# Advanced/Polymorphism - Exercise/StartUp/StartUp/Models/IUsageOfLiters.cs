using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp
{
    public interface IUsageOfLiters
    {
        double FuelQuantity { get; }
        double FuelConsumption { get; }

        double TankCapacity { get; }

        string Drive(double kms);

        void Refuel(double fuel);

    }
}
