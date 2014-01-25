using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using PoolCarManager.Core;

namespace PoolCarManager.Model
{
    public class LinqToSqlRepository<T> : IRepository<T>
        where T : class, IIdentifiable
    {
        private readonly DataContext _dataContext;

        public LinqToSqlRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public T Get(int id)
        {
            // Must leave this cast in here, even though Resharper suggests to remove it
            return _dataContext.GetTable<T>().Single(item => ((T)item).Id == id);
        }

        public void Add(T item)
        {
            _dataContext.GetTable<T>().InsertOnSubmit(item);
        }

        public IEnumerable<T> GetAll(Func<T, bool> predicate)
        {
            return _dataContext.GetTable<T>().Where(predicate).ToList();
        }
    }
}