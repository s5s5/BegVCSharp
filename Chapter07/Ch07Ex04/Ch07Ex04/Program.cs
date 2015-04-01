using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch07Ex04
{
    class Program
    {
        enum Orientation : byte
        {
            North = 1,
            South = 2,
            East = 3,
            West = 4
        }
        static void Main(string[] args)
        {
            Orientation myDirection;
            for (byte myByte = 0; myByte < 10; myByte++)
            {
                try
                {
                    myDirection = checked((Orientation)myByte);
                    if ((myDirection < Orientation.North) ||
                        (myDirection > Orientation.West))
                    {
                        throw new ArgumentOutOfRangeException("myByte", myByte,
                            "Value must be between 1 and 4");
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    // If this section is reached then myByte < 1 or myByte > 4.
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Assigning default value, Orientation.North.");
                    myDirection = Orientation.North;
                }
                Console.WriteLine("myDirection = {0}", myDirection);
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
