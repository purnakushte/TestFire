import{WebDriver,Capabilities} from 'selenium-webdriver'
import {ChromeDriver} from 'chromedriver'


export class TestFireSetup {
    
    Driver: WebDriver;

    //let {setDefaultTimeout, After, Before, AfetrAll, BeforeAll} = require('cucumber')
    
    @BeforeScenario()
    BeforeScenario() {
        this.Driver = new ChromeDriver();
        this.Driver.manage().window().maximize();
    }
    
    @AfterScenario()
    AfterScenario() {
        this.Driver.close();
        this.Driver.quit();
    }
}