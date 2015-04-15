using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch11CardLib;

namespace Ch11CardClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code for deep-copying section.
            Deck deck1 = new Deck();
            Deck deck2 = (Deck)deck1.Clone();
            Console.WriteLine("The first card in the original deck is: {0}", deck1.GetCard(0));
            Console.WriteLine("The first card in the cloned deck is: {0}", deck2.GetCard(0));
            deck1.Shuffle();
            Console.WriteLine("Original deck shuffled");
            Console.WriteLine("The first card in the original deck is: {0}", deck1.GetCard(0));
            Console.WriteLine("The first card in the cloned deck is: {0}", deck2.GetCard(0));
            Console.ReadKey();
        }
    }
}
