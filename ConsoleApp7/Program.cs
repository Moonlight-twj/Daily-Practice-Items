using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string s1, s2, result;
            s1 = Console.ReadLine();
            s2 = Console.ReadLine();
            result = s1 + s2;
            Console.WriteLine("{0}+{1}={2}", s1, s2, result);
        }
    }
}