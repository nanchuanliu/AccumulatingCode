namespace AccumulatingCode.MultiThread.VisualControl
{
    partial class frmWhatIsThread
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStartSingleThread = new System.Windows.Forms.Button();
            this.progressBarSingleThread = new System.Windows.Forms.ProgressBar();
            this.lblSingleThreadID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStartMultiThread2 = new System.Windows.Forms.Button();
            this.progressBarMultiThread2 = new System.Windows.Forms.ProgressBar();
            this.lblMultiThread2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStartMultiThread1 = new System.Windows.Forms.Button();
            this.progressBarMultiThread1 = new System.Windows.Forms.ProgressBar();
            this.lblMultiThreadID1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "主线程ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStartSingleThread);
            this.groupBox1.Controls.Add(this.progressBarSingleThread);
            this.groupBox1.Controls.Add(this.lblSingleThreadID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(36, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 84);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "单线程运行";
            // 
            // btnStartSingleThread
            // 
            this.btnStartSingleThread.Location = new System.Drawing.Point(295, 35);
            this.btnStartSingleThread.Name = "btnStartSingleThread";
            this.btnStartSingleThread.Size = new System.Drawing.Size(55, 23);
            this.btnStartSingleThread.TabIndex = 3;
            this.btnStartSingleThread.Text = "启动";
            this.btnStartSingleThread.UseVisualStyleBackColor = true;
            // 
            // progressBarSingleThread
            // 
            this.progressBarSingleThread.Location = new System.Drawing.Point(101, 35);
            this.progressBarSingleThread.Name = "progressBarSingleThread";
            this.progressBarSingleThread.Size = new System.Drawing.Size(187, 23);
            this.progressBarSingleThread.TabIndex = 2;
            // 
            // lblSingleThreadID
            // 
            this.lblSingleThreadID.AutoSize = true;
            this.lblSingleThreadID.Location = new System.Drawing.Point(70, 39);
            this.lblSingleThreadID.Name = "lblSingleThreadID";
            this.lblSingleThreadID.Size = new System.Drawing.Size(11, 12);
            this.lblSingleThreadID.TabIndex = 1;
            this.lblSingleThreadID.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "线程ID：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStartMultiThread2);
            this.groupBox2.Controls.Add(this.progressBarMultiThread2);
            this.groupBox2.Controls.Add(this.lblMultiThread2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnStartMultiThread1);
            this.groupBox2.Controls.Add(this.progressBarMultiThread1);
            this.groupBox2.Controls.Add(this.lblMultiThreadID1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(36, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 124);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "多线程运行";
            // 
            // btnStartMultiThread2
            // 
            this.btnStartMultiThread2.Location = new System.Drawing.Point(287, 80);
            this.btnStartMultiThread2.Name = "btnStartMultiThread2";
            this.btnStartMultiThread2.Size = new System.Drawing.Size(55, 23);
            this.btnStartMultiThread2.TabIndex = 11;
            this.btnStartMultiThread2.Text = "启动";
            this.btnStartMultiThread2.UseVisualStyleBackColor = true;
            // 
            // progressBarMultiThread2
            // 
            this.progressBarMultiThread2.Location = new System.Drawing.Point(93, 80);
            this.progressBarMultiThread2.Name = "progressBarMultiThread2";
            this.progressBarMultiThread2.Size = new System.Drawing.Size(187, 23);
            this.progressBarMultiThread2.TabIndex = 10;
            // 
            // lblMultiThread2
            // 
            this.lblMultiThread2.AutoSize = true;
            this.lblMultiThread2.Location = new System.Drawing.Point(62, 84);
            this.lblMultiThread2.Name = "lblMultiThread2";
            this.lblMultiThread2.Size = new System.Drawing.Size(11, 12);
            this.lblMultiThread2.TabIndex = 9;
            this.lblMultiThread2.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "线程ID：";
            // 
            // btnStartMultiThread1
            // 
            this.btnStartMultiThread1.Location = new System.Drawing.Point(287, 29);
            this.btnStartMultiThread1.Name = "btnStartMultiThread1";
            this.btnStartMultiThread1.Size = new System.Drawing.Size(55, 23);
            this.btnStartMultiThread1.TabIndex = 7;
            this.btnStartMultiThread1.Text = "启动";
            this.btnStartMultiThread1.UseVisualStyleBackColor = true;
            this.btnStartMultiThread1.Click += new System.EventHandler(this.btnStartMultiThread1_Click);
            // 
            // progressBarMultiThread1
            // 
            this.progressBarMultiThread1.Location = new System.Drawing.Point(93, 29);
            this.progressBarMultiThread1.Name = "progressBarMultiThread1";
            this.progressBarMultiThread1.Size = new System.Drawing.Size(187, 23);
            this.progressBarMultiThread1.TabIndex = 6;
            // 
            // lblMultiThreadID1
            // 
            this.lblMultiThreadID1.AutoSize = true;
            this.lblMultiThreadID1.Location = new System.Drawing.Point(62, 33);
            this.lblMultiThreadID1.Name = "lblMultiThreadID1";
            this.lblMultiThreadID1.Size = new System.Drawing.Size(11, 12);
            this.lblMultiThreadID1.TabIndex = 5;
            this.lblMultiThreadID1.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "线程ID：";
            // 
            // frmWhatIsThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 309);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmWhatIsThread";
            this.Text = "什么是多线程？";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWhatIsThread_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStartSingleThread;
        private System.Windows.Forms.ProgressBar progressBarSingleThread;
        private System.Windows.Forms.Label lblSingleThreadID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStartMultiThread2;
        private System.Windows.Forms.ProgressBar progressBarMultiThread2;
        private System.Windows.Forms.Label lblMultiThread2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStartMultiThread1;
        private System.Windows.Forms.ProgressBar progressBarMultiThread1;
        private System.Windows.Forms.Label lblMultiThreadID1;
        private System.Windows.Forms.Label label5;
    }
}

