using Microsoft.EntityFrameworkCore;
using ODataHelper.AspNet.Abstractions;

namespace ODataHelper.AspNet.EntityFrameworkCore
{
    public interface IEfCoreODataRepositoryAdapter<out TDbContext, TEntity> : IODataHelperRepositoryAdapter<TEntity>
        where TDbContext : DbContext
        where TEntity : class
    {
        TDbContext Context { get; }
    }
}
