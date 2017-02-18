using WolfLairBlog.DataAccessLayer;
using WolfLairBlog.IDataAccessLayer;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data.SqlClient;

namespace WolfLairBlog.DataAccessLayerFactory
{
    /************************************************************************************
         * Copyright (c) 2017  All Rights Reserved.
         * CLR版本： 4.0.30319.42000
         * 机器名称：DESKTOP-C7IEETR
         * 公司名称：南京马普科技有限公司
         * 文件名：  DBSession
         * 版本号：  V1.0.0.0
         * 唯一标识：01b2298c-0833-49d7-8847-35e8a6125b90
         * 当前的用户域：DESKTOP-C7IEETR
         * 创建人：  hexd 贺晓冬
         * 电子邮箱：675556820@qq.com
         * 创建时间：2017/2/14 14:15:04
         * 描述    :
         * =====================================================================
        *************************************************************************************/
    public partial class DBSession : IDBSession
    {
        public DbContext DB
        {
            get { return DbContextFactory.CreateDbContext(); }
        }

        public int ExecuteSQL(string sql, params SqlParameter[] pms)
        {
            return DB.Database.ExecuteSqlCommand(sql, pms);
        }

        public List<T> ExecuteSQL<T>(string sql, params SqlParameter[] pms)
        {
            return DB.Database.SqlQuery<T>(sql, pms).ToList();
        }

        public int SaveChanges()
        {
            return DB.SaveChanges();
        }
    }
}
