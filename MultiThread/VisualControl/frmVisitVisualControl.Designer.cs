﻿namespace AccumulatingCode.MultiThread.VisualControl
{
    partial class frmVisitVisualControl
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
            this.lblShow = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(38, 24);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(29, 12);
            this.lblShow.TabIndex = 0;
            this.lblShow.Text = "显示";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(40, 71);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 38);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "多线程访问标签";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmVisitVisualControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 155);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblShow);
            this.Name = "frmVisitVisualControl";
            this.Text = "多线程访问可视化控件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnOK;
    }
}

