using System.Data.Entity;

namespace EcommerceMod1.Models
{
    public class EcommerceContext:DbContext
    {
        public EcommerceContext():base("DefaultConnection")
        {
            
        }

        public DbSet<EcommerceMod1.Models.Departaments> Departaments { get; set; }
    }
}