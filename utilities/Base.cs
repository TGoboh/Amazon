using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace NextBasketAssessment.utilities
{
	public class Base
	{

        public IWebDriver driver;
        public IWebElement itemNameElement;
        public IWebElement itemPriceElement;
        public string itemName;
        public string itemPrice;
        public string expectedItemName;
        public string expectedItemPrice;

        [SetUp]
        public void StartBrowser()

        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.amazon.com/";
            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Url);
        }

        [TearDown]
        public void AfterTest()
        {
            driver.Quit();
        }
    }
}

