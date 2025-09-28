using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class CountNumber
    {
        static int CountIntegerDigits(double n)
        {
            if (double.IsNaN(n) || double.IsInfinity(n))
            {
                return 0;
            }
            double intergerPart = Math.Truncate(n);
            string inStr = intergerPart.ToString();
            inStr = inStr.TrimStart('-');
            return inStr.Length;
        }
        static void Main()
        {
            Console.Write("输入一个数：");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}的整数部分有{1}位", n, CountIntegerDigits(n));
        }
    }
}