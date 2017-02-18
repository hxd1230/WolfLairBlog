 
using WolfLairBlog.Entity.DB;
namespace WolfLairBlog.IDataAccessLayer
{
   
	
	public partial interface IArticleDal :IBaseDal<Article>
    {
      
    }
	
	public partial interface ICategoryDal :IBaseDal<Category>
    {
      
    }
	
	public partial interface ICommentDal :IBaseDal<Comment>
    {
      
    }
	
	public partial interface IFriendLinkDal :IBaseDal<FriendLink>
    {
      
    }
	
	public partial interface ILogDal :IBaseDal<Log>
    {
      
    }
	
	public partial interface INLog_ErrorDal :IBaseDal<NLog_Error>
    {
      
    }
	
	public partial interface IUserDal :IBaseDal<User>
    {
      
    }
	
	public partial interface IUserInfoDal :IBaseDal<UserInfo>
    {
      
    }
	
}