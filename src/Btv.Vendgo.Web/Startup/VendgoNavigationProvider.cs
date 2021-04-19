using Abp.Application.Navigation;
using Abp.Localization;
using JetBrains.Annotations;

namespace Btv.Vendgo.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    [UsedImplicitly]
    public class VendgoNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "fa fa-home"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("About"),
                        url: "Home/About",
                        icon: "fa fa-info"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("Product"),
                        url: "",
                        icon: "fa fa-info"
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("Service"),
                        url: "",
                        icon: "fa fa-info"
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("Blog"),
                        url: "",
                        icon: "fa fa-info"
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, VendgoConsts.LocalizationSourceName);
        }
    }
}
