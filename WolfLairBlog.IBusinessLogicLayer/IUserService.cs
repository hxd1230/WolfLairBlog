using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolfLairBlog.Common;
using WolfLairBlog.Entity.DB;

namespace WolfLairBlog.IBusinessLogicLayer
{
    public partial interface IUserService : IBaseService<User>
    {
        bool Login(string userName, string passWord, out PublicStruct<User, string> outInfo);
        bool AddEntity(User user, out string msg);
    }
}
