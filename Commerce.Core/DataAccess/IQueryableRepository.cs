using System.Linq;
using Commerce.Core.Entities;

namespace Commerce.Core.DataAccess
{
    internal interface IQueryableRepository<T> where T : class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}