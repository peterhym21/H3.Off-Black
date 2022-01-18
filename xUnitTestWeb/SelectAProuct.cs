using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace xUnitTestWeb
{
    public class SelectAProuct
    {
        const string homeUrl = "https://localhost:44307/";
        const string MenUrl = "https://localhost:44307/Men/Men";
        const string DetailsUrl = "https://localhost:44307/ProductDetails/1";

        [Fact]
        [Trait("Category", "Application")]
        public void NavigateToProductAndGoToDetails()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(homeUrl);

                Thread.Sleep(2000);

                driver.Navigate().GoToUrl(MenUrl);

                Thread.Sleep(2000);

                IWebElement createLink = driver.FindElement(By.Id("1"));
                createLink.Click();

                Thread.Sleep(3000);

                Assert.Equal(DetailsUrl, driver.Url);
            }
        }
    }
}
