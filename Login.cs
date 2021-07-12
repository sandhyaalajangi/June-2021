using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace june2021.Pages
{
    class Login
    {
        //functionsthat allows users to login to turnup portal
        public void LoginActions(IWebDriver driver)
        {
           
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();

            //identify username textbox and enter valid username
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            //identify password textbox and enter valid password
            IWebElement Password = driver.FindElement(By.Id("Password"));
            Password.SendKeys("123123");

            //identify login action button and click
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();







        }
    }
}
