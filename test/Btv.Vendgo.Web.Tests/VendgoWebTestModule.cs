using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Btv.Vendgo.Web.Startup;
namespace Btv.Vendgo.Web.Tests
{
    [DependsOn(
        typeof(VendgoWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class VendgoWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VendgoWebTestModule).GetAssembly());
        }
    }
}