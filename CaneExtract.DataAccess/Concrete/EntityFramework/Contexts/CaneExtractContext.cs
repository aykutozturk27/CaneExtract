using CaneExtract.Core.Utilities.Configuration;
using CaneExtract.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CaneExtract.DataAccess.Concrete.EntityFramework.Contexts
{
    public class CaneExtractContext : DbContext
    {
        public DbSet<STI> STIs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CoreConfig.GetConnectionString("Default"));
        }
    }
}
