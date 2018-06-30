using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 35, k = 10;
            const double a = 0.1, b = 0.8;

            double step = (b - a) / k;

            for (double x = a; x <= b; x += step)
            {
                double SN = 0;
                int i; 
                double xn = 0;

                for (i = 1; i <= n; i++)
                {
                    xn = ((Math.Pow(x, i) * Math.Cos(i*Math.PI/3)) / i);
                    SN += xn;
                }

                double E = 0.0001;
                double SE = 0;
                i = 1;

                do
                {
                    xn = (Math.Pow(x, i) * Math.Cos(i * (Math.PI / 3))) / i;
                    SE += xn;
                    i++;
                } while (Math.Abs(xn) >= E);
                double y=-1 / 2.0 * Math.Log(1 - 2 * x * Math.Cos(Math.PI / 3) + Math.Pow(x, 2));
                Console.WriteLine("X={0:f2} SN={1:f5} SE={2:f6} Y={3:f6}", x, SN, SE, y);
            }
            Console.ReadLine();
        }
    }
}


