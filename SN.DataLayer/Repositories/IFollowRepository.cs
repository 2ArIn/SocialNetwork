using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.DataLayer.Repositories
{
    public interface IFollowRepository
    {
        List<MyFollow> GetAllFollowersByUserName(string userName);
        List<MyFollow> GetAllFollwingByUserName(string userName);

        MyFollow FindFollowByErIngUserName(string erUserName, string ingUserName);

        MyFollow FindByFid(int fid);
        int FindFid(string erUserName,string ingUserName);
        bool DeleteFromFollow(MyFollow follow);
        bool DeleteById(int fid);
        bool InsertToFollow(MyFollow follow);
        

    }
}
