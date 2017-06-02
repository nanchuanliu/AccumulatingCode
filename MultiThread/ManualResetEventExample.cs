using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AccumulatingCode.MultiThread
{
    class ManualResetEventExample
    {
        public ManualResetEventExample()
        {
            CreateThread();
            Console.WriteLine("R：停止线程，G：运行线程，ESC：退出\n");

            while (true)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.R)  //红灯停
                {
                    ManualResetEventExample.Stop();    
                }
                if (key == ConsoleKey.G)   //绿灯行
                {
                    ManualResetEventExample.Go();  
                }
                if (key == ConsoleKey.Escape)  //程序退出
                {
                    ManualResetEventExample.Stop();
                    break;
                }
            }
        }

        //创建3个线程并启动
        private static void CreateThread()
        {
            Thread[] ths=new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                ths[i] = new Thread(new ManualResetEventExample().DoWork);
                ths[i].IsBackground = true;    //不加这句，则程序不会结束，因为线程函数使用了死循环
                ths[i].Start();
            }
        }


        //多个对象共享“红绿灯”
        static ManualResetEvent mre=new ManualResetEvent(false);

        static Random ran=new Random();

        //线程函数
        public void DoWork()
        {
            int Counter = 0;
            while (true)
            {
                mre.WaitOne();
                Counter++;
                //随机休眠
                Thread.Sleep(ran.Next(100,2000));
                Console.WriteLine("线程{0}：第{1}次执行",Thread.CurrentThread.ManagedThreadId,Counter);
            }
        }

        //通知阻塞的线程可以继续运行
        public static void Go()
        {
            mre.Set();
            Console.WriteLine("\n绿灯，放行！");
        }

        //让所有正在运行的线程停止运行
        public static void Stop()
        {
            mre.Reset();
            Thread.Sleep(2000); //休眠2秒，等待当前工作线程完成当前工作
            Console.WriteLine("\n红灯，等待！");
        }
    }
}
