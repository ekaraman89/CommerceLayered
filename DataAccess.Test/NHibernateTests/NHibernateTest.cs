using Commerce.DataAccess.Concrete.NHibernate;
using Commerce.DataAccess.Concrete.NHibernate.Helpers;
using Commerce.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataAccess.Test.NHibernateTests
{
    [TestClass]
    public class NHibernateTest
    {
        [TestMethod]
        public void Get_all_nhibernate_test()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());

            var result = productDal.GetList();

            Assert.AreEqual(4, result.Count);
             
        }

        [TestMethod]
        public void Add_nhibernate_test()
        {
            var product = new Product
            {
                CategoryId = 1,
                ProductName = "test2",
                QuantityPerUnit = "15",
                UnitPrice = 87
            };
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());

            var result = productDal.Add(product);
            Assert.AreEqual(5, result.ProductId);
        }
    }
}