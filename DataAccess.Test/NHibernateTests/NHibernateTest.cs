using System;
using System.Reflection;
using Commerce.DataAccess.Concrete.NHibernate;
using Commerce.DataAccess.Concrete.NHibernate.Helpers;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataAccess.Test.NHibernateTests
{
    [TestClass]
    public class NHibernateTest
    {
        [TestMethod]
        public void Get_all_nhibernate_test()
        {
            var tt = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(c => c.FromConnectionStringWithKey("CommerceDbContext")).ShowSql())
                .Mappings(cfg =>
                {
                    cfg.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly());
                    cfg.FluentMappings.Conventions.Add(AutoImport.Never());
                })
                .BuildSessionFactory();

            try
            {
                var t2 = new SqlServerHelper();
            }
            catch (System.Exception ex)
            {

                Console.WriteLine(ex);
            }

            var t = new SqlServerHelper();


            NhProductDal productDal = new NhProductDal(t);

            var result = productDal.GetList();

            Assert.AreEqual(3, result.Count);
        }
    }
}
