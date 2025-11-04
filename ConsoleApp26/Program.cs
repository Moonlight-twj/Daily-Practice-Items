using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    private string name;

    private string position;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Position
    {
        get { return position; }
        set { position = value; }
    }
    public Person(string name, string position)
    {
        this.name = name;
        this.position = position;
    }
}
class Employee:Person
{
    private decimal salary;
    public decimal Salary
    {
        get { return salary; }
        set 
        { 
            if(value>0)salary = value;
            else salary = 0;
        }
    }
    public Employee(string name, string position, decimal salary) : base(name, position)
    { this.salary = salary; }
}
class Manager:Employee
{
    private decimal allowance;
    public decimal Allowance
    {
        get { return allowance; }
        set { allowance = value; }
    }
    public Manager(string name, string position,decimal salary,decimal allowance):base(name,position,salary)
    {  this.allowance = allowance; } 
}
class Shenzhen
{
    static void Main (string[] args)
    {
        Manager m1 = new Manager("张红", "经理", 10000, 9800);
        Console.WriteLine("姓名：{0}\n职务：{1}\n津贴：{2}\n工资：{3}\n",m1.Name,m1.Position,m1.Salary,m1.Allowance);

    }
}

