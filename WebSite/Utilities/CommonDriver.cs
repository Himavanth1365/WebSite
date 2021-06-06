using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebSite.Pages;

namespace WebSite.Utilities
{
    class CommonDriver
    {
        //init webdriver
        public IWebDriver driver;

        [OneTimeSetUp]
        public void LoginToTurnUp()
        {
            // Launch Chrome Browser
            driver = new ChromeDriver(@"E:\SELENIUM\WebSite");

            // Create object for login page

            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);
        }


        [OneTimeTearDown]
        public void TestClosur()
        {
            // Closing down the steps
            driver.Quit();
        }
    }


}
