using WolfLairBlog.DataAccessLayerFactory;
using WolfLairBlog.IDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WolfLairBlog.BusinessLogicLayer
{
    /************************************************************************************
         * Copyright (c) 2017  All Rights Reserved.
         * CLR版本： 4.0.30319.42000
         * 机器名称：DESKTOP-C7IEETR
         * 公司名称：南京马普科技有限公司
         * 文件名：  BaseService
         * 版本号：  V1.0.0.0
         * 唯一标识：e5e2df3e-9149-4110-9373-3f5e39bf466a
         * 当前的用户域：DESKTOP-C7IEETR
         * 创建人：  hexd 贺晓冬
         * 电子邮箱：675556820@qq.com
         * 创建时间：2017/2/14 12:14:23
         * 描述    :
         * =====================================================================
        *************************************************************************************/
    public abstract class BaseService<T> where T : class,new()
    {
        public IDBSession DBSession
        {
            get
            {
                return DBSessionFactory.CreateDbSession();
            }
        }
        public abstract void SetCurrentDal();
        public IBaseDal<T> CurrentDal { get; set; }
        public BaseService()
        {
            SetCurrentDal();
        }
        public IQueryable<T> Select(Expression<Func<T, bool>> whereLambda)
        {
            return CurrentDal.Select(whereLambda);
        }
        public IQueryable<T> Select<s>(int pageIndex, int pageSize, out int totalCount, Expression<Func<T, bool>> whereLambda, Expression<Func<T, s>> orderByLambda, bool isAsc)
        {
            return CurrentDal.Select<s>(pageIndex, pageSize, out totalCount, whereLambda, orderByLambda, isAsc);
        }
        public IQueryable<T> Select<s>(int pageIndex, int pageSize, Expression<Func<T, bool>> whereLambda, Expression<Func<T, s>> orderByLambda, bool isAsc)
        {
            return CurrentDal.Select<s>(pageIndex, pageSize, whereLambda, orderByLambda, isAsc);
        }
        public bool UpdateEntity(T entity)
        {
            CurrentDal.UpdateEntity(entity);
            return DBSession.SaveChanges() > 0;
        }
        public bool DeleteEntity(T entity)
        {
            CurrentDal.DeleteEntity(entity);
            return DBSession.SaveChanges() > 0;
        }
        public T AddEntity(T entity)
        {
            CurrentDal.AddEntity(entity);
            DBSession.SaveChanges();
            return entity;
        }
    }
}
