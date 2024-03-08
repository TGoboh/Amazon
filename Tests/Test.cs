using System;
using NextBasketAssessment.pageObjects;
using NextBasketAssessment.utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace NextBasketAssessment
{
    public class Test : Base
    {
        [Test]
        public void Amazon()

        {
            HomePage homePage = new HomePage(driver);
            DetailsPage detailsPage = new DetailsPage(driver);

            homePage.getSearchField().SendKeys("TP-Link N450 WiFi Router");
            homePage.getSearchButton().Click();
            homePage.getWifiRouter().Click();
            detailsPage.getBuyingOptions().Click();
            Thread.Sleep(5000);
            detailsPage.getToCart().Click();
            Thread.Sleep(5000);
            detailsPage.getCloseButton().Click();
            detailsPage.getOpenCart().Click();

            itemNameElement = driver.FindElement(By.XPath("//span[@class='a-truncate-cut']"));
            itemPriceElement = driver.FindElement(By.XPath("//span[@class='a-size-medium a-color-base sc-price sc-white-space-nowrap sc-product-price a-text-bold']"));

            itemName = itemNameElement.Text;
            itemPrice = itemPriceElement.Text;

            expectedItemName = "TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)";
            expectedItemPrice = "$64.5595";

            if (itemName.Equals(expectedItemName) && itemPrice.Equals(expectedItemPrice))
            {
                Console.WriteLine("The correct item and amount is displayed");
            }
            else
            {
                Console.WriteLine("Item or price do not match the expected values.");
            }

        }
    }
}

