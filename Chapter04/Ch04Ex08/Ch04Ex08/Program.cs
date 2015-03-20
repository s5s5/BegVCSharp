using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputWidth = 0, inputHeight;
            double screenWidth = 78;
            bool screenWidthTrue = true;
            double realCoord = 0.03;
            double imagCoord = 0.05;
            double realTemp, imagTemp, realTemp2, arg;

            while (screenWidthTrue)
            {
                Console.WriteLine("Enter width:");
                inputWidth = Convert.ToDouble(Console.ReadLine());
                if (inputWidth <= screenWidth && inputWidth > 0)
                {
                    screenWidthTrue = false;
                }
            }
            Console.WriteLine("Enter height:");
            inputHeight = Convert.ToDouble(Console.ReadLine());

            int iterations;
            for (double i = 1.2; i >= -(imagCoord * inputHeight); i -= imagCoord)
            {
                for (double j = -0.6; j <= ((realCoord * inputWidth) - 0.6); j += realCoord)
                {
                    iterations = 0;
                    realTemp = j;
                    imagTemp = i;
                    arg = (j * j) + (i * i);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                                    - j;
                        imagTemp = (2 * realTemp * imagTemp) - i;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
