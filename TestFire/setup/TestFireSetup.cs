using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TestFire.setup
{
   public class TestFireSetup
    {
        public IWebDriver Driver;

        [BeforeScenario]

        public void BeforeScenario()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        [AfterScenario]

        public void AfterScenario()
        {
            Driver.Close();
            Driver.Quit();

        }
    }
}
