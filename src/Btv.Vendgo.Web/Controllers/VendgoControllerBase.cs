using Abp.AspNetCore.Mvc.Controllers;

namespace Btv.Vendgo.Web.Controllers
{
    public abstract class VendgoControllerBase: AbpController
    {
        protected VendgoControllerBase()
        {
            LocalizationSourceName = VendgoConsts.LocalizationSourceName;
        }
    }
}