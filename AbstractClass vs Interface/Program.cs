using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_vs_Interface
{
    public   class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.Method1();
            mc.Method2();

          SubClass sc=new SubClass();
            sc.AbstractMethod();
            Console.ReadLine();

        }
    }
}
