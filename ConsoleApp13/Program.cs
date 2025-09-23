using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            Console.Write("输入:");
            n=int.Parse (Console.ReadLine());
            for (i = 1; i <= (n + 1) / 2; i++)
            {
                for (j = 1; j <= n - 1; j++)
                    Console.Write(' ');
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            for (i = n-(n+1)/2;i>=1;i--)
            {
                for (j = 1; j <= n - 1; j++)
                    Console.Write(' ');
                for (j = 1; j <=2*i - 1; j++)
                    Console.Write("*");
                Console .WriteLine ();
            }
                


        }
    }
}
