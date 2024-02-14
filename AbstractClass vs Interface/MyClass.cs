using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_vs_Interface
{
    public class MyClass:Interface1,Interface2
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }
        public void Method2() 
        {
            Console.WriteLine("Method2");
        }
    }
}
