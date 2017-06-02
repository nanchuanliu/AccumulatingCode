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
    public partial class frmUseThreadSafeLabel : Form
    {
        public frmUseThreadSafeLabel()
        {
            InitializeComponent();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(ThreadMethod);
            th.Start(txtInput.Text);
        }

        private void ThreadMethod(Object info)
        {
            threadSafeLabel1.Text = info.ToString();
        }
    }
}
