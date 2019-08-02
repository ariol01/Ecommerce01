using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EcommerceMod1.Models
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext() : base("DefaultConnection")
        {

        }

        //DESABILITAR CASCATAS

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        
        public DbSet<EcommerceMod1.Models.Departaments> Departaments { get; set; }

        public System.Data.Entity.DbSet<EcommerceMod1.Models.City> Cities { get; set; }
    }
}