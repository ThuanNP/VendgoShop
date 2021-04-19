using Btv.Vendgo.Configuration;
using Btv.Vendgo.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Btv.Vendgo.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class VendgoDbContextFactory : IDesignTimeDbContextFactory<VendgoDbContext>
    {
        public VendgoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<VendgoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(VendgoConsts.ConnectionStringName)
            );

            return new VendgoDbContext(builder.Options);
        }
    }
}