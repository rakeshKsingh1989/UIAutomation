using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using UITestAutomation.Steps;
using UITestAutomation.Tests;

namespace UITestAutomation.Pages
{
    internal class LoginPage : Base
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public LoginPage()
        {
            driver = Hooks1._webdriver;

        }

        private IWebElement UserName => driver.FindElement(By.Id("user-name"));

        private IWebElement Password => driver.FindElement(By.Id("password"));

        private IWebElement LoginButton => driver.FindElement(By.Id("login-button"));


        public ProductsPage LoginToApp()
        {
            UserName.SendKeys("standard_user");
            Password.SendKeys("secret_sauce");
            LoginButton.Click();
            ProductsPage prodPage = new ProductsPage();
            if (prodPage.ShoppingCartLinkDisplayed())
                return prodPage;
            else
            {
                Console.WriteLine("Page Not loaded");
                Assert.Fail("Page Not loaded");
            }
            return prodPage;
        }


    }
}

