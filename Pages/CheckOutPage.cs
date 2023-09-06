using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using UITestAutomation.Tests;

namespace UITestAutomation.Pages
{
	internal class CheckOutPage : Base
	{
		private IWebDriver driver;
		private WebDriverWait wait;

		public CheckOutPage()
		{
			driver = _webdriver;

		}

		private IWebElement FirstName => driver.FindElement(By.Id("first-name"));
		private IWebElement LastName => driver.FindElement(By.Id("last-name"));
		private IWebElement PostalCode => driver.FindElement(By.Id("postal-code"));

		private IWebElement ContinueButton => driver.FindElement(By.Id("continue"));

		public string FinishButton_Id = "finish";
		private IWebElement FinishButton => driver.FindElement(By.Id(FinishButton_Id));

		public string OrderDispatchedText_CSS = ".complete-text";
		private IWebElement OrderDispatchedText => driver.FindElement(By.CssSelector(OrderDispatchedText_CSS));




		public CheckOutPage EnterDetailsAndContinue(string firstName,string lastName, string postalcode)
		{

			FirstName.SendKeys(firstName);
			LastName.SendKeys(lastName);
			PostalCode.SendKeys(postalcode);
			ContinueButton.Click();
			wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
			wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(FinishButton_Id)));
			FinishButton.Click();
			return this;
		}


		public void VerifyOrderPlaced()

		{
			if (OrderDispatchedText.Displayed)
				Console.WriteLine("Order placed successfully");
            else
            {
                Assert.Fail("order not processed ");
            }


        }

	}
}

