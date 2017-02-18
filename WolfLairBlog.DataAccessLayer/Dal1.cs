 

using WolfLairBlog.Entity.DB;
using WolfLairBlog.IDataAccessLayer;

namespace WolfLairBlog.DataAccessLayer
{
		
	public partial class ArticleDal :BaseDal<Article>,IArticleDal
    {

    }
		
	public partial class CategoryDal :BaseDal<Category>,ICategoryDal
    {

    }
		
	public partial class CommentDal :BaseDal<Comment>,ICommentDal
    {

    }
		
	public partial class FriendLinkDal :BaseDal<FriendLink>,IFriendLinkDal
    {

    }
		
	public partial class LogDal :BaseDal<Log>,ILogDal
    {

    }
		
	public partial class NLog_ErrorDal :BaseDal<NLog_Error>,INLog_ErrorDal
    {

    }
		
	public partial class UserDal :BaseDal<User>,IUserDal
    {

    }
		
	public partial class UserInfoDal :BaseDal<UserInfo>,IUserInfoDal
    {

    }
	
}