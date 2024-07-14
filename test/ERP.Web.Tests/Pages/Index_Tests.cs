using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ERP.Pages;

public class Index_Tests : ERPWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
