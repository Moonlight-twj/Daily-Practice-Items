using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Father
{
    public virtual void Drink()
    {
        Console.WriteLine("父亲喝白酒");
    }
    class Son : Father
    {
        public override void Drink()
        {
            base.Drink();
            Console.WriteLine("儿子喝啤酒");
        }
        class ConsoleApp28
        {
            static void Main()
            {
                # region 任务一
                Father f = new Father();
                f.Drink();
                Console.WriteLine("66666    ");
                Son s = new Son();
                s.Drink();
                #endregion
            }
        }
    }
}
