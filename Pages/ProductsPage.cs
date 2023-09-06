using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using UITestAutomation.Tests;

namespace UITestAutomation.Pages
{
    internal class ProductsPage : Base
    {
        private IWebDriver driver;
        private WebDriverWait wait;
       
        public ProductsPage()
        {
            driver = _webdriver;           

        }

        public string ShoppingCartLink_Xapth = "//*[@id='shopping_cart_container']/a";
        private IWebElement ShoppingCartLink => driver.FindElement(By.XPath(ShoppingCartLink_Xapth));

        public string AddToCartButton_Xapth = "//button[contains (@name, 'add-to-cart')]";

        private IWebElement AddToCartButton => driver.FindElement(By.XPath(AddToCartButton_Xapth));


        public bool ShoppingCartLinkDisplayed()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.XPath(ShoppingCartLink_Xapth)));
            return ShoppingCartLink.Displayed;
        }

        public ProductsPage AddItemstoCart()

        {
            AddToCartButton.Click();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(AddToCartButton_Xapth)));

            return this;


        }

        public CartPage ClickShoppingCartLink()

        {
            ShoppingCartLink.Click();
            
            return new CartPage();
        }

    }
}

