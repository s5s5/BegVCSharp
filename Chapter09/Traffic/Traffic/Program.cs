using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Traffic
{
    class Program
    {
        static void Main(string[] args)
        {
            AddPassenger(new Compact());
            AddPassenger(new SUV());
            AddPassenger(new PassengerTrain());
            //AddPassenger(new Pickup());
            Console.ReadKey();
        }

        static void AddPassenger(IPassengerCarrier vehicle)
        {
            Console.WriteLine(vehicle.ToString());
        }
    }
}
