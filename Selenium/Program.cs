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
        
        

        static void Main(string[] args)
        {
           
        }


        [SetUp]
        public void Intialize()
        {
            // Create the reference for Browser
            PropertiesCollection.driver = new ChromeDriver();

            // Navigate to Google page
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("Open URL");
        }


        [Test]
        public void ExecuteTest()
        {
            // Log into application
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login("execute", "automation");

            pageEA.FillUserForm("LF", "Luke", "Brandon");


            //// Title
            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            ////Intial
            //SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);

            //Console.WriteLine("The value from my Title is: ", SeleniumGetMethods.GetText("TitleId", PropertyType.Id));
            //Console.WriteLine("The value from my Initial is:", SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            //// Click
            //SeleniumSetMethods.Click("Save", PropertyType.Name);
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
            PropertiesCollection.driver.Close();
            Console.WriteLine("Close Browser");

        }
    }
}
