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
    public partial class frmReaderWriterLock : Form
    {
        public delegate void ShowInfoDelegate(Label lbl, string info);

        public frmReaderWriterLock()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            reader1 = new Thread(ReaderThreadMethod);
            reader2 = new Thread(ReaderThreadMethod);
            reader3 = new Thread(ReaderThreadMethod);
        }

        private static SharedResource res = new SharedResource();

        private ManualResetEvent mre1 = new ManualResetEvent(false);
        private ManualResetEvent mre2 = new ManualResetEvent(false);
        private ManualResetEvent mre3 = new ManualResetEvent(false);
        //单写多读锁
        private ReaderWriterLock rw1 = new ReaderWriterLock();
        //三个读线程，一个写线程
        private Thread reader1, reader2, reader3, writer;

        private void WriterThreadMethod(object info)
        {
            rw1.AcquireWriterLock(-1);  //无限等待，直到获取了写锁
            res.str = info.ToString();   //写入共享资源
            rw1.ReleaseWriterLock();     //释放写锁

            //通知读线程可以读
            mre1.Set();
            mre2.Set();
            mre3.Set();
        }


        private void ReaderThreadMethod(Object WhickOne)
        {
            while (true)
            {
                switch ((int)WhickOne)
                {
                    case 1:
                        DoWithReader(mre1, lblReader1);
                        break;
                    case 2:
                        DoWithReader(mre2, lblReader2);
                        break;
                    case 3:
                        DoWithReader(mre3, lblReader3);
                        break;
                }
            }
        }

        private void DoWithReader(ManualResetEvent mre, Label lbl)
        {
            mre.WaitOne();  //  等待写线程通知
            rw1.AcquireReaderLock(-1);  //无限等待，直到获取了读锁
            lbl.Invoke(new ShowInfoDelegate(ShowInfo), new object[] { lbl, res.str });
            rw1.ReleaseReaderLock();
            mre.Reset();
        }

        private void ShowInfo(Label lbl, string info)
        {
            lbl.Text = info;
            lbl.Refresh();
        }

        private void btnWriter_Click(object sender, EventArgs e)
        {
            writer = new Thread(WriterThreadMethod);
            writer.Start(txtNumber.Text);

            if (reader1.IsAlive == false)
                reader1.Start(1);

            if (reader2.IsAlive == false)
                reader2.Start(2);
            if (reader3.IsAlive == false)
                reader3.Start(3);
        }
    }

    public class SharedResource
    {
        public string str = "";
    }
}
