using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using june2021.Utilities;
using OpenQA.Selenium;

namespace june2021.Pages
{
    class TMpages
    {
        //test -create new TM
        public void CreateTM(IWebDriver driver)
        {

			//Identfy create new button and click 
			IWebElement createnew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
			createnew.Click();
			//Thread.Sleep(1000);
			wait.WaitforWebElementToExist(driver,"//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]","XPath",5);

			//identify type code from drop down list and click Material
			IWebElement time = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
			time.Click();
			//Thread.Sleep(500);
			wait.WaitforWebElementToExist(driver,"//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]","XPath",5);

			IWebElement material = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
			material.Click();

			//identify code text box and input the code
			IWebElement code = driver.FindElement(By.Id("Code"));
			code.SendKeys("M");

			//identify description textbox and input the description
			IWebElement description = driver.FindElement(By.Id("Description"));
			description.SendKeys("Test");

			//identify price per unit text box and input price
			driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("14");

			//identify save button and click on save button
			IWebElement save = driver.FindElement(By.Id("SaveButton"));
			save.Click();
			//Thread.Sleep(2000);
			wait.WaitforWebElementToExist(driver, "//*[@id='tmsGrid']/div[4]/a[4]/span","XPath",2);

			//identify to go last page and click 
			IWebElement lastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
			lastpage.Click();
			//Thread.Sleep(1000);
			wait.WaitforWebElementToExist(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[2]", "XPath", 2);

			//check if record is created
			IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[2]"));

			if (actualCode.Text == "M")
			{
				Console.WriteLine("Test passed, Item is created successfully");
			}
			else
			{
				Console.WriteLine("Test failed, item is not created");
			}
		}

		//test-edit TM
		public void EditTM(IWebDriver driver)
		{
			//test case 3 edit Functionality 

			//identify and click edit button
			IWebElement editbutton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[5]/td[5]/a[1]"));
			editbutton1.Click();


			//identify type code text box and select time from dropdown list
			driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
			//Thread.Sleep(2000);
			wait.WaitforWebElementToExist(driver, "Code", "Id",2);

			//identify code textbox and edit code
			//IWebElement Code = driver.FindElement(By.Id("Code"));
			//code.SendKeys("M");

			//identify description textbox and edit description  driver.FindElement(By.Id("Code")).Clear();
			driver.FindElement(By.Id("Description")).Clear();
			driver.FindElement(By.Id("Description")).SendKeys("automation tester121");



			//identify price per unit text box and edit price
			driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("14");



			//identify save button and click on save button
			driver.FindElement(By.Id("SaveButton")).Click();
			//Thread.Sleep(1500);
			wait.WaitforWebElementToExist(driver, "//*[@id='tmsGrid']/div[4]/a[4]/span", "XPath", 5);

			//Navigate to the last page and click
			driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
			Thread.Sleep(3000);

			//check if record is updated
			IWebElement EditDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[5]/td[3]"));


			if (EditDescription.Text == "automation tester121")

			{
				Console.WriteLine("Entry updated, test passed");
			}
			else
			{
				Console.WriteLine("Test failed, Entry not updated");
			}

		}




		//test-delete TM
		public void DeleteTM(IWebDriver driver)
		{
			//test case 4 delete functionality


			//identify delete button and click on delete button

			IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[5]/td[5]/a[2]"));
			deleteButton.Click();

			Thread.Sleep(2000);

			// Switching to Alert        
			driver.SwitchTo().Alert().Accept();
			Thread.Sleep(4000);


		}

	}
}
