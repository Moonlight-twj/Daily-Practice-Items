using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fee, s, weight;
            Console.WriteLine("请输入货重与运输距离");
            Console.Write("货重=");
            weight =Convert .ToDouble (Console.ReadLine());
            if (weight < 0)
            {
                Console.WriteLine("货物重量错误！");
                return;
            }
            Console.WriteLine("运输距离=");
            s=Convert .ToDouble (Console.ReadLine ());
            if (s < 0)
            {
                Console.WriteLine("运输距离错误!");
                return;
            }
            else if (s > 2000)
            {
                fee = 2 * weight * s * (1 - 0.15);
            }
            else if (s > 1000)
            {
                fee = 2 * weight * s * (1 - 0.1);
            }
            else if (s > 500)
            {
                fee = 2 * weight * s * (1 - 0.05);
            }
            else
                fee = 2 * weight * s * 1;
            Console.WriteLine("货重{0}t,运输距离{1}Km,运费{2}元。",weight ,s, fee);
                
        }
    }
}
