using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using UITestAutomation.Tests;

namespace UITestAutomation.Pages
{
    internal class CartPage : Base
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public CartPage()
        {
            driver = _webdriver;

        }


        public string RemoveButton_Xapth = "//button[contains (@name, 'remove')]";

        private IWebElement RemoveButton => driver.FindElement(By.XPath(RemoveButton_Xapth));

        public string CheckoutButton_Xapth = "//button[contains (@id, 'checkout')]";

        private IWebElement CheckoutButton => driver.FindElement(By.XPath(CheckoutButton_Xapth));

        public CartPage ClickRemoveButton()

        {

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(RemoveButton_Xapth)));
            RemoveButton.Click();
            return this;


        }

        public CheckOutPage ClickCheckOut()

        {

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(CheckoutButton_Xapth)));
            CheckoutButton.Click();
            return new CheckOutPage();


        }









    }
}

