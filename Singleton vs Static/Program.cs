using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_vs_Static
{
    public class Program
    {
        static void Main(string[] args)
        {
            Static.staticMethod();
            Singleton.Instance.SayHello();
            Console.ReadLine();
        }
    }
}
