using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.DataLayer.Services
{
    public class LikeRepository
    {
        SocialNetDBEntities db;
        public LikeRepository(SocialNetDBEntities context)
        {
            db = context;
        }
        public int FindLIdByPidAndUserName(int pId,string userName)
        {

            return db.MyLikes.Where(l => l.pid == pId && l.lusername == userName).Select(l=>l.lid).FirstOrDefault();

        }
        public int PostLikeCount(int pid)
        {
            return db.MyLikes.Where(l => l.pid == pid).Count();
        }

        public MyLike FindMyLikeByUserNameAndPId(string userName,int pid)
        {
            return db.MyLikes.Where(l => l.lusername == userName && l.pid == pid).FirstOrDefault();
        }
        public bool InsertToLike(MyLike like)
        {
            try
            {
                db.MyLikes.Add(like);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteFromLike(MyLike like)
        {
            try
            {
                db.MyLikes.Remove(like);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
