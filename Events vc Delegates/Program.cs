using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_vc_Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscribers subscribers = new Subscribers(publisher);
            publisher.RaiseEvent("hello, world");
            Console.ReadLine();
        }
    }
}
