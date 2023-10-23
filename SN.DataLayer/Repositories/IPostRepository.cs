using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.DataLayer.Repositories
{
    public interface IPostRepository
    {
        List<Post> GetAllPost();
        Post GetPostById(int pId);
        List<Post> GetPostsByUserName(string userName);
        bool InsertPost(Post post);
        bool UpdatePost(Post post);
        bool DeletePost(int pid);
        bool DeletePost(string userName);
        bool DeletePost(Post post);
        //void Save();

    }
}
