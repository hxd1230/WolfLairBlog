using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolfLairBlog.Common;
using WolfLairBlog.Entity.DB;

namespace WolfLairBlog.BusinessLogicLayer
{
    public partial class UserService : BaseService<User>
    {
        public bool AddEntity(User user, out string msg)
        {
            if (CheckUserName(user.UserName))
            {
                msg = "用户名已存在";
                return false;
            }
            else
            {
                this.DBSession.UserDal.AddEntity(user);
                this.DBSession.SaveChanges();
                msg = "注册成功";
                return true;
            }
        }
        private bool CheckUserName(string userName)
        {
            return this.DBSession.UserDal.Select(c => c.UserName.Equals(userName)).Count() > 0;
        }
        public bool Login(string userName, string passWord, out PublicStruct<User, string> outInfo)
        {
            outInfo = new PublicStruct<User, string>();
            outInfo.Class = this.DBSession.UserDal.Select(c => c.UserName.Equals(userName)).FirstOrDefault();
            if (outInfo.Class != null)
            {
                if (outInfo.Class.UserPwd.Equals(FuncUtility.Encrypt(passWord)))
                {
                    outInfo.String = "success login";
                    return true;
                }
                else
                {
                    outInfo.String = "username or password error";
                    return false;
                }
            }
            else
            {
                outInfo.String = "username not exists";
                return false;
            }
        }
    }
}
