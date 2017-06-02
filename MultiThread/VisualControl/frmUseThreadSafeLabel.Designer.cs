namespace AccumulatingCode.MultiThread.VisualControl
{
    partial class frmUseThreadSafeLabel
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
            this.threadSafeLabel1 = new AccumulatingCode.CustomControl.ThreadSafeLabel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.gpbShow = new System.Windows.Forms.GroupBox();
            this.gpbShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // threadSafeLabel1
            // 
            this.threadSafeLabel1.AutoSize = true;
            this.threadSafeLabel1.Location = new System.Drawing.Point(20, 34);
            this.threadSafeLabel1.Name = "threadSafeLabel1";
            this.threadSafeLabel1.Size = new System.Drawing.Size(161, 12);
            this.threadSafeLabel1.TabIndex = 0;
            this.threadSafeLabel1.Text = "此标签可被安全地跨线程使用";
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(197, 149);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(75, 23);
            this.btnSetting.TabIndex = 8;
            this.btnSetting.Text = "设置";
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(9, 149);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(177, 21);
            this.txtInput.TabIndex = 7;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(7, 112);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(209, 12);
            this.lblTip.TabIndex = 6;
            this.lblTip.Text = "说明：输入字符串后单击“设置”按钮";
            // 
            // gpbShow
            // 
            this.gpbShow.Controls.Add(this.threadSafeLabel1);
            this.gpbShow.Location = new System.Drawing.Point(8, 12);
            this.gpbShow.Name = "gpbShow";
            this.gpbShow.Size = new System.Drawing.Size(264, 82);
            this.gpbShow.TabIndex = 5;
            this.gpbShow.TabStop = false;
            this.gpbShow.Text = "跨线程访问的控件";
            // 
            // frmUseThreadSafeLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 198);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.gpbShow);
            this.Name = "frmUseThreadSafeLabel";
            this.Text = "frmUseThreadSafeLabel";
            this.gpbShow.ResumeLayout(false);
            this.gpbShow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.ThreadSafeLabel threadSafeLabel1;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.GroupBox gpbShow;
    }
}