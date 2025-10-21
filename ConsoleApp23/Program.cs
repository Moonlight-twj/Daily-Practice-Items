using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Teacher
    {
        public string ID { get; set; }
        public string Name { get; set; }
        int years;
        public int Years
        {
            get { return years; }
            set
            {
                if (value < 0 || value > 60)
                {
                    Console.WriteLine("年龄不合法");
                    years = 0;
                }
                else
                    years = value;
            }
        }
        public Teacher()
        { }
        public Teacher(string id)
        {
            ID = id;
        }
        public Teacher(string iD, string name)
        {
            ID= iD;
            Name = name;
        }
        public Teacher(string id, string name, int years, int year)
        {
            ID = id;
            Name = name;
            Years = years;
        }

        public void OutPut()
        {
            Console.WriteLine("老师工号：{0}，姓名：{1}，教龄：{2}", ID, Name, Years);
        }
    }
    class GouzaoMethod
    {
        static void Main(string[] args)
        {
            Teacher t12 = new Teacher();
            t12.ID = "012";
            t12.Name = "付心妍";
            t12.Years = 3;
            t12.OutPut();

            Teacher t34=new Teacher("034");
            t34.Name = "黄艳杰";
            t34.Years = 4;
            t34.OutPut();

            Teacher t56 = new Teacher("056", "汤卡安");
            t56.Years = 5;
            t56.OutPut();
        }
    }
}