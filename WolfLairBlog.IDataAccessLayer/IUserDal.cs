using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolfLairBlog.Entity.DB;

namespace WolfLairBlog.IDataAccessLayer
{
    public partial interface IUserDal : IBaseDal<User>
    {
        //bool Login(string userName, string passWord, out Tuple<User, string> outInfo);
    }
}
