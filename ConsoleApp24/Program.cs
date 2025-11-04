using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Shape
{
    public const double PI = Math.PI;
    protected double x, y;
    public Shape(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
}

class Circle : Shape
{
    public Circle(double radius) : base(radius, 0)
    { }
    public double Area()
    {
        return PI * x * x;
    }
}

class JiCheng
{
    static void Main(string[] args)
    {
        Circle c = new Circle(5.5);
        Console.WriteLine("圆的半径是：{0:f2},面积是：{1:f2}", 5.5, c.Area());
    }
}

