namespace MYSocialNetwork
{
    partial class frmFollow
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
            this.dgvFollow = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFollower = new System.Windows.Forms.Label();
            this.lblFollowing = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFollow
            // 
            this.dgvFollow.AllowUserToAddRows = false;
            this.dgvFollow.AllowUserToDeleteRows = false;
            this.dgvFollow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFollow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFollow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFollow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvFollow.Location = new System.Drawing.Point(2, 81);
            this.dgvFollow.Name = "dgvFollow";
            this.dgvFollow.ReadOnly = true;
            this.dgvFollow.RowHeadersWidth = 51;
            this.dgvFollow.RowTemplate.Height = 24;
            this.dgvFollow.Size = new System.Drawing.Size(555, 269);
            this.dgvFollow.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "شناسه";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "followerusername";
            this.Column2.HeaderText = "دنبال کننده";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "followingusername";
            this.Column3.HeaderText = "دنبال شونده";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // lblFollower
            // 
            this.lblFollower.AutoSize = true;
            this.lblFollower.Location = new System.Drawing.Point(394, 9);
            this.lblFollower.Name = "lblFollower";
            this.lblFollower.Size = new System.Drawing.Size(44, 18);
            this.lblFollower.TabIndex = 1;
            this.lblFollower.Text = "label1";
            // 
            // lblFollowing
            // 
            this.lblFollowing.AutoSize = true;
            this.lblFollowing.Location = new System.Drawing.Point(394, 38);
            this.lblFollowing.Name = "lblFollowing";
            this.lblFollowing.Size = new System.Drawing.Size(44, 18);
            this.lblFollowing.TabIndex = 2;
            this.lblFollowing.Text = "label2";
            // 
            // frmFollow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 347);
            this.Controls.Add(this.lblFollowing);
            this.Controls.Add(this.lblFollower);
            this.Controls.Add(this.dgvFollow);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFollow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmFollow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFollow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lblFollower;
        private System.Windows.Forms.Label lblFollowing;
    }
}