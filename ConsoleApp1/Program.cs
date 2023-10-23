using SN.DataLayer;
using SN.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork db = new UnitOfWork();
            MyUser user = new MyUser()
            {
                username = "Moin",
                password = "123",
                mobile = "",
                uimage = "No Photo"
            };
            db.UserRepository.InsertUser(user);
            //db.UserRepository.Save();
            var list = db.UserRepository.GetAllUsers();
            
            db.Dispose();

        }
    }
}
