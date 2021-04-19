using System.Threading.Tasks;
using Btv.Vendgo.Web.Controllers;
using Shouldly;
using Xunit;

namespace Btv.Vendgo.Web.Tests.Controllers
{
    public class HomeController_Tests: VendgoWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
