namespace MYSocialNetwork
{
    partial class frmUserPage
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            this.btnFollowUnFollow = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.txtAbout = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUserName.Location = new System.Drawing.Point(375, 31);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(44, 18);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "label1";
            // 
            // pbUserImage
            // 
            this.pbUserImage.Location = new System.Drawing.Point(12, 12);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.Size = new System.Drawing.Size(143, 169);
            this.pbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserImage.TabIndex = 1;
            this.pbUserImage.TabStop = false;
            // 
            // btnFollowUnFollow
            // 
            this.btnFollowUnFollow.Location = new System.Drawing.Point(245, 227);
            this.btnFollowUnFollow.Name = "btnFollowUnFollow";
            this.btnFollowUnFollow.Size = new System.Drawing.Size(137, 42);
            this.btnFollowUnFollow.TabIndex = 3;
            this.btnFollowUnFollow.Text = "دنبال کردن";
            this.btnFollowUnFollow.UseVisualStyleBackColor = true;
            this.btnFollowUnFollow.Click += new System.EventHandler(this.btnFollowUnFollow_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(92, 227);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(137, 42);
            this.btnMessage.TabIndex = 4;
            this.btnMessage.Text = "ارسال پیام";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // txtAbout
            // 
            this.txtAbout.Enabled = false;
            this.txtAbout.Location = new System.Drawing.Point(171, 64);
            this.txtAbout.Multiline = true;
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.Size = new System.Drawing.Size(284, 117);
            this.txtAbout.TabIndex = 5;
            // 
            // frmUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 281);
            this.Controls.Add(this.txtAbout);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.btnFollowUnFollow);
            this.Controls.Add(this.pbUserImage);
            this.Controls.Add(this.lblUserName);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "frmUserPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "صفحه کاربری";
            this.Load += new System.EventHandler(this.frmUserPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pbUserImage;
        private System.Windows.Forms.Button btnFollowUnFollow;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.TextBox txtAbout;
    }
}