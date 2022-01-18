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
    public class CheckoutTest
    {

        const string homeUrl = "https://localhost:44307/";
        const string MenUrl = "https://localhost:44307/Men/Men";
        const string homeTitle = "Off-Black";


        [Fact]
        [Trait("Category", "Application")]
        public void NavigateToProductAndGoToDetailsAndAddToCartAndCheckOut()
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

                IWebElement goToCheckout = driver.FindElement(By.Id("Checkout"));
                goToCheckout.Click();

                Thread.Sleep(2000);


                driver.FindElement(By.Id("FirstName")).SendKeys("Peter");
                driver.FindElement(By.Id("LastName")).SendKeys("Hymøller");
                driver.FindElement(By.Id("Email")).SendKeys("test@test.com");
                driver.FindElement(By.Id("PhoneNumber")).SendKeys("12345678");
                driver.FindElement(By.Id("City")).SendKeys("Testby");
                driver.FindElement(By.Id("Adress")).SendKeys("TestVej");
                driver.FindElement(By.Id("Zip")).SendKeys("0000");


                driver.FindElement(By.Id("PayPal")).Click();
                driver.FindElement(By.Id("TermsAndConditons")).Click();


                Thread.Sleep(3000);

                IWebElement placeOrder = driver.FindElement(By.Id("PlaceOrder"));
                placeOrder.Click();

                Thread.Sleep(3000);

                Assert.Equal("https://localhost:44307/Checkout/CheckoutConformation", driver.Url);
            }
        }
    }
}
