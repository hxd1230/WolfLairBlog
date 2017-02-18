 
using WolfLairBlog.DataAccessLayer;
using WolfLairBlog.IDataAccessLayer;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace WolfLairBlog.DataAccessLayerFactory
{
	public partial class DBSession : IDBSession
    {
	
		private IArticleDal _ArticleDal;
        public IArticleDal ArticleDal
        {
            get
            {
                if(_ArticleDal == null)
                {
				
                    _ArticleDal =AbstractFactory.CreateArticleDal();
                }
                return _ArticleDal;
            }
            set { _ArticleDal = value; }
        }
	
		private ICategoryDal _CategoryDal;
        public ICategoryDal CategoryDal
        {
            get
            {
                if(_CategoryDal == null)
                {
				
                    _CategoryDal =AbstractFactory.CreateCategoryDal();
                }
                return _CategoryDal;
            }
            set { _CategoryDal = value; }
        }
	
		private ICommentDal _CommentDal;
        public ICommentDal CommentDal
        {
            get
            {
                if(_CommentDal == null)
                {
				
                    _CommentDal =AbstractFactory.CreateCommentDal();
                }
                return _CommentDal;
            }
            set { _CommentDal = value; }
        }
	
		private IFriendLinkDal _FriendLinkDal;
        public IFriendLinkDal FriendLinkDal
        {
            get
            {
                if(_FriendLinkDal == null)
                {
				
                    _FriendLinkDal =AbstractFactory.CreateFriendLinkDal();
                }
                return _FriendLinkDal;
            }
            set { _FriendLinkDal = value; }
        }
	
		private ILogDal _LogDal;
        public ILogDal LogDal
        {
            get
            {
                if(_LogDal == null)
                {
				
                    _LogDal =AbstractFactory.CreateLogDal();
                }
                return _LogDal;
            }
            set { _LogDal = value; }
        }
	
		private INLog_ErrorDal _NLog_ErrorDal;
        public INLog_ErrorDal NLog_ErrorDal
        {
            get
            {
                if(_NLog_ErrorDal == null)
                {
				
                    _NLog_ErrorDal =AbstractFactory.CreateNLog_ErrorDal();
                }
                return _NLog_ErrorDal;
            }
            set { _NLog_ErrorDal = value; }
        }
	
		private IUserDal _UserDal;
        public IUserDal UserDal
        {
            get
            {
                if(_UserDal == null)
                {
				
                    _UserDal =AbstractFactory.CreateUserDal();
                }
                return _UserDal;
            }
            set { _UserDal = value; }
        }
	
		private IUserInfoDal _UserInfoDal;
        public IUserInfoDal UserInfoDal
        {
            get
            {
                if(_UserInfoDal == null)
                {
				
                    _UserInfoDal =AbstractFactory.CreateUserInfoDal();
                }
                return _UserInfoDal;
            }
            set { _UserInfoDal = value; }
        }
	}	
}