using Commerce.Core.DataAccess.NHibernate;
using Commerce.DataAccess.Abstract;
using Commerce.Entities.Concrete;

namespace Commerce.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : NhEntityRepositoryBase<Product>, IProductDal
    {
        public NhProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }
    }
}