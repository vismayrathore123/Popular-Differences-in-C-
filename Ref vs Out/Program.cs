using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_vs_Out
{
    public class Program
    {

        static void ModifyValue(ref int x)
        {
            x = x * 2;
        }
        static void InitializeValue(out int x)
        {
            x = 10;//have to assign value before returning
        }
        public void Main(string[] args)
        {
            //using ref keywords
            int number = 5;
            ModifyValue(ref number);
            Console.WriteLine("after modifying using ref"+number);
            //using out keywords
            int anotherNumber;
            InitializeValue(out anotherNumber);
            Console.WriteLine("after initializing using out" +
                anotherNumber);
            Console.ReadLine();

        }
    }
}
