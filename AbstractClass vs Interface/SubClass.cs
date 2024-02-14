using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_vs_Interface
{
     class SubClass:AbstractClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Abstract class implemented");
        }
    }
}
