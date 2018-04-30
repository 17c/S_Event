using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Event
{
    /// <summary>
    /// 委托这玩意儿
    /// 总结:委托相当于C++的一个函数指针，文档说是更为安全，难以理解。有王婆卖瓜的嫌疑
    /// 委托 个人认为 它的定位就是 对同一类函数的引用封装
    /// </summary>
    class S_Delegate
    {
        public delegate void s_delegate();
        public static s_delegate adder;
        //绑定委托器
        public static void NewPrintA(s_delegate gate)
        {
            gate();
        }

        //多播的使用
        public static void AddDelagate(s_delegate gate)
        {
           if(null == adder)
            {
                adder = gate;
            }
            else
            {
                adder += gate;
            }

         }
        public static void printA()
        {
            Console.WriteLine("hello,world");
        }
    }
}
