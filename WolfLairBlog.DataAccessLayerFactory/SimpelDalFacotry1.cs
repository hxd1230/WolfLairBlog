 

using WolfLairBlog.IDataAccessLayer;
using System.Configuration;
using System.Reflection;

namespace WolfLairBlog.DataAccessLayerFactory
{
    public partial class AbstractFactory
    {
      
   
		
	    public static IArticleDal CreateArticleDal()
        {

            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".ArticleDal";


            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DalAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance( classFulleName,ConfigurationManager.AppSettings["DalAssembly"]);


            return obj as IArticleDal;
        }
		
	    public static ICategoryDal CreateCategoryDal()
        {

            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".CategoryDal";


            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DalAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance( classFulleName,ConfigurationManager.AppSettings["DalAssembly"]);


            return obj as ICategoryDal;
        }
		
	    public static ICommentDal CreateCommentDal()
        {

            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".CommentDal";


            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DalAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance( classFulleName,ConfigurationManager.AppSettings["DalAssembly"]);


            return obj as ICommentDal;
        }
		
	    public static IFriendLinkDal CreateFriendLinkDal()
        {

            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".FriendLinkDal";


            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DalAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance( classFulleName,ConfigurationManager.AppSettings["DalAssembly"]);


            return obj as IFriendLinkDal;
        }
		
	    public static ILogDal CreateLogDal()
        {

            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".LogDal";


            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DalAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance( classFulleName,ConfigurationManager.AppSettings["DalAssembly"]);


            return obj as ILogDal;
        }
		
	    public static INLog_ErrorDal CreateNLog_ErrorDal()
        {

            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".NLog_ErrorDal";


            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DalAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance( classFulleName,ConfigurationManager.AppSettings["DalAssembly"]);


            return obj as INLog_ErrorDal;
        }
		
	    public static IUserDal CreateUserDal()
        {

            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".UserDal";


            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DalAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance( classFulleName,ConfigurationManager.AppSettings["DalAssembly"]);


            return obj as IUserDal;
        }
		
	    public static IUserInfoDal CreateUserInfoDal()
        {

            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".UserInfoDal";


            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DalAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance( classFulleName,ConfigurationManager.AppSettings["DalAssembly"]);


            return obj as IUserInfoDal;
        }
	}
	
}