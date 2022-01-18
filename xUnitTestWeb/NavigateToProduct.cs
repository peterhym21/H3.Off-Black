using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Xunit;

namespace xUnitTestWeb
{
    public class NavigateToProduct
    {
        const string homeUrl = "https://localhost:44307/";
        const string MenUrl = "https://localhost:44307/Men/Men";
        const string homeTitle = "Off-Black";

        [Fact]
        [Trait("Category", "Smoke")]
        public void GoToMenClothingPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(homeUrl);

                Thread.Sleep(3000);

                driver.Navigate().GoToUrl(MenUrl);

                Thread.Sleep(3000);

                Assert.Equal(homeTitle, driver.Title);
                Assert.Equal(MenUrl, driver.Url);
            }
        }
    }
}