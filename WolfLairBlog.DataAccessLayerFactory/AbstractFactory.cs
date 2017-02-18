using WolfLairBlog.IDataAccessLayer;
using System.Configuration;
using System.Reflection;

namespace WolfLairBlog.DataAccessLayerFactory
{
    /************************************************************************************
         * Copyright (c) 2017  All Rights Reserved.
         * CLR版本： 4.0.30319.42000
         * 机器名称：DESKTOP-C7IEETR
         * 公司名称：南京马普科技有限公司
         * 文件名：  AbstractFactory
         * 版本号：  V1.0.0.0
         * 唯一标识：57dec249-2ce4-4e99-a172-351c4fb87c63
         * 当前的用户域：DESKTOP-C7IEETR
         * 创建人：  hexd 贺晓冬
         * 电子邮箱：675556820@qq.com
         * 创建时间：2017/2/14 15:21:14
         * 描述    :
         * =====================================================================
        *************************************************************************************/
    public partial class AbstractFactory
    {
        private static readonly string DalAssembly = ConfigurationManager.AppSettings["DalAssembly"];
        private static readonly string NameSpace = ConfigurationManager.AppSettings["NameSpace"];
        //public static IUserDal CreateUserInfoDAL()
        //{
        //    string fullClassName = NameSpace + ".UserInfoDal";
        //    return CreateInstance(fullClassName, DalAssembly) as IUserDal;
        //}
        public static object CreateInstance(string className, string assemblyName)
        {
            var assembly = Assembly.Load(assemblyName);
            return assembly.CreateInstance(className);
        }
    }
}
