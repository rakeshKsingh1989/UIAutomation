using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestAutomation.Pages;

namespace UITestAutomation.Tests
{
    [TestFixture]
    internal class Tests :Base
    {

        [Test]
        public void Test1_ValidUserLoginTests()
        {
            LoginPage page = new LoginPage();
            page.LoginToApp();
        }


        [Test]
        public void Test2_Buy2Items()
        {
            LoginPage page = new LoginPage();

            CheckOutPage checkout=page.LoginToApp().
                AddItemstoCart().
                ClickShoppingCartLink().ClickRemoveButton().ClickCheckOut().EnterDetailsAndContinue("rakesh","kumar","kumar");
            checkout.VerifyOrderPlaced();

        }
    }
}
