using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1, var2;
            bool b1, b2;
            do
            {
                b1 = false;
                Console.WriteLine("Enter a number:");
                var1 = Convert.ToInt32(Console.ReadLine());
                if (var1 > 10)
                {
                    Console.WriteLine("not > 10");
                    b1 = true;
                }
            } while (b1);
            do
            {
                b2 = false;
                Console.WriteLine("Enter another number:");
                var2 = Convert.ToInt32(Console.ReadLine());
                if (var2 > 10)
                {
                    Console.WriteLine("not > 10");
                    b2 = true;
                }
            } while (b2);
            Console.WriteLine("var1 = {0}; var2 = {1}", var1, var2);
            Console.ReadKey();
        }
    }
}
