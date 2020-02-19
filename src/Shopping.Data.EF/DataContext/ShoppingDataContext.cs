using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using Shopping.Domain.Contract.Extentions;
using Shopping.Domain.Contract.Mapping;
using Shopping.Domain.Entities.Entities;

namespace Shopping.Domain.Contract.DataContext
{
    public class ShoppingDataContext : DbContext
    {
        public ShoppingDataContext() : base(@"Initial Catalog=Shopping;Data Source=.\sqlEXPRESS2014;Integrated Security=true")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
             
            var gooodMap = new GoodMap(modelBuilder.Entity<Good>());

            base.OnModelCreating(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            ChangeTracker.ApplyAuditInformation();

            return await base.SaveChangesAsync(cancellationToken);
        }


        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<FactorDetail> FactorDetails { get; set; }
        public virtual DbSet<Factor> Factors { get; set; }
        public virtual DbSet<Good> Goods { get; set; }



    }
}
