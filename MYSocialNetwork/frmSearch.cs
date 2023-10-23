using SN.DataLayer;
using SN.DataLayer.Context;
using SN.ViewModel.User;
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
    public partial class frmSearch : Form
    {
        UnitOfWork db;
        List<MyUser> users;
        public frmSearch()
        {
            InitializeComponent();
            db = new UnitOfWork();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //using(UnitOfWork db = new UnitOfWork())
            //{
                UserImageAboutViewModel ui = db.UserRepository.GetUserNameAndImageAddressAndAbout(txtSearch.Text);
                if (txtSearch.Text !="" && ui != null)
                {
                    pbUserPicture.ImageLocation = ui.UImage;
                    lblUserName.Text = ui.UserName;
                    txtAbout.Text = ui.About;
                }
                else
                {
                    pbUserPicture.ImageLocation = "";
                    lblUserName.Text = "";
                    txtAbout.Text = "";
                }

            //}
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            BindGrid();   
        }
        public void BindGrid()
        {
            
            dgvUsers.AutoGenerateColumns = false;
            users = db.UserRepository.GetAllUsers().ToList();
            dgvUsers.DataSource = users;
        }
        
        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GoToUserPage();
        }
        public void GoToUserPage()
        {
            string userName = dgvUsers.CurrentRow.Cells[0].Value.ToString();
            frmUserPage frmUP = new frmUserPage(userName);
            frmUP.ShowDialog();
        }

        

        //private void dgvUsers_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        //{
        //    int uId =(int) dgvUsers.CurrentRow.Cells[0].Value;
        //    frmUserPage frmUP = new frmUserPage(uId);
        //    frmUP.ShowDialog();
        //}
    }
}
