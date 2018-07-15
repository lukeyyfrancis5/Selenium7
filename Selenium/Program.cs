using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    class Program
    {
        // Create the reference for Browser
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
           
        }


        [SetUp]
        public void Intialize()
        {
            // Navigate to Google page
            driver.Navigate().GoToUrl("executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Open URL");
        }


        [Test]
        public void ExecuteTest()
        {
            // Title
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

            //Intial
            SeleniumSetMethods.EnterText(driver, "Initial", "executeautomation", "Name");

            Console.WriteLine("The value from my Title is: ", SeleniumGetMethods.GetText(driver, "TitleId", "Id"));
            Console.WriteLine("The value from my Initial is:", SeleniumGetMethods.GetText(driver, "Initial", "Id"));

            // Click
            SeleniumSetMethods.Click(driver, "Save", "Name");



        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next Method");
        }

        [TearDown]
        public void Cleanup()
        {
            // Quit
            driver.Close();
            Console.WriteLine("Close Browser");

        }
    }
}
