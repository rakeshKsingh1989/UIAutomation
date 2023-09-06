using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation.Tests
{
    internal class Base
    {
        protected static WebDriver _webdriver;

        [SetUp]
        public void SetUp()
        {
            _webdriver = new FirefoxDriver();
            _webdriver.Manage().Window.Maximize();
            //_webdriver.Url = ConfigurationManager.AppSettings["BaseURL"];
            _webdriver.Url = "https://www.saucedemo.com/";
        }

        [TearDown]
        public void TearDown()
        {
            _webdriver.Quit();


        }
    }
}
