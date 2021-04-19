using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Btv.Vendgo.EntityFrameworkCore
{
    public class VendgoDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public VendgoDbContext(DbContextOptions<VendgoDbContext> options) 
            : base(options)
        {

        }
    }
}
