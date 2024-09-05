using Microsoft.EntityFrameworkCore;

namespace AspireApp2.ApiService.Data
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SampleData> SampleData { get; set; }
    }
}
