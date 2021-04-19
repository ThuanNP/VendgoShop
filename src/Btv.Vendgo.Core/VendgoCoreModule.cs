using Abp.Modules;
using Abp.Reflection.Extensions;
using Btv.Vendgo.Localization;

namespace Btv.Vendgo
{
    public class VendgoCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            VendgoLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VendgoCoreModule).GetAssembly());
        }
    }
}