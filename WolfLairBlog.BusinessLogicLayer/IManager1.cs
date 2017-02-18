 

using WolfLairBlog.Entity.DB;
using WolfLairBlog.IBusinessLogicLayer;

namespace WolfLairBlog.BusinessLogicLayer
{
	
	public partial class ArticleService :BaseService<Article>,IArticleService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = this.DBSession.ArticleDal;
        }
    }   
	
	public partial class CategoryService :BaseService<Category>,ICategoryService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = this.DBSession.CategoryDal;
        }
    }   
	
	public partial class CommentService :BaseService<Comment>,ICommentService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = this.DBSession.CommentDal;
        }
    }   
	
	public partial class FriendLinkService :BaseService<FriendLink>,IFriendLinkService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = this.DBSession.FriendLinkDal;
        }
    }   
	
	public partial class LogService :BaseService<Log>,ILogService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = this.DBSession.LogDal;
        }
    }   
	
	public partial class NLog_ErrorService :BaseService<NLog_Error>,INLog_ErrorService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = this.DBSession.NLog_ErrorDal;
        }
    }   
	
	public partial class UserService :BaseService<User>,IUserService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = this.DBSession.UserDal;
        }
    }   
	
	public partial class UserInfoService :BaseService<UserInfo>,IUserInfoService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = this.DBSession.UserInfoDal;
        }
    }   
	
}