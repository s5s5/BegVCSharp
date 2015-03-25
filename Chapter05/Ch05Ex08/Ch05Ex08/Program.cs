using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Word: YES...");
            string word = Console.ReadLine();
            word = word.Replace("yes", "no");
            Console.WriteLine(word);
            Console.ReadKey();
        }
    }
}
