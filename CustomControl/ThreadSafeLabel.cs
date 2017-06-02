using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccumulatingCode.CustomControl
{
    public partial class ThreadSafeLabel : Label
    {
        //多线程调用的委托
        delegate void SetString(string text);

        private delegate string GetString();

        //重写基类的Text属性
        public override string Text
        {
            get
            {
                if (InvokeRequired) //如果是跨线程调用
                {
                    GetString getDel = delegate()
                    {
                        return base.Text;
                    };
                    return (string)Invoke(getDel);
                }
                else  //普通调用
                {
                    return base.Text;
                }

            }
            set
            {
                if (InvokeRequired)
                {
                    SetString setDel = delegate(string text)
                    {
                        base.Text = text;
                    };
                    Invoke(setDel, new object[] { value });
                }
                else
                {
                    base.Text = value;
                }
            }
        }
    }
}
