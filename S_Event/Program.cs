using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 用于学习Event和Delegate
/// </summary>
namespace S_Event
{  
    class Program
    {
        static void Main(string[] args)
        {
            /*
            S_Delegate.AddDelagate(S_Delegate.printA);
            S_Delegate.AddDelagate(S_Delegate.printA);
            S_Delegate.AddDelagate(S_Delegate.printA);
            S_Delegate.adder();
            */
            Person p = new Person();
            S_Event.RegListener(p.SayHello);
            S_Event.Excute();
            
        }
    }
}
