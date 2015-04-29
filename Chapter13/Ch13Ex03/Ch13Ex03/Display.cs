using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ch13Ex03
{
    public class Display
    {
        public void DisplayMessage(object source, MessageArrivedEventArgs e)
        {
            Console.WriteLine("Message arrived from: {0}",
                              ((Connection)source).Name);
            Console.WriteLine("Message Text: {0}", e.Message);
        }
    }
}
