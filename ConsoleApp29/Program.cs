using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Animal
{
    public virtual void Bark()
    {
        Console.WriteLine("动物会叫");
    }
    public virtual void Eat()
    {
        Console.WriteLine("动物都要吃东西");
    }
}
class Dog : Animal
{
    public override void Bark()
    {
        base.Bark();
        Console.WriteLine("狗的叫声是：汪汪汪");
    }
    public override void Eat() {
        base.Eat();
        Console.WriteLine("狗要吃肉骨头");
    }
}
class Cat:Animal
{
    public override void Bark() {
        base.Bark();
        Console.WriteLine("猫的叫声是：喵喵喵");
}

{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
