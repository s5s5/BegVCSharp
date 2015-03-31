using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Bed Param!");
                return;
            }
            string str = args[0];
            int i = Convert.ToInt32(args[1]);
            Console.WriteLine("string:{0}, int:{1}", str, i);
            Console.ReadKey();
        }
    }
}
