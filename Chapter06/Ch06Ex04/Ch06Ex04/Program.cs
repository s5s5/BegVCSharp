using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} command line arguments were specified:",
                args.Length);
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
