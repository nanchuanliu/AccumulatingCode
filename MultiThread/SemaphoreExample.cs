using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AccumulatingCode.MultiThread
{
    /// <summary>
    /// 信号量对象Semaphore同步多个共享资源
    /// 图书馆电脑排队实例
    /// </summary>
    class SemaphoreExample
    {
        //图书馆拥有的公用计算机
        private const int ComputerNum = 3;
        private static Computer[] LibraryComputers;
        //同步信号量，第一个参数表示空闲的共享资源数目，第二个表示共享的资源总量
        public static Semaphore sp = new Semaphore(ComputerNum, ComputerNum);

        public SemaphoreExample()
        {
            //图书馆拥有ComputerNum台电脑
            LibraryComputers = new Computer[ComputerNum];
            for (int i = 0; i < ComputerNum; i++)
            {
                LibraryComputers[i] = new Computer("Computer" + (i + 1));
            }
            int peopleNum = 0;
            Random ran = new Random();
            Thread user;
            Console.WriteLine("敲任意键模拟一批批的人排队使用{0}台计算机，ESC结束模拟......", ComputerNum);

            //每次随机创建若干个线程，模拟多人排队使用计算机
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                peopleNum = ran.Next(0, 10);
                Console.WriteLine("\n有{0}人在等待使用计算机。", peopleNum);
                for (int i = 1; i <= peopleNum; i++)
                {
                    user = new Thread(UseComputer);
                    user.Start("User" + i.ToString());   //开始使用计算机
                }
            }
        }

        //线程函数
        static void UseComputer(object UserName)
        {
            sp.WaitOne();   //等待计算机可用

            //查找可用的计算机
            Computer cp = null;
            for (int i = 0; i < ComputerNum; i++)
            {
                if (LibraryComputers[i].IsOccupied == false)
                {
                    cp = LibraryComputers[i];
                    break;
                }
            }
            //使用计算机工作
            cp.Use(UserName.ToString());
            //不再使用计算机，让出来给其他人使用
            sp.Release();
        }
    }

    class Computer
    {
        public readonly string ComputerName = "";
        public Computer(string Name)
        {
            ComputerName = Name;
        }

        //是否被占用
        public bool IsOccupied = false;
        //人在使用计算机
        public void Use(string userName)
        {
            Console.WriteLine("{0}开始使用计算机{1}", userName, ComputerName);
            IsOccupied = true;
            Thread.Sleep(new Random().Next(1, 2000));     //随机休眠，以模拟人使用计算机
            Console.WriteLine("{0}结束使用计算机{1}", userName, ComputerName);
            IsOccupied = false;
        }
    }
}
