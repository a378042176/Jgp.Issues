using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Jgp.Issues.EntityFramework.Repositories
{
    public abstract class IssuesRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<IssuesDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected IssuesRepositoryBase(IDbContextProvider<IssuesDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class IssuesRepositoryBase<TEntity> : IssuesRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected IssuesRepositoryBase(IDbContextProvider<IssuesDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
