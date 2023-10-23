namespace MYSocialNetwork
{
    partial class frmProfile
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
            this.txtAbout = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dgvPosts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.عنوان = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.متن = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تاریخ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnFollowing = new System.Windows.Forms.Button();
            this.btnFollower = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblMobile = new System.Windows.Forms.Label();
            this.pbProfileImage = new System.Windows.Forms.PictureBox();
            this.btnInbox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAbout
            // 
            this.txtAbout.Enabled = false;
            this.txtAbout.Location = new System.Drawing.Point(12, 40);
            this.txtAbout.Multiline = true;
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.Size = new System.Drawing.Size(791, 127);
            this.txtAbout.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(42, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 18);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "label1";
            // 
            // dgvPosts
            // 
            this.dgvPosts.AllowUserToAddRows = false;
            this.dgvPosts.AllowUserToDeleteRows = false;
            this.dgvPosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.عنوان,
            this.متن,
            this.تاریخ});
            this.dgvPosts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPosts.Location = new System.Drawing.Point(0, 223);
            this.dgvPosts.Name = "dgvPosts";
            this.dgvPosts.ReadOnly = true;
            this.dgvPosts.RowHeadersWidth = 51;
            this.dgvPosts.RowTemplate.Height = 24;
            this.dgvPosts.Size = new System.Drawing.Size(942, 283);
            this.dgvPosts.TabIndex = 3;
            this.dgvPosts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPosts_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "pid";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // عنوان
            // 
            this.عنوان.DataPropertyName = "pcaption";
            this.عنوان.HeaderText = "عنوان";
            this.عنوان.MinimumWidth = 6;
            this.عنوان.Name = "عنوان";
            this.عنوان.ReadOnly = true;
            // 
            // متن
            // 
            this.متن.DataPropertyName = "ptext";
            this.متن.HeaderText = "متن";
            this.متن.MinimumWidth = 6;
            this.متن.Name = "متن";
            this.متن.ReadOnly = true;
            // 
            // تاریخ
            // 
            this.تاریخ.DataPropertyName = "pdate";
            this.تاریخ.HeaderText = "تاریخ";
            this.تاریخ.MinimumWidth = 6;
            this.تاریخ.Name = "تاریخ";
            this.تاریخ.ReadOnly = true;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(434, 173);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(107, 32);
            this.btnPost.TabIndex = 5;
            this.btnPost.Text = "پست گذاشتن";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnFollowing
            // 
            this.btnFollowing.Location = new System.Drawing.Point(213, 173);
            this.btnFollowing.Name = "btnFollowing";
            this.btnFollowing.Size = new System.Drawing.Size(108, 32);
            this.btnFollowing.TabIndex = 6;
            this.btnFollowing.Text = "دنبال شدگان";
            this.btnFollowing.UseVisualStyleBackColor = true;
            this.btnFollowing.Click += new System.EventHandler(this.btnFollowing_Click);
            // 
            // btnFollower
            // 
            this.btnFollower.Location = new System.Drawing.Point(327, 173);
            this.btnFollower.Name = "btnFollower";
            this.btnFollower.Size = new System.Drawing.Size(101, 32);
            this.btnFollower.TabIndex = 7;
            this.btnFollower.Text = "دنبال کنندگان";
            this.btnFollower.UseVisualStyleBackColor = true;
            this.btnFollower.Click += new System.EventHandler(this.btnFollower_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(105, 173);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 32);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(7, 173);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 32);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "حذف اکانت";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(674, 173);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(129, 32);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "ویرایش اطلاعات";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(695, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 32);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "تازه سازی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(166, 19);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(44, 18);
            this.lblMobile.TabIndex = 12;
            this.lblMobile.Text = "label1";
            // 
            // pbProfileImage
            // 
            this.pbProfileImage.Image = global::MYSocialNetwork.Properties.Resources.no_photo;
            this.pbProfileImage.Location = new System.Drawing.Point(809, 12);
            this.pbProfileImage.Name = "pbProfileImage";
            this.pbProfileImage.Size = new System.Drawing.Size(133, 193);
            this.pbProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfileImage.TabIndex = 0;
            this.pbProfileImage.TabStop = false;
            // 
            // btnInbox
            // 
            this.btnInbox.Location = new System.Drawing.Point(547, 173);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(110, 32);
            this.btnInbox.TabIndex = 13;
            this.btnInbox.Text = "پیامها";
            this.btnInbox.UseVisualStyleBackColor = true;
            this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 506);
            this.Controls.Add(this.btnInbox);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnFollower);
            this.Controls.Add(this.btnFollowing);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.dgvPosts);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtAbout);
            this.Controls.Add(this.pbProfileImage);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "frmProfile";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "پروفایل کاربر";
            this.Load += new System.EventHandler(this.frmProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProfileImage;
        private System.Windows.Forms.TextBox txtAbout;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dgvPosts;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnFollowing;
        private System.Windows.Forms.Button btnFollower;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn عنوان;
        private System.Windows.Forms.DataGridViewTextBoxColumn متن;
        private System.Windows.Forms.DataGridViewTextBoxColumn تاریخ;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Button btnInbox;
    }
}