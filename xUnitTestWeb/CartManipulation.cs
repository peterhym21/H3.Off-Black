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
    public class CartManipulation
    {

        const string homeUrl = "https://localhost:44307/";
        const string MenUrl = "https://localhost:44307/Men/Men";
        const string homeTitle = "Off-Black";


        [Fact]
        [Trait("Category", "Application")]
        public void NavigateToProductAndGoToDetailsAndAddToCart()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(homeUrl);

                Thread.Sleep(2000);

                driver.Navigate().GoToUrl(MenUrl);

                Thread.Sleep(2000);

                IWebElement createLink = driver.FindElement(By.Id("1"));
                createLink.Click();

                Thread.Sleep(2000);

                IWebElement addCart = driver.FindElement(By.Name("addToCart"));
                addCart.Click();


                Thread.Sleep(2000);

                IWebElement cart = driver.FindElement(By.Id("Cart"));
                cart.Click();


                Thread.Sleep(2000);

                Assert.Equal(homeUrl, driver.Title);
                Assert.Equal(MenUrl, driver.Url);
            }
        }


        [Fact]
        [Trait("Category", "Application")]
        public void IncreassAmountOfCartItem()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(MenUrl);

                IWebElement createLink = driver.FindElement(By.Id("1"));
                createLink.Click();

                IWebElement addCart = driver.FindElement(By.Name("addToCart"));
                addCart.Click();

                IWebElement cart = driver.FindElement(By.Id("Cart"));
                cart.Click();

                Thread.Sleep(2000);

                driver.FindElement(By.Id("Amount")).SendKeys("2");

                Thread.Sleep(1000);
                IWebElement update = driver.FindElement(By.Id("Update"));
                update.Click();

                Thread.Sleep(2000);


                Assert.Equal(homeUrl, driver.Title);
                Assert.Equal(MenUrl, driver.Url);
            }
        }

        [Fact]
        [Trait("Category", "Application")]
        public void DeleteCartAmount()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(MenUrl);

                IWebElement createLink = driver.FindElement(By.Id("1"));
                createLink.Click();

                IWebElement addCart = driver.FindElement(By.Name("addToCart"));
                addCart.Click();

                IWebElement cart = driver.FindElement(By.Id("Cart"));
                cart.Click();

                Thread.Sleep(2000);

                IWebElement update = driver.FindElement(By.Id("Delete"));
                update.Click();

                Thread.Sleep(2000);


                Assert.Equal(homeUrl, driver.Title);
                Assert.Equal(MenUrl, driver.Url);
            }
        }

        [Fact]
        [Trait("Category", "Application")]
        public void BackToLookAtMoreProducts()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(MenUrl);

                IWebElement createLink = driver.FindElement(By.Id("1"));
                createLink.Click();

                IWebElement addCart = driver.FindElement(By.Name("addToCart"));
                addCart.Click();

                IWebElement cart = driver.FindElement(By.Id("Cart"));
                cart.Click();

                Thread.Sleep(2000);

                IWebElement update = driver.FindElement(By.Id("KeepLooking"));
                update.Click();

                Thread.Sleep(2000);


                Assert.Equal(homeUrl, driver.Title);
                Assert.Equal(MenUrl, driver.Url);
            }
        }


    }
}
