using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, intfinal, i, count = 0;
            for (n = 101; n <= 200; n++)
            {
                intfinal = (int)(Math.Sqrt(n));
                for (i = 2; i <= intfinal; i++) 
                {
                    if (n % i == 0)
                        break;
                }
                if (i > intfinal)
                {
                    Console.Write("{0,4}", n);
                    count++;
                }
            }
            Console.WriteLine("/n共{0}个素数", count);
        }
    }
}
