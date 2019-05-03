using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> Table { get; }
        IQueryable<T> TableNoTracking { get; }
        T GetById(object id);
        IQueryable<T> GetList(int count);
        T Insert(T entity);
        void Insert(IEnumerable<T> entities);
        T Update(T entity);
        void Delete(T entity);
        void DeleteById(int id);
        void Delete(IEnumerable<T> entities);
        IQueryable<T> IncludeMany(params Expression<Func<T, object>>[] includes);
    }
}
