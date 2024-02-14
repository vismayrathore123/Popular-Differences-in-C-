using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_vc_Delegates
{
    public delegate void MyDelegate(string message);
    public class Publisher
    {
        public event MyDelegate MyEvent;
        public void RaiseEvent(string message)
        {
            if(MyEvent != null)
            {
                MyEvent(message);
            }
        }
    }
}
