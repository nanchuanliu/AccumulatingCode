using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AccumulatingCode.MultiThread
{
    /// <summary>
    /// Monitor同步线程
    /// </summary>
    class MonitorExample
    {
        MonitorExample()
        {
            //Main函数调用

            //创建共享资源
            SharedResource obj = new SharedResource();
            //创建线程对象并启动
            Thread tha = new Thread(ThreadMethodA);
            Thread thb = new Thread(ThreadMethodB);
            tha.Start(obj);
            thb.Start(obj);

            //程序暂停
            Console.ReadKey();
        }


        //访问静态字段
        private static void VisitStaticField()
        {
            //访问静态字段
            Monitor.Enter(typeof(SharedResource));

            int beginNumber = SharedResource.StaticCount;

            Monitor.Exit(typeof(SharedResource));
        }

        static void ThreadMethodA(object obj)
        {
            lock (obj)
            {
                (obj as SharedResource).DynamicCount += 100;
                Console.WriteLine("线程A完成工作，obj.DynamicCount={0}", (obj as SharedResource).DynamicCount);
                Monitor.Pulse(obj); //通知B线程
                //Monitor.PulseAll(obj); //队列中的所有线程都激活并投入运行
            }
        }


        static void ThreadMethodB(object obj)
        {
            lock (obj)
            {
                if ((obj as SharedResource).DynamicCount == 0)
                    Monitor.Wait(obj); //等待
                (obj as SharedResource).DynamicCount += 100;

                Console.WriteLine("线程B完成工作，obj.DynamicCount={0}", (obj as SharedResource).DynamicCount);
            }
        }
    }


    class SharedResource
    {
        public int DynamicCount = 0;   //多线程共享的实例字段
        public static int StaticCount = 0;    //多线程共享的静态字段
    }
}
