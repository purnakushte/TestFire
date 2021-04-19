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
    public class TestFirePage
    {
        public IWebDriver Driver;

        public TestFirePage(IWebDriver Browser)
        {
            Driver = Browser;
            PageFactory.InitElements(Driver, this);
        }

        public void NavigateTestFirePage()
        {
            Driver.Navigate().GoToUrl("http://demo.testfire.net/");
        }
        
        [FindsBy(How = How.Id, Using = "AccountLink")]
        public IWebElement OnlineBankingLogin;

        [FindsBy(How = How.Id, Using = "uid")]
        public IWebElement UserNamelink;

        [FindsBy(How = How.Id, Using = "passw")]
        public IWebElement Passwordlink;

        [FindsBy(How = How.CssSelector, Using = "td.bb div.fl:nth-child(1) table:nth-child(1) tbody:nth-child(1) tr:nth-child(3) td:nth-child(2) > input:nth-child(1)")]
        public IWebElement LoginButton;

        [FindsBy(How = How.CssSelector, Using = "#listAccounts")]
        public IWebElement AccountListlink;

        [FindsBy(How = How.CssSelector, Using = "#listAccounts")]
        public IWebElement SignoffButton;

        [FindsBy(How = How.LinkText, Using = "ONLINE BANKING LOGIN")]
        public IWebElement OnlineBankingLoginpage;


        public void ClickonlineBanklogin()
        {
            OnlineBankingLogin.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public void UserDetails()
        {
            UserNamelink.SendKeys("admin");
            Passwordlink.SendKeys("admin");
            LoginButton.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }
        public void SeeAccountNumbers()
        {
            AccountListlink.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public void ClickonSignoff()
        {
            SignoffButton.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        public void CheckMessage()
        {
            OnlineBankingLogin.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
    }
}
