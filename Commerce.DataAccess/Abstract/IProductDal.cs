using Commerce.Core.DataAccess;
using Commerce.Entities.Concrete;

namespace Commerce.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}