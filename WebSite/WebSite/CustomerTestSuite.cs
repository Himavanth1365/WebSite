using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using WebSite.Pages;
using WebSite.Utilities;
using System.Collections.Generic;

namespace WebSite
{
    [TestFixture]
    [Parallelizable]
    class CustomerTestSuite : CommonDriver
    {
        //static void Main(string[] args)
        //{
        //}        

        [Test]
        public void CreateCompanyTest()
        {

            // Create object for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToCompany(driver);

            // Create object for Company page
            CompanyPage companyObj = new CompanyPage();
            companyObj.CreateCompany(driver);

        }

        [Test]
        public void EditCompanyTest()
        {

            // Create object for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToCompany(driver);

            // Edit object for Company page
            CompanyPage companyObj = new CompanyPage();
            companyObj.EditCompany(driver);

        }

        [Test]
        public void DeleteCompanyTest()
        {

            // Create object for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToCompany(driver);

            // Delete object for Company page
            CompanyPage companyObj = new CompanyPage();
            companyObj.DeleteCompany(driver);
        }


    }
    
}
