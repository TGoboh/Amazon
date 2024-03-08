using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NextBasketAssessment.pageObjects
{
	public class DetailsPage
	{
        private IWebDriver driver;
        public DetailsPage(IWebDriver driver)
		{
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
    
        //Pageobject factory
        [FindsBy(How = How.XPath, Using = "//a[@title='See All Buying Options']")]
        private IWebElement buyingoptions;

        [FindsBy(How = How.XPath, Using = "//span[@id='a-autoid-2-offer-1']")]
        private IWebElement tocart;

        [FindsBy(How = How.XPath, Using = "//i[@class='a-icon aod-close-button']")]
        private IWebElement closebutton;

        [FindsBy(How = How.XPath, Using = "//span[@id='nav-cart-count']")]
        private IWebElement opencart;


        public IWebElement getBuyingOptions()

        {
            return buyingoptions;
        }

        public IWebElement getToCart()

        {
            return tocart;
        }

        public IWebElement getCloseButton()

        {
            return closebutton;
        }

        public IWebElement getOpenCart()

        {
            return opencart;
        }
    }
}

