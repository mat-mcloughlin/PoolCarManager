using System;
using System.Collections.Generic;

namespace PoolCarManager.Model
{
    public interface IRepository<T>
    {
        T Get(int id);
        void Add(T item);
        IEnumerable<T> GetAll(Func<T, bool> predicate);
    }
}