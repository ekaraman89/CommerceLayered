using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commerce.Core.DataAccess;
using Commerce.Entities.Concreate;

namespace Commerce.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
