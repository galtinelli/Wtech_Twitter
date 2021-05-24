using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Twitter.Core.Entities;

namespace Twitter.Core.Service
{
    public interface ICoreService<T> where T : CoreEntity
    {
        bool Add(T item);
        bool Add(List<T> items);
        bool Update(T item);
        bool Remove(T item);
        bool Remove(int id);
        bool Removeall(Expression<Func<T, bool>> exp);
        T GetById(int id);
        T GetByDefault(Expression<Func<T, bool>> exp);
        List<T> GetActive();
        List<T> GetDefault(Expression<Func<T, bool>> exp);
        List<T> GetAll();
        bool Activate(int id);
        bool Any(Expression<Func<T, bool>> exp);
        int Save();


    }
}
