using SN.DataLayer;
using SN.DataLayer.Context;
using SN.Utility.Convertor;
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
    public partial class frmPost : Form
    {
        private string PostDate;
       // private int TypeOfPage;
        public frmPost()
        {
            InitializeComponent();
            //TypeOfPage = type;
        }

        private void frmPost_Load(object sender, EventArgs e)
        {
            FillDGVPost();

        }
        public void FillDGVPost()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvPost.AutoGenerateColumns = false;
                List<Post> posts = new List<Post>();
                posts = db.PostRepository.GetPostsByUserName(frmLogin.UN).ToList();
                //foreach(Post p in posts)
                //{
                //    //PostDate = p.pdate;
                //    //dgvPost.CurrentRow.Cells[0].Value = p.pid;
                //    //dgvPost.CurrentRow.Cells[1].Value = p.pcaption;
                //    //dgvPost.CurrentRow.Cells[2].Value = p.ptext;
                //    //dgvPost.CurrentRow.Cells[3].Value = p.pdate;
                //    //MessageBox.Show(p.pid +" "+PostDate);
                //}
                dgvPost.DataSource = posts;

            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillDGVPost();
        }

        private void btnSendPost_Click(object sender, EventArgs e)
        {
            frmSendPost frmSP = new frmSendPost(1,0);
            frmSP.ShowDialog();
        }
    }
}
