using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Commerce.Core.DataAccess.EntityFramework;
using Commerce.DataAccess.Abstract;
using Commerce.Entities.Concrete;

namespace Commerce.DataAccess.Concrete.EntityFramework
{
   public class EfProductDal : EfEntityRepositoryBase<Product,CommerceDbContext>, IProductDal
    {

    }
}
