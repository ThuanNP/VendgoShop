using Microsoft.EntityFrameworkCore;

namespace Btv.Vendgo.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<VendgoDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for VendgoDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
