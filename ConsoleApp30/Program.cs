using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Person
    {
        protected string id;
        protected string name;
        public virtual void OutputInfo()
        { Console.WriteLine("姓名：{0},身份证号：{1}", name, id); }
    }
     class Teacher : Person
    {
        private string department;
        public Teacher(string name, string id, string department)
        {
            this.name = name;
            this.id = id;
            this.department = department;
        }
        public override void OutputInfo()
        {
            Console.WriteLine("姓名:{0},身份证号:{1},部门:{2}", name, id, department);
        }
     class Student : Person
        {
            private string classld;
            private int score;
            public Student(string name, string id,string classld, int score)
            {
                this.name = name;
                this.id = id;
                this.classld = classld;
                this.score = score;
            }
            public override void OutputInfo()
            {
                Console.WriteLine("姓名：{0},身份证号：{1},班级：{2},部门信息：{3},成绩：{4}", name, id, classld, score);
            }
            class Program
            {
                static void Main(string[] args)
                {
                    Teacher teacher = new Teacher("小红","123456","计算机");
                    Student student = new Student("小蓝","098765","计科",99);
                    teacher.OutputInfo();
                    student.OutputInfo();

                }
            }
        }
    }
}
