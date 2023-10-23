using SN.DataLayer;
using SN.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SN.Utility.WorkWithImage;
using SN.Utility.Convertor;

namespace MYSocialNetwork
{
    public partial class frmProfile : Form
    {
        private static string UImage;
        

        public object ImageSaver { get; private set; }

        public frmProfile()
        {
            InitializeComponent();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            this.Text = "خوش آمدید "+frmLogin.UN;
            BindControl();
           // BindGrid();
        }
        private void BindControl()
        {
            using(UnitOfWork db = new UnitOfWork())
            {
                MyUser user = new MyUser();
                user = db.UserRepository.GetUserByUserName(frmLogin.UN);
                txtAbout.Text = user.about;
                lblMobile.Text = user.mobile;
                //lblDate.Text = (string)ToShamsi.MiladiToShamsi(DateTime.Now);
                lblDate.Text = (string)DateTime.Now.MiladiToShamsi();
                pbProfileImage.ImageLocation = user.uimage;
                //db.UserRepository.InsertUser(user);
                //var posts =  db.PostRepository.GetPostsByUserName(frmLogin.UN);
                //db.Save();
                //dgvPosts.AutoGenerateColumns = false;
                //dgvPosts.DataSource = posts;
                dgvPosts.AutoGenerateColumns = false;
                List<Post> list = new List<Post>();
                List<MyFollow> followingUsers = db.FollowRepository.GetAllFollwingByUserName(frmLogin.UN).ToList();
                foreach(var f in followingUsers)
                {
                    RtlMessageBox.Show(f.followingusername + " : " + f.followerusername);
                    list.AddRange(db.PostRepository.GetPostsByUserName(f.followingusername).OrderByDescending(p => p.pdate).ToList());
                }
                dgvPosts.DataSource = list;

            }
        }
        //public void BindGrid()
        //{
           
        //}

        //private void btnChooseImage_Click(object sender, EventArgs e)
        //{

        //   // string uimage = ImageSaver.ImageCreator(pbProfileImage);


        //    using (UnitOfWork db = new UnitOfWork())
        //        {
        //            MyUser user = new MyUser();
        //            user = db.UserRepository.GetUserByUserName(frmLogin.UN);
        //            user.uimage = UImage;
        //            db.UserRepository.UpdateUser(user);
        //            db.Save();
        //        }
        //}

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmSignUp frmSEdit = new frmSignUp(frmLogin.UN);
            frmSEdit.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindControl();
            //BindGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch frmSch = new frmSearch();
            frmSch.ShowDialog();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            frmPost frmP = new frmPost();
            frmP.ShowDialog();
        }

        private void btnFollower_Click(object sender, EventArgs e)
        {
            frmFollow frmFER = new frmFollow(1);
            frmFER.ShowDialog();
        }

        private void btnFollowing_Click(object sender, EventArgs e)
        {
            frmFollow frmFING = new frmFollow(2);
            frmFING.ShowDialog();
        }

        private void dgvPosts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pid = (int)dgvPosts.CurrentRow.Cells[0].Value;
            frmSendPost frmShowPost = new frmSendPost(2,pid);
            frmShowPost.ShowDialog();
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            frmInbox frmBox = new frmInbox();
            frmBox.ShowDialog();
        }
    }
}
