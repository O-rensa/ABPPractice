using System.Threading.Tasks;
using Employee.Models.TokenAuth;
using Employee.Web.Controllers;
using Shouldly;
using Xunit;

namespace Employee.Web.Tests.Controllers
{
    public class HomeController_Tests: EmployeeWebTestBase
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