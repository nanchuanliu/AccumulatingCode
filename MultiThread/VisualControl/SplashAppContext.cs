using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccumulatingCode.MultiThread.VisualControl
{
    class SplashAppContext : ApplicationContext
    {
        private Form realMainForm = null;

        //先将启动屏幕窗体设置为ApplicationContext对象的主窗体
        public SplashAppContext(Form mainForm, Form splashForm)
            : base(splashForm)
        {
            this.realMainForm = mainForm;   //将真正的主窗体先放在私有字段中保存起来
        }

        protected override void OnMainFormClosed(object sender, EventArgs e)
        {
            if (sender is frmSplash2) //启动屏幕窗体关闭，切换为真正的主窗体，并显示
            {
                base.MainForm = this.realMainForm;
                base.MainForm.Show();
            }
            else if (sender is frmMain)
            //主窗体关闭，调用基类的主窗体关闭方法，结束主线程
            {
                base.OnMainFormClosed(sender, e);
            }

        }
    }
}
