using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TestFire.Page;
using TestFire.setup;

namespace TestFire.steps
{
    [Binding]
    [Scope(Tag = "@SignOutSucessfull")]
    public class TestFireFeatureSteps : TestFireSetup
    {
        public IWebDriver browser;

        public TestFirePage signout;

        [Given(@"I navigate to\ttestfire")]
        public void GivenINavigateToTestfire()
        {
            browser = Driver;
            signout = new TestFirePage(browser);
            browser.Navigate().GoToUrl("http://demo.testfire.net/");
        }
        
        [When(@"I click on Online Banking Login")]
        public void WhenIClickOnOnlineBankingLogin()
        {
            signout.ClickonlineBanklogin();
        }
        
        [When(@"I enter the valid user details")]
        public void WhenIEnterTheValidUserDetails()
        {
            signout.UserDetails();

        }
        
        [When(@"I can see (.*) accounts are visible under Account Details")]
        public void WhenICanSeeAccountsAreVisibleUnderAccountDetails(int p0)
        {
            signout.SeeAccountNumbers();
        }
        
        [When(@"I click on Signoff")]
        public void WhenIClickOnSignoff()
        {
            signout.ClickonSignoff();
        }
        
        [Then(@"I signoff sucessfully")]
        public void ThenISignoffSucessfully()
        {
            signout.CheckMessage();   
        }
    }
}
