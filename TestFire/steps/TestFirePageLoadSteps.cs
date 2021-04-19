using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TestFire.setup;
using TestFire.Page;

namespace TestFire.steps
{
    [Binding]
    [Scope(Tag = "@TestFirePageLoad")]
    public class TestFirePageLoadFeatureSteps : TestFireSetup
    {
        public IWebDriver Browser;

        public TestFirePageLoadPages pageload;

        [Given(@"I navigate to TestFire")]
        public void GivenINavigateToTestFire()
        {
            Browser = Driver;
            pageload = new TestFirePageLoadPages(Browser);
            pageload.NavigatetoTestFire();
        }
        
        [Then(@"I see Page Loads")]
        public void ThenISeePageLoads()
        {
            pageload.CheckMessage();
        }
    }
}
