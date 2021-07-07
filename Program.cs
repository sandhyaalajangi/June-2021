using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
namespace june2021
{

	class Program
	{
		private static object actualCode;

		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			//Test case_1 Login Turnup portal

			IWebDriver driver = new ChromeDriver(@"C:\Users\eswar\Downloads\chromedriver_win32 (1)\");
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

			//check if user is logged in successfully
			IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']"));

			if (helloHari.Text == "Hello Hari!")
			{
				Console.WriteLine("Loggedin Successfully,test Passed");
			}
			else
			{
				Console.WriteLine("Log in Failed,test Case failed");
			}


			//Test case 2  Create new Record

			//Identify Administration menu and click
			IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
			administration.Click();


			//select Time nd Material from Dropdown menu
			IWebElement timeandmaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
			timeandmaterial.Click();
			Thread.Sleep(1500);

			//Identfy create new button and click
			IWebElement createnew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
			createnew.Click();
			Thread.Sleep(1000);

			//identify type code from drop down list and click Material
			IWebElement time = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
			time.Click();
			Thread.Sleep(500);

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
			Thread.Sleep(1500);

			//identify to go last page and click 
			IWebElement lastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
			lastpage.Click();
			Thread.Sleep(1000);

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

			//test case 3 edit Functionality 

			//identify and click edit button
			IWebElement editbutton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[5]/td[5]/a[1]"));
			editbutton1.Click();


			//identify type code text box and select time from dropdown list
			driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
			Thread.Sleep(2000);

			//identify code textbox and edit code
			//IWebElement Code = driver.FindElement(By.Id("Code"));
			//code.SendKeys("M");

			//identify description textbox and edit description  driver.FindElement(By.Id("Code")).Clear();
			driver.FindElement(By.Id("Description")).Clear();
			driver.FindElement(By.Id("Description")).SendKeys("automation tester121");



			//identify price per unit text box and edit price
			//driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("19");
			driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("14");



			//identify save button and click on save button
			driver.FindElement(By.Id("SaveButton")).Click();
			Thread.Sleep(1500);

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










		

	

