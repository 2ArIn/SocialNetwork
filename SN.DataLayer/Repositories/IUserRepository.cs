using SN.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.DataLayer.Repositories
{
    public interface IUserRepository
    {
        List<MyUser> GetAllUsers();
        MyUser GetUserByUserName(string userName);
        bool IsExistUserByUserNameAndPass(string userName, string password);

        UserImageAboutViewModel GetUserNameAndImageAddressAndAbout(string filter = "");

        bool InsertUser(MyUser user);
        bool UpdateUser(MyUser user);
        bool DeleteUser(MyUser user);
        bool DeleteUser(string userName);
        //void Save();
    }
}
