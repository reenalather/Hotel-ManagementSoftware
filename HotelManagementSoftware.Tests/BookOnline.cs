using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace HotelManagementSoftware.Tests
{
    [TestClass]
    public class BookOnline
    {
        IWebDriver driver;

        [TestInitialize]
        public void StartBrowser()
        {
            driver = new ChromeDriver("C:\\document\\Visual Studio 2017\\Projects\\HotelManagementSoftware\\HotelManagementSoftware.Tests");
        }

        [Test]
        public void Test()
        {
            driver.Url = "http://www.google.co.nz";
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}
