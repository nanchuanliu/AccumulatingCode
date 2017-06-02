using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AccumulatingCode.MultiThread.VisualControl
{


    //为了显示进度而定义的委托
    public delegate void Splash2ShowProgressDelegate(string ProgressInfo);
    //为了关闭启动屏幕而定义的委托
    public delegate void CloseSplashDelegate();
    //要完成的系统初始化工作
    public delegate void DoWorkDelegate(Object frm);

    /// <summary>
    /// 可以解决资源管理器启动窗体与
    /// 主窗体应用程序上下文对象切换的问题：
    /// 资源管理器挡住了主窗体
    /// </summary>
    public partial class frmSplash2 : Form
    {

        private Thread worker;

        public frmSplash2()
        {
            InitializeComponent();
        }

        //外界挂接的用于显示持续较长时间工作的函数
        //比如系统初始化
        public DoWorkDelegate DoWork;

        #region 进程的可视化显示

        //显示初始化进程，供外界调用
        public Splash2ShowProgressDelegate ShowProgress;
        //关闭Splash窗体，供外界调用
        public CloseSplashDelegate CloseSplash;
        //显示初始化进程，可以再此定义所需要的显示方式
        private void ShowProgressInForm(String ProgressInfo)
        {
            lblInfo.Text = string.Format("正在初始化：{0}%", ProgressInfo);
            progressBar1.Value = Convert.ToInt32(ProgressInfo);
        }

        #endregion

        //在装入窗体的过程中完成准备工作
        private void frmSplash2_Load(object sender, EventArgs e)
        {
            ShowProgress = ShowProgressInForm;
            CloseSplash = Close;

            if (DoWork != null)
            {
                //创建完成系统初始化工作的辅助线程并启动它
                worker=new Thread(new ParameterizedThreadStart(DoWork));
                worker.Start(this); //将自身引用作为参数，启动线程
            }
        }
    }
}

//static class Program
//{
//    static void SystemInitialize(Object Splash)
//    {
//        frmSplash2 frm = (frmSplash2)Splash;
//        for (int i = 0; i < 100; i++)
//        {
//            //跨线程通过启动屏幕对象splash调用其ShowProgress方法显示初始化进度
//            frm.Invoke(frm.ShowProgress, new object[] { Convert.ToString(i) });
//            //Thread.Sleep(200);
//        }
//        //系统初始化完成，调用splah对象的CloseSplash关闭启动屏幕
//        frm.Invoke(frm.CloseSplash);
//    }

//    /// <summary>
//    /// 应用程序的主入口点。
//    /// </summary>
//    [STAThread]
//    static void Main()
//    {
//        Application.EnableVisualStyles();
//        Application.SetCompatibleTextRenderingDefault(false);
//        //创建启动屏幕
//        frmSplash2 splash = new frmSplash2();

//        splash.DoWork = SystemInitialize;
//        SplashAppContext splashContext = new SplashAppContext(new frmMain(), splash);

//        Application.Run(splashContext);
//    }
//}
