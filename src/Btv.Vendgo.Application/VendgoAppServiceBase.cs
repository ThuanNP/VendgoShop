using Abp.Application.Services;

namespace Btv.Vendgo
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class VendgoAppServiceBase : ApplicationService
    {
        protected VendgoAppServiceBase()
        {
            LocalizationSourceName = VendgoConsts.LocalizationSourceName;
        }
    }
}