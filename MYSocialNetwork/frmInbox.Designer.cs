namespace MYSocialNetwork
{
    partial class frmInbox
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
            this.dgvInbox = new System.Windows.Forms.DataGridView();
            this.lblSMessageCount = new System.Windows.Forms.Label();
            this.lblRMessageCount = new System.Windows.Forms.Label();
            this.btnRMessage = new System.Windows.Forms.Button();
            this.btnSMessage = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInbox)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInbox
            // 
            this.dgvInbox.AllowUserToAddRows = false;
            this.dgvInbox.AllowUserToDeleteRows = false;
            this.dgvInbox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInbox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvInbox.Location = new System.Drawing.Point(-2, 74);
            this.dgvInbox.Name = "dgvInbox";
            this.dgvInbox.ReadOnly = true;
            this.dgvInbox.RowHeadersWidth = 51;
            this.dgvInbox.RowTemplate.Height = 24;
            this.dgvInbox.Size = new System.Drawing.Size(516, 298);
            this.dgvInbox.TabIndex = 0;
            this.dgvInbox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInbox_CellContentClick);
            // 
            // lblSMessageCount
            // 
            this.lblSMessageCount.AutoSize = true;
            this.lblSMessageCount.Location = new System.Drawing.Point(63, 9);
            this.lblSMessageCount.Name = "lblSMessageCount";
            this.lblSMessageCount.Size = new System.Drawing.Size(44, 18);
            this.lblSMessageCount.TabIndex = 1;
            this.lblSMessageCount.Text = "label1";
            // 
            // lblRMessageCount
            // 
            this.lblRMessageCount.AutoSize = true;
            this.lblRMessageCount.Location = new System.Drawing.Point(63, 39);
            this.lblRMessageCount.Name = "lblRMessageCount";
            this.lblRMessageCount.Size = new System.Drawing.Size(44, 18);
            this.lblRMessageCount.TabIndex = 2;
            this.lblRMessageCount.Text = "label1";
            // 
            // btnRMessage
            // 
            this.btnRMessage.Location = new System.Drawing.Point(370, 25);
            this.btnRMessage.Name = "btnRMessage";
            this.btnRMessage.Size = new System.Drawing.Size(120, 32);
            this.btnRMessage.TabIndex = 3;
            this.btnRMessage.Text = "پیامهای دریافتی";
            this.btnRMessage.UseVisualStyleBackColor = true;
            this.btnRMessage.Click += new System.EventHandler(this.btnRMessage_Click);
            // 
            // btnSMessage
            // 
            this.btnSMessage.Location = new System.Drawing.Point(229, 25);
            this.btnSMessage.Name = "btnSMessage";
            this.btnSMessage.Size = new System.Drawing.Size(121, 32);
            this.btnSMessage.TabIndex = 4;
            this.btnSMessage.Text = "پیامهای ارسالی";
            this.btnSMessage.UseVisualStyleBackColor = true;
            this.btnSMessage.Click += new System.EventHandler(this.btnSMessage_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "mid";
            this.Column1.HeaderText = "شناسه";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "musername";
            this.Column2.HeaderText = "ارسال کننده";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "username";
            this.Column3.HeaderText = "دریافت کننده";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "mdate";
            this.Column4.HeaderText = "تاریخ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "mtext";
            this.Column5.HeaderText = "متن پیام";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // frmInbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 374);
            this.Controls.Add(this.btnSMessage);
            this.Controls.Add(this.btnRMessage);
            this.Controls.Add(this.lblRMessageCount);
            this.Controls.Add(this.lblSMessageCount);
            this.Controls.Add(this.dgvInbox);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInbox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "جعبه دریافت پیام";
            this.Load += new System.EventHandler(this.frmInbox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInbox;
        private System.Windows.Forms.Label lblSMessageCount;
        private System.Windows.Forms.Label lblRMessageCount;
        private System.Windows.Forms.Button btnRMessage;
        private System.Windows.Forms.Button btnSMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}