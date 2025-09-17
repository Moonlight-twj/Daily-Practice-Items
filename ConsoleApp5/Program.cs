using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;
            Console.Write("输入圆的半径：");
            radius = double.Parse(Console.ReadLine());
            int ra2;
            int ra = Convert .ToInt32(radius );
            Console.WriteLine("{0}转换为整数是{1}", radius, ra);
        }
    }
}
