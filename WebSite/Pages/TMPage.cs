using System;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace WebSite.Pages
{
    class TMPage
    {
        public void CreateTM(IWebDriver driver)

        {
            Thread.Sleep(2000);
            // Task - 1 create time / material record successfully
            // Create new record
            IWebElement CreateNew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreateNew.Click();
            Thread.Sleep(1000);

            // Select Type Code
            IWebElement TypeCode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]"));
            TypeCode.Click();
            Thread.Sleep(1000);

            // Enter Code
            IWebElement Code = driver.FindElement(By.XPath("//*[@id='Code']"));
            Code.SendKeys("SEL");
            Thread.Sleep(1000);

            // Enter Description
            IWebElement Description = driver.FindElement(By.XPath("//*[@id='Description']"));
            Description.SendKeys("Auto");
            Thread.Sleep(1000);

            // Enter Price per unit
            IWebElement InputPrice = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            InputPrice.SendKeys("81");
            Thread.Sleep(1500);

            // Select File
            IWebElement SelectFiles = driver.FindElement(By.XPath("//*[@id='files']"));
            SelectFiles.SendKeys(@"E:\SELENIUM\WebSite\NewRecord.txt");
            Thread.Sleep(1000);

            // Click Save Button
            IWebElement Save = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            Save.Click();
            Thread.Sleep(3000);

            // Validate if the record is created successfully

            // Go to last page
            IWebElement LastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            LastPage.Click();
            Thread.Sleep(2000);

            // Identify the created record
            string newRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text;
            Thread.Sleep(1000);

            // Verify the deleated details - option 1
            // if (newRecord == "Create")
            //{
            //Assert.Pass("New Record created successfully, Test Passed");

            //}
            // else
            //{
            //Assert.Fail("Test Failed");

            //}

            // Verify the updated details - option 2
            Assert.That(newRecord, Is.EqualTo("SEL"), "Test Failed");

        }

        public void EditTM(IWebDriver driver)
        {
            // Test 2 - edit time/material record successfully

            //Thread.Sleep(2000);
            // Click Administration
            //driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            //Thread.Sleep(2000);

            // Click Time and Material
            //driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
            //Thread.Sleep(3000);

            // Go to last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(2000);

            // Click edit on the last record that was created in the previous test            
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[5]/td[5]/a[1]")).Click();
            Thread.Sleep(2000);//*[@id="tmsGrid"]/div[3]/table/tbody/tr/td[5]/a[1]

            // Update from material to time            
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]")).Click();
            Thread.Sleep(2000);

            // Update code            
            driver.FindElement(By.XPath("//*[@id='Code']")).Clear();
            driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("MHR Edit");
            Thread.Sleep(2000);

            // Update description
            driver.FindElement(By.XPath("//*[@id='Description']")).Clear();
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("Edit");
            Thread.Sleep(2000);

            // Update price - clear 
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Clear();
            driver.FindElement(By.XPath("//*[@id='Price']")).Clear();
            Thread.Sleep(2000);

            // Update price - input/updated
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='Price']")).SendKeys("18");
            Thread.Sleep(2000);

            // Upload a doc 
            driver.FindElement(By.XPath("//*[@id='files']")).SendKeys(@"E:\SELENIUM\WebSite\UpdatedRecord.txt");
            Thread.Sleep(2000);

            // Save
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();
            Thread.Sleep(2000);

            // Validate if the record is updated Successfully

            // Go to the last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(2000);

            // Identify the updated record
            string actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text;
            Thread.Sleep(2000);

            // Verify the updated details
            if (actualCode == "MHR Edit")
            {
                Console.WriteLine("Record edited Successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }
        }

        public void DeleteTM(IWebDriver driver)

        {
            // Test 3 - delete time / material record successfully
            //Thread.Sleep(2000);
            // Test 3 - delete time/material record successfully
            //Thread.Sleep(2000);
            // Click Administration
            //driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            //Thread.Sleep(2000);

            // Click Time/Material
            //driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
            //Thread.Sleep(2000);

            // Go to last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(2000);

            // Click delete on the last record that was created in the previous test
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[5]/td[5]/a[2]")).Click();
            Thread.Sleep(2000);

            // Switching alert to Delete this record            
            IAlert alert = driver.SwitchTo().Alert();

            // Acceting alert
            alert.Accept();
            Thread.Sleep(2000);

            // Validate if the record is deleted successfully

            // Go to last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(2000);

            // Identify the Created details was deleted or not
            string createdDetails = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]")).Text;
            Thread.Sleep(1000);

            // Verify the deleated details
            if (createdDetails != "alert.Accept()")
            {
                Console.WriteLine("Record Deleted Successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }
        }
    }
}
