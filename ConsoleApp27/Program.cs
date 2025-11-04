 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;
class Student
{
    private int id;
    public int Id { get { return id; } }
    public string Name { get; set; }
    protected double score;
    public Student(int id, double score, string Name)
     {  this.id=id;
        this.score = score;
        this.Name = Name;
    }
    class Collegestudent:Student
    {
        private string speciality;
        public Collegestudent(string speciality, int id, double score, string Name) : base(id, score, Name)
        {
            this.speciality = speciality;
        }
        public void OutPutCollegeStu()
        {
            Console.WriteLine("序号：{0}\t姓名：{1}\t成绩：{2}\t专业：{3}",
                Id, Name, score, speciality);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Collegestudent cs = new Collegestudent("计算机科学",59, 99, "庹文杰");
            cs.OutPutCollegeStu();
        }
    }
}
