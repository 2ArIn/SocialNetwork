using SN.DataLayer.Repositories;
using SN.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.DataLayer.Services
{
    public class UserRepository : IUserRepository
    {
        private SocialNetDBEntities db;
        public UserRepository(SocialNetDBEntities context)
        {
            db = context;
        }

        public bool DeleteUser(MyUser user)
        {
            try
            {
                db.Entry(user).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteUser(string userName)
        {
            try
            {
                var user = GetUserByUserName(userName);
                DeleteUser(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<MyUser> GetAllUsers()
        {
            return db.MyUsers.ToList();
        }
        public MyUser GetUserByUserName(string userName)
        {
            return db.MyUsers.Find(userName);
        }
        public bool IsExistUserByUserNameAndPass(string userName,string password)
        {
            return db.MyUsers.Any(c => c.username == userName && c.password==password);
        }
        public bool InsertUser(MyUser user)
        {
            try
            {
                var res = GetUserByUserName(user.username);
                if (res != null)
                    return false;
                db.MyUsers.Add(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //public void Save()
        //{
        //    db.SaveChanges();
        //}

        public bool UpdateUser(MyUser user)
        {
            try
            {
                db.Entry(user).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public UserImageAboutViewModel GetUserNameAndImageAddressAndAbout(string filter = "")
        {
                return db.MyUsers.Select(u => new UserImageAboutViewModel()
                {
                    UserName = u.username,
                    UImage = u.uimage,
                    About = u.about
                }).Where(u => u.UserName.Contains(filter)).FirstOrDefault();
        }
    }
}
