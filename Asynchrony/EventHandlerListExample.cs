using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace AccumulatingCode.Asynchrony
{
    public delegate void OneDelegate(int value);

    public delegate void TwoDelegate(string str);

    /// <summary>
    /// 事件访问器例子
    /// </summary>
    class EventHandlerListExample
    {
        public EventHandlerListExample()
        {
            B b=new B();
            A a=new A();

            a.Event1 += b.f1;
            a.Event2 += b.f2;
            a.FireTwoEvents();

            Console.ReadKey();
        }
    }


    public class A
    {
        private EventHandlerList events=new EventHandlerList();

        public event OneDelegate Event1
        {
            add
            {
                events.AddHandler("Event1",value);
            }
            remove
            {
                events.RemoveHandler("Event1",value);
            }
        }

        public event TwoDelegate Event2
        {
            add
            {
                events.AddHandler("Event2",value);
            }
            remove
            {
                events.RemoveHandler("Event2",value);
            }
        }

        public void FireTwoEvents()
        {
            (events["Event1"] as OneDelegate)(100);
            (events["Event2"] as TwoDelegate)("100");
        }
    }

    public class B
    {
        public void f1(int i)
        {
            Console.WriteLine("B.fi(int)");
        }

        public void f2(string str)
        {
            Console.WriteLine("B.f2(String)");
        }
    }
}
