using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccumulatingCode.MultiThread
{
    /// <summary>
    /// 带外壳函数的线程
    /// </summary>
    class ShellMethodThread
    {
        public long SomeFunc(int x, int y)
        {
            long ret = 0;
            //使用x和y完成一些工作
            return ret;
        }

        //将SomeFunc参数和返回值外化为类的公有字段
        public int x;
        public int y;

        public long returnValue;

        //供多线程调用的“外套”函数
        public void ThreadMethod()
        {
            returnValue = SomeFunc(x, y);
        }
    }

    //线程调用
     //ShellMethodThread obj=new ShellMethodThread();
     //obj.x = 100;
     //obj.y = 200;

     //Thread t=new Thread(new ThreadStart(obj.ThreadMethod));
     //t.Start();

     //t.Join();

     //Console.WriteLine(obj.returnValue);
}
