package tests;


import org.openqa.selenium.By;
import org.openqa.selenium.Dimension;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.firefox.FirefoxDriver;
import org.testng.Assert;
import org.testng.annotations.*;

/*
 * This class has been generated by Selenium IDE after recording the login scenario on localhost for Swag Labs application.
 * The purpose is to show how to write a basic Selenium test case
 * The recording was exported as Java Selenium with JUnit, with the only changes:
 * 1. setting the package to test.ui
 * Adding in the setup the setting of the property "webdriver.chrome.driver" pointing to the absolute folder on my computer of the Chrome Web Driver.
 * So this has to be changed accordingly
 */
public class LoginBasicTest {
	//IMPORTANT: Please download a Chrome driver and set this variable to the full path to the file
	private final static String CHROME_DRIVER_FULL_PATH = "C:/Users/2DAM-protegido/Desktop/Drivers/chromedriver-win64/chromedriver.exe";
	//private final static String GECKO_DRIVER_FULL_PATH = "/Users/leonardolanni/Downloads/geckodriver";
	private WebDriver driver;

	@BeforeTest
	public void setUp() {
		System.setProperty("webdriver.chrome.driver", CHROME_DRIVER_FULL_PATH);
		driver = new ChromeDriver();
		//System.setProperty("webdriver.gecko.driver", GECKO_DRIVER_FULL_PATH);
		//driver = new FirefoxDriver();
	}

	@AfterTest
	public void tearDown() {
		driver.quit();
	}

	@Test
	public void login() {
		System.out.println("0. Start");
		
		System.out.println("1. Open target page");
		driver.get("https://practicetestautomation.com/practice-test-login/");
		driver.manage().window().setSize(new Dimension(1350, 637));
		
		System.out.println("2. Insert username and password");
		
		System.out.println(" 2.1 Insert username");
		driver.findElement(By.id("username")).click();
		//driver.findElement(By.cssSelector("*[data-test=\"username\"]")).click();
		//driver.findElement(By.cssSelector("*[data-test=\"username\"]")).sendKeys("student");
		driver.findElement(By.id("username")).sendKeys("student");
		
		System.out.println(" 2.1 Insert password");
		driver.findElement(By.id("password")).click();
		//driver.findElement(By.cssSelector("*[data-test=\"password\"]")).click();
		//driver.findElement(By.cssSelector("*[data-test=\"password\"]")).sendKeys("Password123");
		driver.findElement(By.id("password")).sendKeys("Password123");
		
		System.out.println("3. Click submit to perform login");
		driver.findElement(By.id("submit")).click();

		System.out.println("4. Verify login has been successfully executed");
		System.out.println(" 4.1 Page title is 'Logged In Successfully | Practice Test Automation'");
		Assert.assertEquals(driver.getTitle(), "Logged In Successfully | Practice Test Automation");
		
		System.out.println(" 4.2 Page url contains 'inventory'");
		Assert.assertEquals(driver.getCurrentUrl().contains("inventory"), false);
		
		//Pause the execution for 2 seconds to show the logged in page
		try {
			Thread.sleep(2000);
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		System.out.println("5. End");
	}
}
