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
    public partial class frmLogin : Form
    {
        public static string UN;
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using(UnitOfWork db = new UnitOfWork())
            {
                if (txtUserName.Text == "" || txtPassword.Text == "")
                {
                    RtlMessageBox.Show("نام کاربری یا رمز عبور را وارد کنید", "خطا در ورود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (db.UserRepository.IsExistUserByUserNameAndPass(txtUserName.Text, txtPassword.Text))
                    {
                        UN = txtUserName.Text;
                        frmProfile frmP = new frmProfile();
                        this.Hide();
                        frmP.ShowDialog();
                    }
                    else
                    {
                        RtlMessageBox.Show("نام کاربری یا رمز عبور اشتباه است","خطا در ورود",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void llSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp frmSU = new frmSignUp("");
            frmSU.ShowDialog();
        }
    }
}
