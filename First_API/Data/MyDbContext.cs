using Microsoft.EntityFrameworkCore;
namespace First_API.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }

        #region DBset
        public DbSet<Users> Users { get; set; }
        #endregion
    }
}
