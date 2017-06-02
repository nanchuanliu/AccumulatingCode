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
    //让进度条显示进度的委托，用于跨线程调用
    public delegate void ShowProgressDelegate(ProgressBar prog, int value);
    //激活某个控件的委托，用于跨线程调用
    public delegate void EnableControlDelegate(Control ctl);

    public partial class frmWhatIsThread : Form
    {
        public frmWhatIsThread()
        {
            InitializeComponent();
        }

        private void DoLongTaskInSingleThread()
        {
            for (int i = 0; i < 100; i++)
            {
                progressBarSingleThread.Value = i;
                Thread.Sleep(100);
            }
        }


        private void SetProgressBarValue(ProgressBar prog, int value)
        {
            prog.Value = value;
        }

        private void EnabledControl(Control ctl)
        {
            ctl.Enabled = true;
        }


        private void DoLongTaskInMultiThread(object argu)
        {
            for (int i = 0; i < 100; i++)
            {
                (argu as ThreadArgu).prog.Invoke(new ShowProgressDelegate(SetProgressBarValue),
                                                 new object[] {(argu as ThreadArgu).prog, i});
                Thread.Sleep(100);
            }

            (argu as ThreadArgu).btnStart.Invoke(new EnableControlDelegate(EnabledControl),
                                                 new object[] {(argu as ThreadArgu).btnStart});
        }


        private Thread th1, th2;

        private void btnStartMultiThread1_Click(object sender, EventArgs e)
        {
            btnStartMultiThread1.Enabled = false;
            th1=new Thread(new ParameterizedThreadStart(DoLongTaskInMultiThread));
            lblMultiThreadID1.Text = th1.ManagedThreadId.ToString();

            ThreadArgu argu=new ThreadArgu();
            argu.prog = progressBarMultiThread1;
            argu.btnStart = btnStartMultiThread1;

            th1.Start((object)argu);
        }

        private void frmWhatIsThread_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (th1 != null)
            {
                if(th1.ThreadState!=ThreadState.Stopped)
                    th1.Abort();
            }

            if (th2 != null)
            {
                if(th2.ThreadState!=ThreadState.Stopped)
                    th2.Abort();
            }
        }
        
    }

    class ThreadArgu
    {
        public ProgressBar prog;
        public Button btnStart;
    }
}
