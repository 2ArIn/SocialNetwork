using SN.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SN.DataLayer.Services
{
    public class PostRepository : IPostRepository
    {
        private SocialNetDBEntities db;

        public PostRepository(SocialNetDBEntities context)
        {
            db = context;
        }
        public bool DeletePost(int pid)
        {
            try
            {
                var post = GetPostById(pid);
                DeletePost(post);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletePost(string userName)
        {
            try
            {
                var posts = GetPostsByUserName(userName);
                db.Posts.RemoveRange(posts);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletePost(Post post)
        {
            try
            {
                db.Entry(post).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Post> GetAllPost()
        {
            return db.Posts.ToList();
        }

        public Post GetPostById(int pId)
        {
            return db.Posts.Find(pId);
        }

        public List<Post> GetPostsByUserName(string userName)
        {
            return db.Posts.Where(c=> c.pusername == userName).ToList();
        }

        public bool InsertPost(Post post)
        {
            try
            {
                db.Posts.Add(post);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdatePost(Post post)
        {
            try
            {
                db.Entry(post).State = EntityState.Modified;
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
    }
}
