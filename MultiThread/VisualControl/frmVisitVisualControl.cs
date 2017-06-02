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
    public partial class frmVisitVisualControl : Form
    {
        public delegate void SetLabelTextDelegate();

        public SetLabelTextDelegate del;


        public frmVisitVisualControl()
        {
            InitializeComponent();
            del = SetLabelText;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(ThreadMethod);
            th.Start();
            //带参数，info为参数
            //th.Start(info);
        }

        //定义新的线程函数        
        private void ThreadMethod()
        {
            lblShow.Invoke(del);
            //带参数线程函数，info为参数
            //lblShow.Invoke(del,new object[]{info})
        }

        private void SetLabelText()
        {
            lblShow.Text = "Hello";
        }
    }
}
