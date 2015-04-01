using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch07Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine("line {0}", i);
                if (i == 5000)
                    Console.WriteLine(args[999]);
            }
        }
    }
}
