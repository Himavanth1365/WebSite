using OpenQA.Selenium;
using System.Threading;
using WebSite.Utilities;

namespace WebSite.Pages
{
    class HomePage
    {
        public void NavigateToTM(IWebDriver driver)
        {
            Wait.WaitForElementToBePresent(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/a", 5);

            // Click Administration
            IWebElement Administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Administration.Click();
            Thread.Sleep(1500);

            // Click Time & Materials
            IWebElement TimeMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeMaterial.Click();
            Thread.Sleep(3000);
        }

        public void NavigateToCompany(IWebDriver driver)
        {
            Wait.WaitForElementToBePresent(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/a", 5);

            // Click Administration
            IWebElement Administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Administration.Click();
            Thread.Sleep(1500);

            // Click Company
            IWebElement Company = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a"));
            Company.Click();
            Thread.Sleep(3000);
        }
    }
}
