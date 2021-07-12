using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using june2021.Utilities;
using OpenQA.Selenium;

namespace june2021.Pages
{
    class Homepage
    {
        //function to navigate to TM page
        public void GoToTMpage(IWebDriver driver)
        {
          //Identify Administration menu and click
          IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
          administration.Click();


         //select Time nd Material from Dropdown menu
         IWebElement timeandmaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
         timeandmaterial.Click();
         Thread.Sleep(1500);
            wait.WaitforWebElementToExist(driver, "//*[@id='container']/p/a","XPath", 5);




        }

    }
}
