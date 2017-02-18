 
using WolfLairBlog.IDataAccessLayer;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace WolfLairBlog.IDataAccessLayer
{
	public partial interface IDBSession
    {

	
		IArticleDal ArticleDal{get;set;}
	
		ICategoryDal CategoryDal{get;set;}
	
		ICommentDal CommentDal{get;set;}
	
		IFriendLinkDal FriendLinkDal{get;set;}
	
		ILogDal LogDal{get;set;}
	
		INLog_ErrorDal NLog_ErrorDal{get;set;}
	
		IUserDal UserDal{get;set;}
	
		IUserInfoDal UserInfoDal{get;set;}
	}	
}