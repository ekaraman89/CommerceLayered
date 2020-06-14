using Commerce.DataAccess.Concrete.EntityFramework.Mappings;
using Commerce.Entities.Concrete;
using System.Data.Entity;

namespace Commerce.DataAccess.Concrete.EntityFramework
{
    public class CommerceDbContext : DbContext
    {
        //public CommerceDbContext() : base()
        //{
        //    Database.SetInitializer<CommerceDbContext>(null);
        //}
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }
    }
}