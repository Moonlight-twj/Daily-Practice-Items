using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConsoleApp15
{
    static bool isPrime(int n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;
        int sq = (int)Math.Sqrt(n);
        for (int i = 3; i <= sq; i += 2)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
    static void Main()
    {
        Console.Write("输入大于1的自然数:");
        int M = int.Parse(Console.ReadLine());
        Console.WriteLine("1~{0}之间的素数为:",M);
        for (int i = 0; i <= M; i++)
        {
            if (isPrime(i))
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}

