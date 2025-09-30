using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Tree
    {
        private string treeName;
        private double treeHeight;
        private int treeAge;

        public void Print ()
        {
            Console.WriteLine ("树名:{0},树高:{1},树龄:{2}",
                treeName,treeHeight ,treeAge );
        }
      public void Set(string name,double height,int age)
        {
            treeName = name;
            treeHeight = height;
            treeAge = age;
        }
    }
}