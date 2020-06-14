using Commerce.DataAccess.Concrete.EntityFramework;
using Commerce.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataAccess.Test.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_test()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList();

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void add_test()
        {
            EfProductDal productDal = new EfProductDal();

            var product = new Product
            {
                CategoryId = 1,
                ProductName = "test2",
                QuantityPerUnit = "15",
                UnitPrice = 87
            };
            var result = productDal.Add(product);

            Assert.AreEqual(2, result.ProductId);
        }


    }
}