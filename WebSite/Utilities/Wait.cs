using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;



namespace WebSite.Utilities
{
    class Wait
    {    
            // Re-usable function to wait
            public static void WaitForElementToBePresent(IWebDriver driver, string locator, string locatoeValue, int seconds)
            {
                try
                {
                    if (locator == "Id")
                    {
                        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("locatorValue")));
                    }
                    if (locator == "XPath")
                    {
                        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("locatorValue")));
                    }
                    if (locator == "CssSelector")
                    {
                        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("locatorValue")));
                    }

                }
                catch (Exception ex)
                {
                    Assert.Fail("Test failed waiting for element to be present", ex.Message);
                }

            }

            // Re-usable function to wait
            public static void ElementIsVisible(IWebDriver driver, string locator, string locatoeValue, int seconds)
            {
                try
                {
                    if (locator == "Id")
                    {
                        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("locatorValue")));
                    }
                    if (locator == "XPath")
                    {
                        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("locatorValue")));
                    }
                    if (locator == "CssSelector")
                    {
                        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("locatorValue")));
                    }

                }
                catch (Exception ex)
                {
                    Assert.Fail("Test failed waiting for element to be present", ex.Message);
                }

            }        
    }

}
