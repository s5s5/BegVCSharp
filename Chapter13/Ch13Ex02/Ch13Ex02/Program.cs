using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection myConnection = new Connection();
            Display myDisplay = new Display();
            myConnection.MessageArrived +=
                new MessageHandler(myDisplay.DisplayMessage);
            myConnection.Connect();
            System.Threading.Thread.Sleep(200);
            Console.ReadKey();
        }
    }
}
