using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NextBasketAssessment.pageObjects
{
	public class HomePage
	{
        private IWebDriver driver;

		public HomePage(IWebDriver driver)
		{
			this.driver = driver;
			PageFactory.InitElements(driver, this);
		}

		//Pageobject factory
		[FindsBy(How = How.XPath, Using = "//input[@type='text']")]
		private IWebElement searchfield;

        [FindsBy(How = How.XPath, Using = "//input[@value='Go']")]
        private IWebElement searchbutton;

        [FindsBy(How = How.XPath, Using = "//span[text()='N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)']")]
        private IWebElement wifirouter;

		
        public IWebElement getSearchField()

		{
			return searchfield;
		}

        public IWebElement getSearchButton()

        {
            return searchbutton;
        }

        public IWebElement getWifiRouter()

        {
            return wifirouter;
        }

    }
}

