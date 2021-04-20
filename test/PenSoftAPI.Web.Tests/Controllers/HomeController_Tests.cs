using System.Threading.Tasks;
using PenSoftAPI.Models.TokenAuth;
using PenSoftAPI.Web.Controllers;
using Shouldly;
using Xunit;

namespace PenSoftAPI.Web.Tests.Controllers
{
    public class HomeController_Tests: PenSoftAPIWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}