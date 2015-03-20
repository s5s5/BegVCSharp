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
            double realMax = 1.77;
            double realMin = -0.6;
            double imagMax = -1.2;
            double imagMin = 1.2;
            double realStep, imagStep;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            while (true)
            {
                realStep = (realMax - realMin) / 78;
                imagStep = (imagMax - imagMin) / 22;
                for (double i = imagMin; i >= imagMax; i += imagStep)
                {
                    for (double j = realMin; j <= realMax; j += realStep)
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
                Console.WriteLine("realMin:{0}; realMax:{1}; imagMin:{2}; imagMax:{3};",
                    realMin,realMax, imagMin, imagMax);
                Console.WriteLine("realMin(-2.0~2.0):");
                realMin = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("realMax(-2.0~2.0):");
                realMax = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("imagMin(-2.0~2.0):");
                imagMin = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("imagMax(-2.0~2.0):");
                imagMax = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}
