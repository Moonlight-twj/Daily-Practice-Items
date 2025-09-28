using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class ParamOut
    {
        static void Main(string[] args)
        {
            int x;
            O(out x);
            Console.WriteLine("x={0}", x);
        }
        private static void O(out int x)
            {
              x=6;
            }
    }
}
