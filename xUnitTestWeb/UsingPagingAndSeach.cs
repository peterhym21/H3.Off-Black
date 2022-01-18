using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace xUnitTestWeb
{
    public class UsingPagingAndSeach
    {
        const string homeUrl = "https://localhost:44307/";
        const string MenUrl = "https://localhost:44307/Men/Men";

        [Fact]
        [Trait("Category", "Application")]
        public void UseThePagingOnMen()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(homeUrl);

                Thread.Sleep(2000);

                driver.Navigate().GoToUrl(MenUrl);

                Thread.Sleep(2000);


                IWebElement prioritySelect = driver.FindElement(By.Id("Pagesize"));
                SelectElement priorityChoices = new SelectElement(prioritySelect);

                priorityChoices.SelectByText("2");

                Thread.Sleep(1000);

                IWebElement searchbtn = driver.FindElement(By.Name("Search"));
                searchbtn.Click();

                Thread.Sleep(1000);

                IWebElement pageNavigate = driver.FindElement(By.Name("2"));
                pageNavigate.Click();

                Thread.Sleep(3000);


                Assert.Equal("https://localhost:44307/Men/Men?currentpage=2&pagesize=2", driver.Url);
            }
        }



        [Fact]
        [Trait("Category", "Application")]
        public void UseingSeachFilterOnFrontPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(homeUrl);

                Thread.Sleep(2000);

                driver.FindElement(By.Id("Search")).SendKeys("tomboy");

                Thread.Sleep(1000);

                IWebElement searchbtn = driver.FindElement(By.Name("Search"));
                searchbtn.Click();

                Thread.Sleep(2000);

                Assert.Equal(homeUrl, driver.Url);
            }
        }




    }
}
