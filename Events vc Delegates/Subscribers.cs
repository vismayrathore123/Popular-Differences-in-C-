using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_vc_Delegates
{
    
    public class Subscribers
    {
        public Subscribers(Publisher publisher) {

            publisher.MyEvent += HandleEvent;
        }
        private void HandleEvent(string message)
        {
            Console.WriteLine("subscriber received message:"+ message);
        }
    }
}
