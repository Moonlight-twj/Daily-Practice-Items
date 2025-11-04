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
class Employee : Person
{
    private decimal salary;
    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value >= 0) salary = value;
            else salary = 0;
        }
    }
    public Employee(string name, string position, decimal salary) : base(name, position)
    {
        this.salary = salary;
    }
}
class Manager : Employee
{
    private decimal allowance;
    public decimal Allowance
    {
        get { return allowance; }
        set { allowance = value; }
    }
    public Manager(string name, string position, decimal allowance, decimal salary)
        : base(name, position, salary)
    {
        this.allowance = allowance;
    }
}
class JiCheng
{
    static void Main(string[] args)
    {
        #region 继承2
        Manager m1 = new Manager("张译", "经理", 9900, 7500);
        Console.WriteLine("姓名：{0}\n职务：{1}\n津贴：{2}\n工资：{3}",
            m1.Name, m1.Position, m1.Allowance, m1.Salary);
        #endregion
    }
}
