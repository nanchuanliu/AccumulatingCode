using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AccumulatingCode.Asynchrony
{
    class TimerCallbackExample
    {
        public TimerCallbackExample()
        {
            TaskInfo ti=new TaskInfo();

            //使用TimerCallback委托实现定时回调
            Timer tm=new Timer(ShowTime,ti,0,1000);
            Console.ReadKey();
            tm.Dispose();
        }

        static void ShowTime(object ti)
        {
            TaskInfo obj = ti as TaskInfo;
            obj.count++;
            Console.WriteLine("({0}){1}",obj.count,DateTime.Now);
        }
    }

    internal class TaskInfo
    {
        public int count = 0;
    }
}
