using SN.Utility.Convertor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.DataLayer.Services
{
    public class MessageRepository
    {
        SocialNetDBEntities db;
        public MessageRepository(SocialNetDBEntities context)
        {
            db = context;
        }

        public Message FindMessageBySRUserNameAndDate(string mUserName,string userName,string mDate)
        {
            return db.Messages.Where(m => m.musername == mUserName && m.username == userName && m.mdate == mDate).FirstOrDefault();

        }
        public bool InsertToMessage(string sUserName,string rUserName,string text)
        {
            try
            {
                Message msg = new Message();
                msg.mdate = DateTime.Now.MiladiToShamsi();
                msg.musername = sUserName;
                msg.username = rUserName;
                msg.mtext = text;

                db.Messages.Add(msg);
                return true;

            }
            catch
            {
                return false;
            }

        }
        public bool DeleteFromMessage(string sUserName, string rUserName, string text)
        {
            try
            {
                Message msg = new Message();
                msg.mdate = DateTime.Now.MiladiToShamsi();
                msg.musername = sUserName;
                msg.username = rUserName;
                msg.mtext = text;
                db.Messages.Remove(msg);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Message> GetRMessagesByUserName(string rUserName)
        {
            return db.Messages.Where(m => m.username == rUserName).OrderByDescending(m => m.mdate).ToList();
        }
        public List<Message> GetSMessageByUserName(string sUserName)
        {
            return db.Messages.Where(m => m.musername == sUserName).OrderByDescending(m => m.mdate).ToList();
        }

    }
}
