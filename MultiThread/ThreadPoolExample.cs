using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AccumulatingCode.MultiThread
{
    class ThreadPoolExample
    {
        public ThreadPoolExample()
        {
            //创建工作任务信息对象
            TaskInfo ti = new TaskInfo();
            ti.EndNumber = 10000;
            //将线程函数加入线程池的等待队列
            ThreadPool.QueueUserWorkItem(CalculateSum, ti);

            ThreadPool.RegisterWaitForSingleObject(are, CalculateSum, (object)ti, 2000, true);
            // are.Set();   //将导致线程函数立即被调度执行
            //// Thread.Sleep(3000);  //将导致线程函数因超时而被调度执行
            are.WaitOne();  //等待线程池通知工作已完成
            Console.WriteLine("从1加到{0}的和为{1}", ti.EndNumber, ti.Sum);
            Console.ReadKey();
        }



        //同步信号
        static AutoResetEvent are = new AutoResetEvent(false);

        //线程函数
        static void CalculateSum(object argu)
        {
            TaskInfo ti = argu as TaskInfo;
            ti.Sum = 0;
            for (int i = 0; i <= ti.EndNumber; i++)
                ti.Sum += i;
            are.Set();   //通知主线程工作完成
        }


        //线程函数
        static void CalculateSum(object argu, bool timedOut)
        {
            //注意
            //如果timeOut=true，说明是超时导致的执行
            //否则，是WaitHandle对象变为signal状态导致的执行
            //程序员可以根据实际情况做出相应的处理
            TaskInfo ti = argu as TaskInfo;
            ti.Sum = 0;
            for (int i = 1; i <= ti.EndNumber; i++)
            {
                ti.Sum += i;
            }
            are.Set();  //通知主线程工作完成
        }
    }

    class TaskInfo
    {
        public int EndNumber = 0;  //要累加到的数
        public int Sum = 0;        //累加结果
    }
}
