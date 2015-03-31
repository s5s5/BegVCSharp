using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Ex08
{
    class Program
    {
        struct order
        {
            public string itemName;
            public int uniCount;
            public double unitCost;

            public double TotalCost()
            {
                return uniCount * unitCost;
            }

            public string info()
            {
                return "Order Information: " + uniCount + " " + itemName.ToString() +
                       " items at $" + unitCost.ToString() + " each, total cost $" +
                       TotalCost().ToString();
            }
        }
        static void Main(string[] args)
        {
            order appleJuice;
            appleJuice.itemName = "Apple Juice";
            appleJuice.uniCount = 18;
            appleJuice.unitCost = 8.8;
            Console.WriteLine(appleJuice.info());
            Console.ReadKey();
        }
    }
}
