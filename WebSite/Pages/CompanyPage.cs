using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace WebSite.Pages
{
    class CompanyPage
    {
        public void CreateCompany(IWebDriver driver)

        {
            Thread.Sleep(2000);
            // Task - 4 create Company record successfully
            // Create new record
            IWebElement CreateNew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreateNew.Click();
            Thread.Sleep(1000);

            // Select Type Code
            IWebElement Name = driver.FindElement(By.XPath("//*[@id='Name']"));
            Name.SendKeys("Himavanth Reddy");
            Thread.Sleep(1000);
        }

        public void EditCompany(IWebDriver driver)
        {
            // Test 5 - edit Edit record successfully
        }

        public void DeleteCompany(IWebDriver driver)
        {
            // Test 6 - delete Company record successfully

        }

    }
}
