using System;
using System.Data.Linq;
using PoolCarManager.Core;

namespace PoolCarManager.Model
{
    public abstract class LinqToSqlDataSession<TDataContext> : IDataSession
        where TDataContext : DataContext
    {
        protected readonly TDataContext _dataContext;

        protected LinqToSqlDataSession(TDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IRepository<T> RepositoryFor<T>() 
            where T : class, IIdentifiable
        {
            return new LinqToSqlRepository<T>(_dataContext);
        }

        public void SaveChanges()
        {
            _dataContext.SubmitChanges();
        }

        public abstract void Dispose();
    }
}