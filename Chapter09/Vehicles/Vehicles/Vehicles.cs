using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public interface IPassengerCarrier { }
    public interface IHeavyLoadCarrier { }
    public abstract class Vehicle { }
    public class Car : Vehicle { }
    public class Train : Vehicle { }
    public class Compact : Car, IPassengerCarrier { }
    public class SUV : Car, IPassengerCarrier { }
    public class Pickup : Car, IHeavyLoadCarrier { }
    public class PassengerTrain : Train, IPassengerCarrier { }
    public class FreighTrain : Train, IHeavyLoadCarrier { }
    public class T424DoubleBogey : Train { }
}
