using System;
using System.ComponentModel;
using TechTalk.SpecFlow;
using UITestAutomation.Pages;

namespace UITestAutomation.Steps
{
    [Binding]
    public class BuyItemsAndPlaceOrderStepDefinitions
    {
        LoginPage page = new LoginPage();

        CheckOutPage checkout = new CheckOutPage();

        CartPage cart = new CartPage();

        ProductsPage prodPage = new ProductsPage();

        [Given(@"user is logged in to application")]
        public void GivenUserIsLoggedInToApplication()
        {
            prodPage=page.LoginToApp();
        }

        [When(@"user adds items to cart")]
        public void WhenUserAddsItemsToCart()
        {
            cart = prodPage.AddItemstoCart().
                ClickShoppingCartLink().ClickRemoveButton();
        }

        [When(@"user places order")]
        public void WhenUserPlacesOrder()
        {
            checkout=cart.ClickCheckOut().EnterDetailsAndContinue("rakesh", "kumar", "kumar");
        }

        [Then(@"verify order is placed successfully")]
        public void ThenVerifyOrderIsPlacedSuccessfully()
        {
            checkout.VerifyOrderPlaced();
        }
    }
}
