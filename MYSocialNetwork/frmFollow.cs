using SN.DataLayer;
using SN.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYSocialNetwork
{
    public partial class frmFollow : Form
    {
        public int FollowType;
        public frmFollow(int followType)
        {
            InitializeComponent();
            FollowType = followType;

        }
        public void BindFollowers()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                //MyFollow follower = new MyFollow();
                dgvFollow.AutoGenerateColumns = false;
                dgvFollow.DataSource = db.FollowRepository.GetAllFollowersByUserName(frmLogin.UN);
                this.Text = "دنبال کنندگان";
                lblFollowing.Visible = false;
                lblFollower.Text = "تعداد دنبال کنندگان "+db.FollowRepository.GetAllFollowersByUserName(frmLogin.UN).Count().ToString();
            }
        }
        public void BindFollowing()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
               // List<MyFollow> following = new List<MyFollow>();
                dgvFollow.AutoGenerateColumns = false;
               // following= db.FollowingRepository.GetAllFollwingByUserName(frmLogin.UN);
                dgvFollow.DataSource = db.FollowRepository.GetAllFollwingByUserName(frmLogin.UN);
                this.Text = "دنبال شوندگان";
                lblFollower.Visible = false;
                lblFollowing.Text = "تعداد دنبال شوندگان "+db.FollowRepository.GetAllFollwingByUserName(frmLogin.UN).Count().ToString();
            }
        }
        private void frmFollow_Load(object sender, EventArgs e)
        {
            if(FollowType ==1)
            {
                BindFollowers();
            }
            else if(FollowType == 2)
            {
                BindFollowing();
            }
            
        }
    }
}
