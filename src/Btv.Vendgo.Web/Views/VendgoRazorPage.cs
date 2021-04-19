using Abp.AspNetCore.Mvc.Views;

namespace Btv.Vendgo.Web.Views
{
    public abstract class VendgoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected VendgoRazorPage()
        {
            LocalizationSourceName = VendgoConsts.LocalizationSourceName;
        }
    }
}
