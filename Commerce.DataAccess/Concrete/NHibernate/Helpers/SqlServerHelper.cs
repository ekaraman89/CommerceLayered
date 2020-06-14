using Commerce.Core.DataAccess.NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System.Reflection;

namespace Commerce.DataAccess.Concrete.NHibernate.Helpers
{
    public class SqlServerHelper : NHibernateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            var result = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(c => c.FromConnectionStringWithKey("CommerceDbContext")).ShowSql())
                .Mappings(cfg =>
                {
                    cfg.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly());
                })
                .BuildSessionFactory();
            return result;
        }
    }
}