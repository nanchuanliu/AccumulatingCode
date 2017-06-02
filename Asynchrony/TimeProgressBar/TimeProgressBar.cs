using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccumulatingCode.Asynchrony.TimeProgressBar
{
    public partial class TimeProgressBar : UserControl
    {
        public delegate void TimeIsUpDelegate();

        public event TimeIsUpDelegate TimeIsUp;

        public TimeProgressBar()
        {
            InitializeComponent();

            timer1.Enabled = false;
        }


        private double TotalSeconds = 0;
        private TimeSpan TotalTime;
        private DateTime BeginTime;


        public void SetTimeSpan(int hour, int minute, int second)
        {
            TotalTime = new TimeSpan(hour, minute, second);
            TotalSeconds = TotalTime.TotalSeconds;
            Initialize();
        }


        private void Initialize()
        {
            BeginTime = DateTime.Now;
            progressBar1.Value = 0;
            timer1.Enabled = true;
        }


        private void Begin(object sender, EventArgs e)
        {
            TimeSpan ElapsedTime = (DateTime.Now - BeginTime);
            int temp = (int)ElapsedTime.TotalSeconds;
            if (temp > progressBar1.Maximum)
                temp = progressBar1.Maximum;
            progressBar1.Value = temp;

            if (ElapsedTime >= TotalTime)
            {
                timer1.Enabled = false;
                TimeIsUp();
            }

        }
    }
}
