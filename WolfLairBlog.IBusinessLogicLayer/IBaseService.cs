using WolfLairBlog.IDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WolfLairBlog.IBusinessLogicLayer
{
    /************************************************************************************
         * Copyright (c) 2017  All Rights Reserved.
         * CLR版本： 4.0.30319.42000
         * 机器名称：DESKTOP-C7IEETR
         * 公司名称：南京马普科技有限公司
         * 文件名：  BaseService
         * 版本号：  V1.0.0.0
         * 唯一标识：9663dc14-9240-4876-a7a2-02c327c027a4
         * 当前的用户域：DESKTOP-C7IEETR
         * 创建人：  hexd 贺晓冬
         * 电子邮箱：675556820@qq.com
         * 创建时间：2017/2/14 12:01:50
         * 描述    :
         * =====================================================================
        *************************************************************************************/
    public interface IBaseService<T> where T : class,new()
    {
        IBaseDal<T> CurrentDal { get; set; }
         IQueryable<T> Select(Expression<Func<T, bool>> whereLambda);
         IQueryable<T> Select<s>(int pageIndex, int pageSize, out int totalCount, Expression<Func<T, bool>> whereLambda, Expression<Func<T, s>> orderByLambda, bool isAsc);
         IQueryable<T> Select<s>(int pageIndex, int pageSize, Expression<Func<T, bool>> whereLambda, Expression<Func<T, s>> orderByLambda, bool isAsc);
         bool UpdateEntity(T entity);
         bool DeleteEntity(T entity);
         T AddEntity(T entity);
    }
}
