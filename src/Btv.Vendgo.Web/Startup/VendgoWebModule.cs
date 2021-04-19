using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Btv.Vendgo.Configuration;
using Btv.Vendgo.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace Btv.Vendgo.Web.Startup
{
    [DependsOn(
        typeof(VendgoApplicationModule), 
        typeof(VendgoEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class VendgoWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public VendgoWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(VendgoConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<VendgoNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(VendgoApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VendgoWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(VendgoWebModule).Assembly);
        }
    }
}