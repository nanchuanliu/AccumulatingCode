using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AccumulatingCode.MultiThread
{
    /// <summary>
    /// 互斥同步对象Mutex
    /// ATM取款机例子
    /// </summary>
    class MutexExample
    {
        static ATM OneATM = new ATM();    //共享资源

        MutexExample()
        {
            //向公共账号存款2万
            OneATM.Deposit(20000);
            Console.WriteLine("\n敲任意键从公共账号中取钱，ESC键退出......\n");

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.WriteLine("");
                Thread One = new Thread(WithDrawMoney);
                Thread Two = new Thread(WithDrawMoney);
                Thread Three = new Thread(WithDrawMoney);

                //随机生成一个要提款的数额，最小100元，最高5000元
                Random ran = new Random();
                One.Start(ran.Next(100, 5000));
                Two.Start(ran.Next(100, 5000));
                Three.Start(ran.Next(100, 5000));

                //等三人取完钱
                One.Join();
                Two.Join();
                Three.Join();

                Console.WriteLine("公共账号剩余{0}元", OneATM.QueryPublicAccount());
            }
        }

        //线程函数
        static void WithDrawMoney(object amount)
        {
            switch (OneATM.WithDraw((int)amount))
            {
                case WithDrawState.Succeed:
                    Console.WriteLine("成功取出{0}元。", amount);
                    break;
                case WithDrawState.ATMHasNotEnoughCash:
                    Console.WriteLine("ATM中现金不足，无法支取{0}元。", amount);
                    break;
                case WithDrawState.AccountHasNotEnoughMoney:
                    Console.WriteLine("账号中没钱了！无法取出{0}元", amount);
                    break;
            }
        }
    }

    //自助取款机
    class ATM
    {
        private int PublicAcountLeftMoney;    //账户剩余的钱
        private int ATMLeftMoney = 10000;     //提款机剩余的钱
        //同步信息号量
        private Mutex m = new Mutex();

        //取钱
        public WithDrawState WithDraw(int amount)
        {
            m.WaitOne();
            //公共账号钱不够
            if (PublicAcountLeftMoney < amount)
            {
                m.ReleaseMutex();
                return WithDrawState.AccountHasNotEnoughMoney;
            }

            //ATM现金不够
            if (ATMLeftMoney < amount)
            {
                m.ReleaseMutex();
                return WithDrawState.ATMHasNotEnoughCash;
            }

            //用户可以提取现金
            ATMLeftMoney -= amount;
            PublicAcountLeftMoney -= amount;
            m.ReleaseMutex();
            return WithDrawState.Succeed;
        }

        //存钱
        public void Deposit(int amount)
        {
            m.WaitOne();
            PublicAcountLeftMoney += amount;
            m.ReleaseMutex();
        }

        //获取还剩余多少钱
        public int QueryPublicAccount()
        {
            return PublicAcountLeftMoney;
        }
    }

    //取款状态
    public enum WithDrawState
    {
        Succeed,    //取钱成功
        AccountHasNotEnoughMoney,   //账号中没有钱了
        ATMHasNotEnoughCash    //ATM中没有足够的现金
    }
}
