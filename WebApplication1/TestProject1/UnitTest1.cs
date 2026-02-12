using Microsoft.Playwright;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var playwright = await Playwright.CreateAsync();
            var requestContext = await playwright.APIRequest.NewContextAsync(new APIRequestNewContextOptions()
            {
                BaseURL = "https://localhost:7106"
            });

            requestContext.
        }
    }
}
