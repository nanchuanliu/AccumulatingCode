namespace AccumulatingCode.MultiThread.VisualControl
{
    partial class frmReaderWriterLock
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblReader1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblReader2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblReader3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnWriter = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblReader1);
            this.groupBox1.Location = new System.Drawing.Point(13, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "读线程1";
            // 
            // lblReader1
            // 
            this.lblReader1.AutoSize = true;
            this.lblReader1.Location = new System.Drawing.Point(39, 28);
            this.lblReader1.Name = "lblReader1";
            this.lblReader1.Size = new System.Drawing.Size(41, 12);
            this.lblReader1.TabIndex = 0;
            this.lblReader1.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblReader2);
            this.groupBox2.Location = new System.Drawing.Point(162, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "读线程2";
            // 
            // lblReader2
            // 
            this.lblReader2.AutoSize = true;
            this.lblReader2.Location = new System.Drawing.Point(39, 28);
            this.lblReader2.Name = "lblReader2";
            this.lblReader2.Size = new System.Drawing.Size(41, 12);
            this.lblReader2.TabIndex = 0;
            this.lblReader2.Text = "label2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblReader3);
            this.groupBox3.Location = new System.Drawing.Point(315, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 62);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "读线程3";
            // 
            // lblReader3
            // 
            this.lblReader3.AutoSize = true;
            this.lblReader3.Location = new System.Drawing.Point(43, 28);
            this.lblReader3.Name = "lblReader3";
            this.lblReader3.Size = new System.Drawing.Size(41, 12);
            this.lblReader3.TabIndex = 0;
            this.lblReader3.Text = "label3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnWriter);
            this.groupBox4.Controls.Add(this.txtNumber);
            this.groupBox4.Location = new System.Drawing.Point(13, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(427, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "写线程";
            // 
            // btnWriter
            // 
            this.btnWriter.Location = new System.Drawing.Point(281, 41);
            this.btnWriter.Name = "btnWriter";
            this.btnWriter.Size = new System.Drawing.Size(134, 23);
            this.btnWriter.TabIndex = 1;
            this.btnWriter.Text = "写入共享资源";
            this.btnWriter.UseVisualStyleBackColor = true;
            this.btnWriter.Click += new System.EventHandler(this.btnWriter_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(27, 43);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(244, 21);
            this.txtNumber.TabIndex = 0;
            // 
            // frmReaderWriterLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 236);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReaderWriterLock";
            this.Text = "线程同步示例-单写多读";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblReader1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblReader2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblReader3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnWriter;
        private System.Windows.Forms.TextBox txtNumber;
    }
}