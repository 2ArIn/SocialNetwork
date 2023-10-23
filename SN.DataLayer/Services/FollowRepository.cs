using SN.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.DataLayer.Services
{
    public class FollowRepository : IFollowRepository
    {
        private SocialNetDBEntities db;
        public FollowRepository(SocialNetDBEntities context)
        {
            db = context;
        }
        public List<MyFollow> GetAllFollowersByUserName(string userName)
        {
            return db.MyFollows.Where(f => f.followingusername == userName).ToList();
;        }

        public List<MyFollow> GetAllFollwingByUserName(string userName)
        {
            return db.MyFollows.Where(f => f.followerusername == userName).ToList();
        }
        //public MyFollow FindFollowByErIngUserName(string erUserName,string ingUserName)
        //{
            
        //}
        public MyFollow FindByFid(int fid)
        {
            MyFollow follow = db.MyFollows.Where(f => f.fid == fid).FirstOrDefault();
            return follow;
        }
        public int FindFid(string erUserName,string ingUserName)
        {
           return db.MyFollows.Where(c => c.followerusername == erUserName && c.followingusername == ingUserName).Select(c => c.fid).FirstOrDefault();
        }
        public bool DeleteFromFollow(MyFollow follow)
        {
            try
            {
                db.Entry(follow).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
            //db.MyFollows.Remove(follow);
            
        }
        public bool DeleteById(int fid)
        {
            MyFollow follow = FindByFid(fid);
            if (DeleteFromFollow(follow))
                return true;
            else
                return false;
        }
        public bool InsertToFollow(MyFollow follow)
        {
            try
            {
                db.MyFollows.Add(follow);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public MyFollow FindFollowByErIngUserName(string erUserName, string ingUserName)
        {
            //var query = from row in db.MyFollows
            //            where row.followerusername == erUserName && row.followingusername == ingUserName
            //            select new
            //            {
            //                row.fid
            //            };
            //return query.FirstOrDefault();
            return db.MyFollows.Where(f => f.followerusername == erUserName && f.followingusername == ingUserName).First();
        }

    }
}
