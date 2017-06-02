using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccumulatingCode.MultiThread
{
    /// <summary>
    /// 带有参数的线程
    /// </summary>
    class ParameterizedThread
    {
        //原始方法
        static void f1(int x)
        {
            Console.WriteLine(x);
        }

        static void f2(string str)
        {
            Console.WriteLine("Hello");
        }

        static void f1(object x)
        {
            //进行参数转换
            int argu = Convert.ToInt32(x);
            Console.WriteLine(argu);
        }

        static void f2(object str)
        {
            string argu = str.ToString();
            Console.WriteLine(argu);

        }

        //多线程创建，局限性在于线程函数只能有一个参数，并且不能有返回值
        //Thread th1 = new Thread(new ParameterizedThreadStart(f1));
        //Thread th2 = new Thread(new ParameterizedThreadStart(f2));
        //th1.Start(100);
        //th2.Start("Hello");
    }
}
