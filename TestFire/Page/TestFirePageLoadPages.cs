using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;

namespace TestFire.Page
{
    public class TestFirePageLoadPages
    {
        public IWebDriver Driver;

        public TestFirePageLoadPages(IWebDriver browser)
        {
            Driver = browser;
            PageFactory.InitElements(Driver, this);
        }

        public void NavigatetoTestFire()
        {
            Driver.Navigate().GoToUrl("http://demo.testfire.net/");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [FindsBy(How = How.LinkText, Using = "ONLINE BANKING LOGIN")]
        public IWebElement OnlineBankingLogin;



        public void CheckMessage()
        {
            OnlineBankingLogin.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
    }
}
