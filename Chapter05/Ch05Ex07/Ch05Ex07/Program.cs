using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            string word, reversionWord = "";
            Console.WriteLine("Enter Word:");
            word = Convert.ToString(Console.ReadLine());
            for (int i = (word.Length - 1); i >= 0; i--)
            {
                reversionWord += word[i];
            }
            Console.Write("{0}", reversionWord);
            Console.ReadKey();
        }
    }
}
