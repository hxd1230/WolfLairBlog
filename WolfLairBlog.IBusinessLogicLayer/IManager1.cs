 

using WolfLairBlog.Entity.DB;

namespace WolfLairBlog.IBusinessLogicLayer
{
	
	public partial interface IArticleService : IBaseService<Article>
    {
       
    }   
	
	public partial interface ICategoryService : IBaseService<Category>
    {
       
    }   
	
	public partial interface ICommentService : IBaseService<Comment>
    {
       
    }   
	
	public partial interface IFriendLinkService : IBaseService<FriendLink>
    {
       
    }   
	
	public partial interface ILogService : IBaseService<Log>
    {
       
    }   
	
	public partial interface INLog_ErrorService : IBaseService<NLog_Error>
    {
       
    }   
	
	public partial interface IUserService : IBaseService<User>
    {
       
    }   
	
	public partial interface IUserInfoService : IBaseService<UserInfo>
    {
       
    }   
	
}