using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;
            Console.Write("输入圆的半径：");
            radius = Convert.ToDouble (Console .ReadLine());
            int ra2;
            ra2 = (int)(radius);
            Console.WriteLine ("{0}转换为整数是{1}",radius ,ra2 ,ra2 );
        }
    }
}
