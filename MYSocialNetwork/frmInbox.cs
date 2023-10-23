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
    public partial class frmInbox : Form
    {
        private UnitOfWork db; 
        public frmInbox()
        {
            InitializeComponent();
            db = new UnitOfWork();
        }

        private void frmInbox_Load(object sender, EventArgs e)
        {
            lblRMessageCount.Text = "تعداد پیامهای دریافتی : "+db.MessageRepository.GetRMessagesByUserName(frmLogin.UN).Count().ToString();
            lblSMessageCount.Text = "تعداد پیامهای ارسالی : " + db.MessageRepository.GetSMessageByUserName(frmLogin.UN).Count().ToString();

        }

        private void btnRMessage_Click(object sender, EventArgs e)
        {
            dgvInbox.AutoGenerateColumns = false;
            dgvInbox.DataSource = db.MessageRepository.GetRMessagesByUserName(frmLogin.UN);
        }

        private void btnSMessage_Click(object sender, EventArgs e)
        {
            dgvInbox.AutoGenerateColumns = false;
            dgvInbox.DataSource = db.MessageRepository.GetSMessageByUserName(frmLogin.UN);
        }

        private void dgvInbox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string SUserName = dgvInbox.CurrentRow.Cells[1].Value.ToString();
            string date = dgvInbox.CurrentRow.Cells[3].Value.ToString();
            string RUserName = dgvInbox.CurrentRow.Cells[2].Value.ToString();
            frmSRMessage frmSRM = new frmSRMessage(2,SUserName,RUserName,date);
            frmSRM.ShowDialog();

        }
    }
}
