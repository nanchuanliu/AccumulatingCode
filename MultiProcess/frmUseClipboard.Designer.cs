namespace AccumulatingCode.MultiProcess
{
    partial class frmUseClipboard
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
            this.lblImageInfo = new System.Windows.Forms.Label();
            this.txtImageInfo = new System.Windows.Forms.TextBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.btnLoadPicture = new System.Windows.Forms.Button();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnPasteFromClipboard = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImageInfo
            // 
            this.lblImageInfo.AutoSize = true;
            this.lblImageInfo.Location = new System.Drawing.Point(24, 36);
            this.lblImageInfo.Name = "lblImageInfo";
            this.lblImageInfo.Size = new System.Drawing.Size(65, 12);
            this.lblImageInfo.TabIndex = 0;
            this.lblImageInfo.Text = "图片说明：";
            // 
            // txtImageInfo
            // 
            this.txtImageInfo.Location = new System.Drawing.Point(95, 33);
            this.txtImageInfo.Name = "txtImageInfo";
            this.txtImageInfo.Size = new System.Drawing.Size(253, 21);
            this.txtImageInfo.TabIndex = 1;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(21, 75);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(400, 198);
            this.pictureBoxImage.TabIndex = 2;
            this.pictureBoxImage.TabStop = false;
            // 
            // btnLoadPicture
            // 
            this.btnLoadPicture.Location = new System.Drawing.Point(32, 297);
            this.btnLoadPicture.Name = "btnLoadPicture";
            this.btnLoadPicture.Size = new System.Drawing.Size(75, 31);
            this.btnLoadPicture.TabIndex = 3;
            this.btnLoadPicture.Text = "装入图片";
            this.btnLoadPicture.UseVisualStyleBackColor = true;
            this.btnLoadPicture.Click += new System.EventHandler(this.btnLoadPicture_Click);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(127, 297);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(89, 31);
            this.btnCopyToClipboard.TabIndex = 3;
            this.btnCopyToClipboard.Text = "复制到剪贴板";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnPasteFromClipboard
            // 
            this.btnPasteFromClipboard.Location = new System.Drawing.Point(236, 297);
            this.btnPasteFromClipboard.Name = "btnPasteFromClipboard";
            this.btnPasteFromClipboard.Size = new System.Drawing.Size(87, 31);
            this.btnPasteFromClipboard.TabIndex = 3;
            this.btnPasteFromClipboard.Text = "从剪贴板粘贴";
            this.btnPasteFromClipboard.UseVisualStyleBackColor = true;
            this.btnPasteFromClipboard.Click += new System.EventHandler(this.btnPasteFromClipboard_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(343, 297);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 31);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmUseClipboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 342);
            this.Controls.Add(this.btnPasteFromClipboard);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.btnLoadPicture);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.txtImageInfo);
            this.Controls.Add(this.lblImageInfo);
            this.Name = "frmUseClipboard";
            this.Text = "使用剪贴板传送信息";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImageInfo;
        private System.Windows.Forms.TextBox txtImageInfo;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button btnLoadPicture;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Button btnPasteFromClipboard;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}