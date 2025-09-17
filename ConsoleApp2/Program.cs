using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"1.fioat的最小值:{float.MinValue}");
            Console.WriteLine($"2. 3.3等于5.5：{double.Equals(3.3, 5.5)}");
            decimal result = decimal.Add(3.3m, 5.5m);
            Console.WriteLine($"3. 3.3+5.5={result}");
            Console.WriteLine("\n按任意键退出程序");
            Console.ReadKey( );

        }
    }
}
