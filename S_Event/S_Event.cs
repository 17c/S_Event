using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Event
{   

    /// <summary>
    /// 事件其实就是委托 事件分为 接收者-派发者 两部分 
    /// 传参，我个人认为好的做法是封装一个参数类，将其作为参数，以此来实现事件系统
    /// </summary>
    class S_Event
    {
        public delegate void M_delegate();
        public static event M_delegate receiver;


        public static void Excute()
        {
            receiver();
        }

        public static void RegListener(M_delegate func)
        {
            receiver += func;
        }
    }
}
