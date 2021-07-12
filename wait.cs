using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace june2021.Utilities
{
    class wait
    {
        //reusauable funtion for wait
        public static void WaitforWebElementToExist(IWebDriver driver, string attributeValue, string attribute,int secondsToWait)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, secondsToWait));
            if (attribute == "XPath")
            {
                
                IWebElement webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(attributeValue)));

            }

            if (attribute == "ID")
            {
                
                IWebElement webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(attributeValue)));

            }


            if (attribute == "CssSelector")
            {
               
                IWebElement webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(attributeValue)));

            }
        }
    }
}
