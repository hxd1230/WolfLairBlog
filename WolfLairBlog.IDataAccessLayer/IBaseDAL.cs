using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WolfLairBlog.IDataAccessLayer
{
    public interface IBaseDal<T> where T : class,new()
    {
        IQueryable<T> Select(Expression<Func<T, bool>> whereLambda);
        IQueryable<T> Select<s>(int pageIndex, int pageSize, out int totalCount, Expression<Func<T, bool>> whereLambda, Expression<Func<T, s>> orderByLambda, bool isAsc);
        IQueryable<T> Select<s>(int pageIndex, int pageSize, Expression<Func<T, bool>> whereLambda, Expression<Func<T, s>> orderByLambda, bool isAsc);
        bool UpdateEntity(T entity);
        bool DeleteEntity(T entity);
        T AddEntity(T entity);
    }
}
