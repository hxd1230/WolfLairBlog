using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfLairBlog.IDataAccessLayer
{
    public partial interface IDBSession
    {
        DbContext DB { get; }
        int ExecuteSQL(string sql, params SqlParameter[] pms);
         List<T> ExecuteSQL<T>(string sql, params SqlParameter[] pms);

         int SaveChanges();
    }
}
