using System;
using System.Data.Linq;
using PoolCarManager.Querying;

namespace PoolCarManager.Model
{
    public class PoolCarManagerDataSession : LinqToSqlDataSession<PoolCarManagerDataContext>
    {
        public PoolCarManagerDataSession() 
            : base(new PoolCarManagerDataContext())
        {
        }

        public override void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}