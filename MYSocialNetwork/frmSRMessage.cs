using SN.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SN.DataLayer;
using System.Windows.Forms;

namespace MYSocialNetwork
{
    public partial class frmSRMessage : Form
    {
        private string SUserName;
        private string RUserName;
        private int Type;
        private string Date;
        private UnitOfWork db;
        public frmSRMessage(int type,string sUserName,string rUserName,string date)
        {
            InitializeComponent();
            
            Type = type;
            SUserName = sUserName;
            RUserName = rUserName;
            Date = date;
            db = new UnitOfWork();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(Type == 1)
            {
                this.Hide();
            }
            else if(Type ==2)
            {
                //SN.DataLayer.Message msg = new SN.DataLayer.Message();
                //msg = db.MessageRepository.FindMessageBySRUserNameAndDate();
                //if (db.MessageRepository.DeleteFromMessage(SUserName, RUserName, Date))
                //    RtlMessageBox.Show("پیام با موفقیت حذف شد");

            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            using(UnitOfWork db = new UnitOfWork())
            {
                if(db.MessageRepository.InsertToMessage(frmLogin.UN, SUserName, txtText.Text))
                {
                    RtlMessageBox.Show(" پیام با موفقیت ارسال شد", "موفقیت",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    db.Save();
                    this.Hide();
                }
                else
                {
                    RtlMessageBox.Show(" ارسال پیام با خطا مواجه شد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }

        private void frmMessage_Load(object sender, EventArgs e)
        {
            if(Type == 1)
            {
                txtTo.Text = SUserName;
                lblToFrom.Text = "به ";
            }
            else if(Type == 2)
            {
                SN.DataLayer.Message msg = new SN.DataLayer.Message();
                using(UnitOfWork db = new UnitOfWork())
                {
                    txtTo.Text =  SUserName;
                    MessageBox.Show(SUserName+" "+RUserName+" "+Date);
                    msg = db.MessageRepository.FindMessageBySRUserNameAndDate(SUserName, RUserName, Date);
                    txtText.Text = msg.mtext;
                    lblToFrom.Text = "از ";
                    btnCancelDelete.Text = "حذف کردن";
                    btnSendMessage.Visible = false;
                }
            }
        }
    }
}
