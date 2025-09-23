using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d;
            string work;
            Console.WriteLine("请输入周几（1-5):");
            d=Convert .ToInt32(Console.ReadLine());
            if (d == 1)
                work = "催收欠款";
            else if (d == 2)
                work = "购买登山杖";
            else if (d == 3)
                work = "登山休息";
            else if (d == 4)
                work = "休息";
            else if (d == 5)
                work = "继续催缴欠款";
            else
                work = "数据输入错误。";
            Console.WriteLine(work);
        }
    }
}
