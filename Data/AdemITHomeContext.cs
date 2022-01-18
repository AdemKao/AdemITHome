using Microsoft.EntityFrameworkCore;

namespace AdemITHome.Data
{
    public class AdemITHomeContext : DbContext
    {
        public AdemITHomeContext(DbContextOptions<AdemITHomeContext> options)
        : base(options)
        {
        }

        public DbSet<AdemITHome.Models.Article> Article { get; set; }
    }
}