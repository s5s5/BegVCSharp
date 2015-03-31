using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Ex07
{
    class Program
    {
        delegate string ReadLineDelegate();

        static void Main(string[] args)
        {
            ReadLineDelegate readLine = new ReadLineDelegate(Console.ReadLine);
            Console.WriteLine("input");
            string userInput = readLine();
            Console.WriteLine("out:{0}", userInput);
            Console.ReadKey();
        }
    }
}
