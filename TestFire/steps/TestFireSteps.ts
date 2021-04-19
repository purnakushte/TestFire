import {WebDriver,Builder,By,WebElement,Capabilities } from 'selenium-webdriver'
import {Binding,Given,When,Then} from 'cucumber-tsflow'
import {assert} from 'chai'

@Binding()

export class TestFireFeatureSteps extends TestFireSetup {
    
    Browser: WebDriver;
    
    public pageload: TestFirePage;
    
    @Given("I navigate to\ttestfire")
    public GivenINavigateToTestfire() {
        this.Browser = Driver;
        this.pageload = new TestFirePage(this.Browser);
        this.Browser.Navigate().GoToUrl("http://demo.testfire.net/");
    }
    
    @When("I click on Online Banking Login")
    public WhenIClickOnOnlineBankingLogin() {
        this.pageload.ClickonlineBanklogin();
    }
    
    @When("I enter the valid user details")
    public WhenIEnterTheValidUserDetails() {
        this.pageload.UserDetails();
    }
    
    @Then("I can see (.*) accounts are visible under Account Details")
    public ThenICanSeeAccountsAreVisibleUnderAccountDetails(p0: number) {
        this.pageload.VerifyAccount();
    }
}