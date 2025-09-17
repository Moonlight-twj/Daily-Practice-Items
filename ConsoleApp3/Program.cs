using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The min char:{0}",(int)(char .MinValue ));
            Console.WriteLine("The max char:{0}",(int)(char.MaxValue));
            Console.WriteLine("'2'is letter?{0}", char.IsLetter('2'));
            string testString = "13";
            Console.WriteLine("'13'is string?{0}",testString is string );
            Console.WriteLine("'D'is lower?{0}", char.IsLower('D'));
            Console.WriteLine("\"Tom\"==\"Tomy\"?{0}", string.Equals("Tom", "Tony"));
            Console.WriteLine("{0}", string.Concat("我是", "用工学习者"));
        }
    }
}
