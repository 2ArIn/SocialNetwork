using SN.DataLayer;
using SN.DataLayer.Context;
using SN.Utility.Convertor;
using SN.Utility.WorkWithImage;
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
    public partial class frmSendPost : Form
    {
        private string uimage;
        private int TypeOfPage;
        private int PId;
        private UnitOfWork db;
        private int LId;
        private MyLike like;
        public frmSendPost(int typeOfPage,int pId)
        {
            InitializeComponent();
            TypeOfPage = typeOfPage;
            PId = pId;
        }

        private void frmSendPost_Load(object sender, EventArgs e)
        {
            if(TypeOfPage == 1)
            {
                FillControlLoad();
            }
            else if(TypeOfPage ==2)
            {
                FetchPost();   
            }
        }
        public void FillControlLoad()
        {
            lblDate.Text = (string)DateTime.Now.MiladiToShamsi();

        }
        public void FetchPost()
        {
            db = new UnitOfWork();
            Post post = new Post();
            post = db.PostRepository.GetPostById(PId);
            txtCaption.Text = post.pcaption;
            txtText.Text = post.ptext;
            lblDate.Text = post.pdate;
            pbPImage.ImageLocation = post.pimage;
            this.Text = "پست " + post.pusername;
            btnCancel.Visible = false;
            btnSend.Visible = false;
            btnChooseImage.Visible = false;
            txtCaption.Enabled = false;
            txtText.Enabled = false;
            btnLike.Enabled = true;
            lblLikeCount.Text = db.LikeRepository.PostLikeCount(PId).ToString();
            if(db.LikeRepository.FindLIdByPidAndUserName(PId, frmLogin.UN) !=0)
            {
                btnLike.BackColor = Color.Red;
            }
            else
            {
                btnLike.BackColor = Color.White;
            }

        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            uimage = pbPImage.ImageCreator();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                Post post = new Post();
                post.pcaption = txtCaption.Text;
                post.pimage = uimage;
                post.ptext = txtText.Text;
                post.pdate = DateTime.Now.MiladiToShamsi();
                post.pusername = frmLogin.UN;
                using(UnitOfWork db = new UnitOfWork())
                {
                    db.PostRepository.InsertPost(post);
                    db.Save();
                }
                RtlMessageBox.Show("پست با موفقیت ارسال شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch
            {
                RtlMessageBox.Show("ارسال پست با خطا مواجه گردید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            LId = db.LikeRepository.FindLIdByPidAndUserName(PId, frmLogin.UN);
            like = db.LikeRepository.FindMyLikeByUserNameAndPId(frmLogin.UN,PId);
            MessageBox.Show("LId = " + LId);
            if(LId != 0)
            {
                btnLike.BackColor = Color.White;
                db.LikeRepository.DeleteFromLike(like);
                db.Save();
                lblLikeCount.Text = db.LikeRepository.PostLikeCount(PId).ToString();
                //MessageBox.Show("بود حذف کردیم LId = " + LId);
            }
            else
            {
                like = new MyLike();
                like.pid = PId;
                like.lusername = frmLogin.UN;
                like.ldate = DateTime.Now.MiladiToShamsi();
                btnLike.BackColor = Color.Red;
                db.LikeRepository.InsertToLike(like);
                db.Save();
                lblLikeCount.Text = db.LikeRepository.PostLikeCount(PId).ToString();
               // MessageBox.Show("نبود درج کردیمLId = " + LId);

            }
        }
    }
}
