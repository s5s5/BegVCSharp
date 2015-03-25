using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05Ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter more Word:");
            string words = Console.ReadLine();
            //string[] s = words.Split(' ');
            //foreach (var s1 in s)
            //{
            //    Console.Write("\"{0}\"", s1);
            //}
            Console.WriteLine("\"" + words.Replace(" ", "\" \"") + "\"");
            Console.ReadKey();
        }
    }
}
