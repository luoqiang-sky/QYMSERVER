using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace QYMSERVER.EntityFramework.Repositories
{
    public abstract class QYMSERVERRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<QYMSERVERDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected QYMSERVERRepositoryBase(IDbContextProvider<QYMSERVERDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class QYMSERVERRepositoryBase<TEntity> : QYMSERVERRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected QYMSERVERRepositoryBase(IDbContextProvider<QYMSERVERDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
