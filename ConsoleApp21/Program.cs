using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Teacher
    {
       private string  no;
       private string name;
       private int years;
            public string No
        { get { return no; }
          set { no = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Years
        {
            get { return years; }
            set { years = value; }
        }
        public void Output()
        {
            Console.WriteLine("教师的工号是{0}",No);
            Console.WriteLine("教师的年龄是{0}",Name);
            Console.WriteLine("教师的工龄是{0}",Years);
        }
        class Program
        {
            static void Main(string[] args)
            {
                Teacher teacher= new Teacher();
                Console.Write("请输入教师工号：");
                teacher.No=Console.ReadLine();
                Console.Write("请输入教师姓名：");
                teacher.Name=Console.ReadLine();
                Console.Write("请输入教师教龄：");
                teacher.Years=int.Parse(Console.ReadLine());
                Console.WriteLine("\n教师信息如下：");
                teacher.Output();
                Console.ReadKey();
            }
        }
    }
}
