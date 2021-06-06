using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using WebSite.Utilities;

namespace WebSite.Pages
{
    class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {

            driver.Manage().Window.Maximize();

            // Enter URL
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            try
            {
                Wait.WaitForElementToBePresent(driver, "Id", "UserName", 2);

                // Identify and input username
                IWebElement Username = driver.FindElement(By.Id("UserName"));
                Username.SendKeys("hari");

                // Identify and input password
                IWebElement password = driver.FindElement(By.Id("Password"));
                password.SendKeys("123123");

                // Click Login Button
                IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                LoginButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed at login page", ex.Message);
            }
        }
    }
        
}
