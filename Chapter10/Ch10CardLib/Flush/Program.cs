using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch10CardLib;

namespace Flush
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Deck playDeck = new Deck();
                playDeck.Shuffle();
                bool isFlush = false;
                int flushHandIndex = 0;
                for (int hand = 0; hand < 10; hand++)
                {
                    isFlush = true;
                    Suit flushSuit = playDeck.GetCard(hand * 5).suit;
                    for (int card = 1; card < 5; card++)
                    {
                        if (playDeck.GetCard(hand * 5 + card).suit != flushSuit)
                        {
                            isFlush = false;
                        }
                    }
                    if (isFlush)
                    {
                        flushHandIndex = hand * 5;
                        break;
                    }
                }
                if (isFlush)
                {
                    Console.WriteLine("Flush!");
                    for (int card = 0; card < 5; card++)
                    {
                        Console.WriteLine(playDeck.GetCard(flushHandIndex + card));
                    }
                }
                else
                {
                    Console.WriteLine("No flush.");
                }
                Console.ReadLine();
            }
        }

        //private string oldflush()
        //{
        //    Deck myDeck = new Deck();
        //    myDeck.Shuffle();
        //    Card[] cards = new Card[5];
        //    bool[] assigned = new bool[52];
        //    Random sourceGen = new Random();

        //    for (int i = 0; i < 5; i++)
        //    {
        //        int destCard = 0;
        //        bool foundCard = false;
        //        while (foundCard == false)
        //        {
        //            destCard = sourceGen.Next(5);
        //            if (assigned[destCard] == false)
        //                foundCard = true;
        //        }
        //        assigned[destCard] = true;
        //        cards[i] = myDeck.GetCard(destCard);
        //    }

        //    if (cards[0].suit == cards[1].suit)
        //        if (cards[1].suit == cards[2].suit)
        //            if (cards[2].suit == cards[3].suit)
        //                if (cards[3].suit == cards[4].suit)
        //                    if (cards[4].suit == cards[0].suit)
        //                        return "Flush!";
        //    return "No flush";
        //}
    }
}
