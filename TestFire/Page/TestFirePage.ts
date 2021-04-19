import {IWebElement,WebDriver} from 'selenium-webdriver'
export class TestFirePage {
    
    public Driver: WebDriver;
    
    public constructor (Browser: WebDriver) {
        this.Driver = Browser;
    }
    
    public NavigateTestFirePage() {
        this.Driver.navigate().to("http://demo.testfire.net/");
    }
    
    accountnumber: string = "";
    
     OnlineBankingLogin: IWebElement;
     UserNamelink: IWebElement;
     Passwordlink: IWebElement;
     LoginButton: IWebElement;
     ViweAccountDetailslink: IWebElement;
    
     ClickonlineBanklogin() {
        this.OnlineBankingLogin.click();
        this.Driver.sleep(1000);
    }
    
     UserDetails() {
        this.UserNamelink.sendKeys("admin");
        this.Passwordlink.sendKeys("admin");
        this.LoginButton.click();
    }
    
     VerifyAccount() {
        this.ViweAccountDetailslink.getText();
    }
}
