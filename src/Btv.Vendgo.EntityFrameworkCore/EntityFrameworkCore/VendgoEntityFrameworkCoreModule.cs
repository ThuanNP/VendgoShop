using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Btv.Vendgo.EntityFrameworkCore
{
    [DependsOn(
        typeof(VendgoCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class VendgoEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VendgoEntityFrameworkCoreModule).GetAssembly());
        }
    }
}