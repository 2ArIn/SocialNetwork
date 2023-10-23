using SN.DataLayer;
using SN.DataLayer.Context;
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
    public partial class frmSignUp : Form
    {
        private static string UserName;
        private static string UImage;
        private MyUser user;
        public frmSignUp(string userName)
        {
            InitializeComponent();
            UserName = userName;
            user = new MyUser();
        }

        public void FillControlByUserInfo(MyUser user)
        {
            txtUserName.Text = user.username;
            txtAbout.Text = user.about;
            txtMobile.Text = user.mobile;
            txtEmail.Text = user.email;
            txtPassword.Text = user.password;
            txtConfirmPassword.Text = user.password;
            pbProfilePic.ImageLocation = user.uimage;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using(UnitOfWork db = new UnitOfWork())
            {
                user.about = txtAbout.Text;
                user.mobile = txtMobile.Text;
                user.email = txtEmail.Text;
                user.username = txtUserName.Text;
                user.password = txtConfirmPassword.Text;
                //MyUser user = new MyUser();
                if (UserName =="")
                {
                    user.uimage = UImage;
                    
                    if(txtUserName.Text =="" || txtPassword.Text =="")
                    {
                        RtlMessageBox.Show("لطفا نام کاربری و رمز عبور را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if(txtPassword.Text != txtConfirmPassword.Text)
                    {
                        RtlMessageBox.Show("پسورد و تایید پسورد یکی نیست", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if(txtMobile.Text =="" || txtConfirmPassword.Text == "" )
                    {
                        RtlMessageBox.Show("لطفا همه فیلدها را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        if(db.UserRepository.GetUserByUserName(UserName) != null)
                        {
                            RtlMessageBox.Show("نام کاربری موجود است .", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if(db.UserRepository.InsertUser(user))
                        {
                            db.Save();
                            RtlMessageBox.Show("کاربر جدید با موفقیت اضافه شد", "موفقیت",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            this.Hide();
                        }
                        else
                        {
                            RtlMessageBox.Show("خطا در ثبت کاربر جدید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    
                    //FillControlByUserInfo(user);
                    
                    //MessageBox.Show(user.username + " " + user.password);
                    
                    if (db.UserGRepository.Update(user))
                    {
                        db.Save();
                        RtlMessageBox.Show("کاربر با موفقیت ویرایش شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                    {
                        RtlMessageBox.Show("خطا در ویرایش کاربر ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                

            }
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            if(UserName == "")
            {
                this.Text = "فرم ثبت نام";
            }
            else
            {
                this.Text = "فرم ویرایش اطلاعات";
                using(UnitOfWork db = new UnitOfWork())
                {
                    user = db.UserRepository.GetUserByUserName(UserName);
                    FillControlByUserInfo(user);
                }
            }

        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            //user.uimage = ImageSaver.ImageCreator(pbProfilePic);
            user.uimage = pbProfilePic.ImageCreator();
        }
    }
}
