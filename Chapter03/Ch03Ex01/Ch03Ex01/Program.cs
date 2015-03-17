using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger;
            string myString, myString2;
            myInteger = 17;
            myString = "\"myiteger\" is";
            myString2 = @"E:\win\BegVCSharp\code\Chapter03Code\Chapter03Code";
            Console.WriteLine("{0} {1}.", myString, myInteger);
            Console.WriteLine(myString2);
            Console.ReadKey();
        }
    }
}
