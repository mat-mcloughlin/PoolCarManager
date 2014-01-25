using System;
using PoolCarManager.Core;

namespace PoolCarManager.Model
{
    public interface IDataSession : IDisposable
    {
        IRepository<T> RepositoryFor<T>()
            where T : class, IIdentifiable;

        void SaveChanges();
    }
}