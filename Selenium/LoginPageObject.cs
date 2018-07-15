using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "Username")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }


        public EAPageObject Login(string userName, string password)
        {
            // UserName
            txtUserName.SendKeys(userName);
            // Password
            txtPassword.SendKeys(password);
            // Click button
            btnLogin.Click();
            // Return the page object
            return new EAPageObject();
        }
    }
}
