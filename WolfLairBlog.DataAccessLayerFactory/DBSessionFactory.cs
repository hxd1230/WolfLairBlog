using WolfLairBlog.IDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace WolfLairBlog.DataAccessLayerFactory
{
    /************************************************************************************
         * Copyright (c) 2017  All Rights Reserved.
         * CLR版本： 4.0.30319.42000
         * 机器名称：DESKTOP-C7IEETR
         * 公司名称：南京马普科技有限公司
         * 文件名：  DBSessionFactory
         * 版本号：  V1.0.0.0
         * 唯一标识：161291e0-2128-489e-ab9b-09280eb9b93f
         * 当前的用户域：DESKTOP-C7IEETR
         * 创建人：  hexd 贺晓冬
         * 电子邮箱：675556820@qq.com
         * 创建时间：2017/2/14 15:13:48
         * 描述    :
         * =====================================================================
        *************************************************************************************/
   public class DBSessionFactory
    {
       public static IDBSession CreateDbSession()
       {
           IDBSession DbSession = (IDBSession)CallContext.GetData("dbSession");
           if (DbSession == null)
           {
               DbSession = new DBSession();
               CallContext.SetData("dbSession", DbSession);
           }
           return DbSession;
       }
    }
}
