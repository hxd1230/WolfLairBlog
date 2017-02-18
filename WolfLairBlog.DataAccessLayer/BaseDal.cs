using WolfLairBlog.Entity.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace WolfLairBlog.DataAccessLayer
{
    /************************************************************************************
         * Copyright (c) 2017  All Rights Reserved.
         * CLR版本： 4.0.30319.42000
         * 机器名称：DESKTOP-C7IEETR
         * 公司名称：南京马普科技有限公司
         * 文件名：  BaseDAL
         * 版本号：  V1.0.0.0
         * 唯一标识：1df2e57f-0971-402c-bfb0-331cc91233a7
         * 当前的用户域：DESKTOP-C7IEETR
         * 创建人：  hexd 贺晓冬
         * 电子邮箱：675556820@qq.com
         * 创建时间：2017/2/14 11:50:28
         * 描述    :
         * =====================================================================
        *************************************************************************************/
    public class BaseDal<T> where T : class,new()
    {
        DbContext db = DbContextFactory.CreateDbContext();
        public IQueryable<T> Select(Expression<Func<T, bool>> whereLambda)
        {
            return db.Set<T>().Where<T>(whereLambda);
        }
        public IQueryable<T> Select<s>(int pageIndex, int pageSize, out int totalCount, Expression<Func<T, bool>> whereLambda, Expression<Func<T, s>> orderByLambda, bool isAsc)
        {
            var temp = db.Set<T>().Where<T>(whereLambda);
            totalCount = temp.Count();
            if (isAsc)
            {
                temp = temp.OrderBy<T, s>(orderByLambda).Skip<T>((pageIndex - 1) * pageSize).Take<T>(pageSize);
            }
            else
            {
                temp = temp.OrderByDescending<T, s>(orderByLambda).Skip<T>((pageIndex - 1) * pageSize).Take<T>(pageSize);
            }
            return temp;
        }
        public IQueryable<T> Select<s>(int pageIndex, int pageSize, Expression<Func<T, bool>> whereLambda, Expression<Func<T, s>> orderByLambda, bool isAsc)
        {
            var temp = db.Set<T>().Where<T>(whereLambda);
            if (isAsc)
            {
                temp = temp.OrderBy<T, s>(orderByLambda).Skip<T>((pageIndex - 1) * pageSize).Take<T>(pageSize);
            }
            else
            {
                temp = temp.OrderByDescending<T, s>(orderByLambda).Skip<T>((pageIndex - 1) * pageSize).Take<T>(pageSize);
            }
            return temp;
        }
        public bool UpdateEntity(T entity)
        {
            db.Entry<T>(entity).State = EntityState.Modified;
            return true;
        }
        public bool DeleteEntity(T entity)
        {
            db.Entry<T>(entity).State = EntityState.Deleted;
            return true;
        }
        public T AddEntity(T entity)
        {
            db.Set<T>().Add(entity);
            return entity;
        }
    }
}
