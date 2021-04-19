using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Btv.Vendgo
{
    [DependsOn(
        typeof(VendgoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class VendgoApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VendgoApplicationModule).GetAssembly());
        }
    }
}