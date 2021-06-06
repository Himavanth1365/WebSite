using WebSite.Pages;
using WebSite.Utilities;
using NUnit.Framework;



namespace WebSite
{
    [TestFixture]
    class Program : CommonDriver
    {
        //static void Main(string[] args)
        //{
        //}               


        [Test]
        public void CreateTMTest()
        {
            // Create object for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            // Create object for TM page
            TMPage tmObj = new TMPage();
            tmObj.CreateTM(driver);

        }

        [Test]
        public void EditTMTest()
        {
            // Create object for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            // Create object for TM page
            TMPage tmObj = new TMPage();
            tmObj.EditTM(driver);

        }

        [Test]
        public void DeleteTMTest()
        {
            // Create object for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            // Create object for TM page
            TMPage tmObj = new TMPage();
            tmObj.DeleteTM(driver);
        }
    }
}
