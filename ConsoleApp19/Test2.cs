using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
     class Test2
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            rec.Set(20.6, 17);
            Console.WriteLine ("矩形面积{0}，矩形周长{1}",rec.GetArea (),rec.GetPerimeter ());
        }
    }
}
