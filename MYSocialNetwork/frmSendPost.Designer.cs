namespace MYSocialNetwork
{
    partial class frmSendPost
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
            this.pbPImage = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLike = new System.Windows.Forms.Button();
            this.lblLikeCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPImage
            // 
            this.pbPImage.Location = new System.Drawing.Point(443, 51);
            this.pbPImage.Name = "pbPImage";
            this.pbPImage.Size = new System.Drawing.Size(348, 302);
            this.pbPImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPImage.TabIndex = 0;
            this.pbPImage.TabStop = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(443, 357);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(345, 33);
            this.btnChooseImage.TabIndex = 1;
            this.btnChooseImage.Text = "انتخاب عکس";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(222, 19);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(498, 26);
            this.txtCaption.TabIndex = 2;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(3, 84);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(434, 268);
            this.txtText.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(43, 19);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 18);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(738, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "عنوان :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "متن پست :";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(416, 399);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(124, 36);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "ارسال پست";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(276, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 36);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLike
            // 
            this.btnLike.Enabled = false;
            this.btnLike.Location = new System.Drawing.Point(189, 357);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(160, 33);
            this.btnLike.TabIndex = 9;
            this.btnLike.Text = "پسند کردن";
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // lblLikeCount
            // 
            this.lblLikeCount.AutoSize = true;
            this.lblLikeCount.Location = new System.Drawing.Point(43, 364);
            this.lblLikeCount.Name = "lblLikeCount";
            this.lblLikeCount.Size = new System.Drawing.Size(44, 18);
            this.lblLikeCount.TabIndex = 10;
            this.lblLikeCount.Text = "label3";
            // 
            // frmSendPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.lblLikeCount);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtCaption);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.pbPImage);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSendPost";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ارسال پست";
            this.Load += new System.EventHandler(this.frmSendPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPImage;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Label lblLikeCount;
    }
}