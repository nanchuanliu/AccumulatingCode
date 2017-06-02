using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccumulatingCode.MultiThread.VisualControl
{
    //为了显示进度而定义的委托
    public delegate void SplashShowProgressDelegate(string ProgressInfo);
    //为了关闭启动屏幕而定义的委托
    public delegate void CloseFormDelegate();

    public partial class frmSplash : Form
    {
        //显示初始化进程，供外界调用
        public SplashShowProgressDelegate ShowProgress;
        //关闭Splash窗体，供外界调用
        public CloseFormDelegate CloseSplash;

        public frmSplash()
        {
            InitializeComponent();

            ShowProgress = ShowProgressInForm;
            CloseSplash = Close;
        }

        //显示初始化进程，可以在此定义所需要的显示方式
        private void ShowProgressInForm(String ProgressInfo)
        {
            lblInfo.Text = string.Format("正在初始化：{0}%", ProgressInfo);
            lblInfo.Refresh();
            progressBar1.Value = Convert.ToInt32(ProgressInfo);
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            //Program.mre.Set();  //通知主线程启动窗体已创建完毕
        }
    }


}

#region Progress.cs
//namespace WhatIsThread
//{


//    public delegate void SystemInitializeDelegate();

//    static class Program
//    {

//        //启动屏幕对象的引用
//        private static frmSplash splash;
//        //显示启动屏幕
//        static void ShowSplash()
//        {
//            splash.ShowDialog();
//        }
//        //线程同步对象
//        public static ManualResetEvent mre = new ManualResetEvent(false);

//        static void SystemInitialize()
//        {
//            mre.WaitOne();
//            for (int i = 0; i < 100; i++)
//            {
//                //跨线程通过启动屏幕对象splash调用其ShowProgress方法显示初始化进度
//                splash.Invoke(splash.ShowProgress, new object[] { Convert.ToString(i) });
//                Thread.Sleep(200);
//            }
//            //系统初始化完成，调用splah对象的CloseSplash关闭启动屏幕
//            splash.Invoke(splash.CloseSplash);
//        }

//        /// <summary>
//        /// 应用程序的主入口点。
//        /// </summary>
//        [STAThread]
//        static void Main()
//        {
//            Application.EnableVisualStyles();
//            Application.SetCompatibleTextRenderingDefault(false);
//            //创建启动屏幕
//            splash = new frmSplash();
//            Thread thBegin = new Thread(ShowSplash);
//            thBegin.Start();
//            //在主线程中进行系统初始化工作
//            SystemInitialize();
//            //系统初始化完成，显示主窗体
//            Application.Run(new frmMain());
//        }
//    }
//}

#endregion

