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
    public partial class frmUserPage : Form
    {
        UnitOfWork db;
        private string UserName;
        private bool IsExist;
        private MyFollow follow;
        public frmUserPage(string userName)
        {
            InitializeComponent();
            UserName= userName;
            db = new UnitOfWork();
            
        }

        private void frmUserPage_Load(object sender, EventArgs e)
        {
            FetchUserInfo();
            FindFollowing();
        }
        public void FetchUserInfo()
        {
            MyUser user=db.UserRepository.GetUserByUserName(UserName);
            lblUserName.Text = user.username;
            txtAbout.Text = user.about;
            pbUserImage.ImageLocation = user.uimage;

        }
        public void FindFollowing()
        {

            //follow = db.FollowRepository.FindFollowByErIngUserName(frmLogin.UN, UserName);
            IsExist = db.FollowRepository.GetAllFollwingByUserName(frmLogin.UN).Where(u=>u.followingusername.ToLower()==UserName.ToLower()).Any();
            
            //foreach (var l in list)
            //{
                if(IsExist)
                {
                    btnFollowUnFollow.Text = "لغو دنبال کردن";
                    btnFollowUnFollow.BackColor = Color.Red;
                    //MessageBox.Show(l.followingusername + ":" + lblUserName.Text.ToString());
                }
                else
                {
                    btnFollowUnFollow.BackColor = Color.White;
                    //MessageBox.Show(l.followingusername + ":" + lblUserName.Text.ToString());
                }
        }

        private void btnFollowUnFollow_Click(object sender, EventArgs e)
        {
            //IsExist = db.FollowRepository.FindFollowByErIngUserName(frmLogin.UN,UserName);
            int FId = db.FollowRepository.FindFid(frmLogin.UN, UserName);
            
            //MessageBox.Show(" Fid =" + db.FollowRepository.FindFid(frmLogin.UN, UserName));
            if (FId != 0)
            {
                btnFollowUnFollow.BackColor = Color.White;
                btnFollowUnFollow.Text = "دنبال کردن";
                //IsExist = false;
                //MessageBox.Show("بود حذف کردیم" + db.FollowRepository.FindFid(frmLogin.UN, UserName));
                db.FollowRepository.DeleteById(FId);
                db.Save();

            }
            else if(FId == 0 && frmLogin.UN.ToLower() == UserName.ToLower())
            {
                return;
            }
            else
            {
                follow = new MyFollow();
                follow.followerusername = frmLogin.UN;
                follow.followingusername = UserName;
                btnFollowUnFollow.BackColor = Color.Red;
                btnFollowUnFollow.Text = "لغو دنبال کردن";
                //IsExist = true;
                db.FollowRepository.InsertToFollow(follow);
                db.Save();
                //MessageBox.Show("نبود درج کردیم " + db.FollowRepository.FindFid(frmLogin.UN, UserName));
            }
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            frmSRMessage frmMsg = new frmSRMessage(1,UserName,"","");
            frmMsg.ShowDialog();
        }
    }
}
