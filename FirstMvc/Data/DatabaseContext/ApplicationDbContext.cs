using FirstMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstMvc.Data.DatabaseContext
{
    public class ApplicationDbContext: DbContext 
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<City> Cities { get; set; }
    }
}
