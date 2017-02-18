using WolfLairBlog.Entity.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace WolfLairBlog.DataAccessLayer
{
    /************************************************************************************
         * Copyright (c) 2017  All Rights Reserved.
         * CLR版本： 4.0.30319.42000
         * 机器名称：DESKTOP-C7IEETR
         * 公司名称：南京马普科技有限公司
         * 文件名：  DbContextFactory
         * 版本号：  V1.0.0.0
         * 唯一标识：849c0dc5-85a9-4e8d-8335-2950a6f7e3be
         * 当前的用户域：DESKTOP-C7IEETR
         * 创建人：  hexd 贺晓冬
         * 电子邮箱：675556820@qq.com
         * 创建时间：2017/2/14 14:18:16
         * 描述    :
         * =====================================================================
        *************************************************************************************/
    public class DbContextFactory
    {
        public static DbContext CreateDbContext()
        {
            DbContext db = (DbContext)CallContext.GetData("db");
            if (db == null)
            {
                db = new WolfLairBlogEntities();
                CallContext.SetData("db", db);
            }
            return db;
        }
    }
}
