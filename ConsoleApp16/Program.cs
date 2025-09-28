using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{

    class RefParam
    {
        static void Change(ref int a)
        {
            a = 5;
        }
        static void Main()
        {
            int x = 3;
            Console.WriteLine("In Main before change, x={0}", x);
            Change(ref x);
            Console.WriteLine("In Main after change, x={0}", x);
        }

    }
}

