namespace AccumulatingCode.Asynchrony.TimeProgressBar
{
    partial class frmTimeProgressBar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbTime = new System.Windows.Forms.GroupBox();
            this.btnSetup = new System.Windows.Forms.Button();
            this.updnSecond = new System.Windows.Forms.NumericUpDown();
            this.updnMinute = new System.Windows.Forms.NumericUpDown();
            this.updnHour = new System.Windows.Forms.NumericUpDown();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.timeProgressBar1 = new AccumulatingCode.Asynchrony.TimeProgressBar.TimeProgressBar();
            this.gpbTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnHour)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbTime
            // 
            this.gpbTime.Controls.Add(this.btnSetup);
            this.gpbTime.Controls.Add(this.updnSecond);
            this.gpbTime.Controls.Add(this.updnMinute);
            this.gpbTime.Controls.Add(this.updnHour);
            this.gpbTime.Controls.Add(this.lblSecond);
            this.gpbTime.Controls.Add(this.lblMinute);
            this.gpbTime.Controls.Add(this.lblHour);
            this.gpbTime.Location = new System.Drawing.Point(12, 12);
            this.gpbTime.Name = "gpbTime";
            this.gpbTime.Size = new System.Drawing.Size(378, 129);
            this.gpbTime.TabIndex = 0;
            this.gpbTime.TabStop = false;
            this.gpbTime.Text = "设置闹钟时间";
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(265, 43);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(82, 48);
            this.btnSetup.TabIndex = 4;
            this.btnSetup.Text = "确定";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // updnSecond
            // 
            this.updnSecond.Location = new System.Drawing.Point(176, 70);
            this.updnSecond.Name = "updnSecond";
            this.updnSecond.Size = new System.Drawing.Size(47, 21);
            this.updnSecond.TabIndex = 3;
            // 
            // updnMinute
            // 
            this.updnMinute.Location = new System.Drawing.Point(102, 70);
            this.updnMinute.Name = "updnMinute";
            this.updnMinute.Size = new System.Drawing.Size(47, 21);
            this.updnMinute.TabIndex = 3;
            // 
            // updnHour
            // 
            this.updnHour.Location = new System.Drawing.Point(28, 70);
            this.updnHour.Name = "updnHour";
            this.updnHour.Size = new System.Drawing.Size(47, 21);
            this.updnHour.TabIndex = 3;
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(174, 40);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(29, 12);
            this.lblSecond.TabIndex = 2;
            this.lblSecond.Text = "秒：";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(100, 40);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(29, 12);
            this.lblMinute.TabIndex = 1;
            this.lblMinute.Text = "分：";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(26, 40);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(41, 12);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "小时：";
            // 
            // timeProgressBar1
            // 
            this.timeProgressBar1.Location = new System.Drawing.Point(13, 159);
            this.timeProgressBar1.Name = "timeProgressBar1";
            this.timeProgressBar1.Size = new System.Drawing.Size(377, 27);
            this.timeProgressBar1.TabIndex = 1;
            this.timeProgressBar1.TimeIsUp += new AccumulatingCode.Asynchrony.TimeProgressBar.TimeProgressBar.TimeIsUpDelegate(this.timeProgressBar1_TimeIsUp);
            // 
            // frmTimeProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 210);
            this.Controls.Add(this.timeProgressBar1);
            this.Controls.Add(this.gpbTime);
            this.Name = "frmTimeProgressBar";
            this.Text = "拥有自定义事件的进度条控件";
            this.gpbTime.ResumeLayout(false);
            this.gpbTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnHour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbTime;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.NumericUpDown updnSecond;
        private System.Windows.Forms.NumericUpDown updnMinute;
        private System.Windows.Forms.NumericUpDown updnHour;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblHour;
        private TimeProgressBar timeProgressBar1;
    }
}

