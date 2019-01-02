using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;




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

        [TestMethod]

        public void Test_Sum()
        {

            //Arrange Section - initialize the object abd set the value of the data that is passed to the method being tested.
            var TotalPerson = 5;
            int Adult = 2;
            int infant = 1;
            int Children = 2;

            //ActSection - Invoke the method

            int actual = Controllers.BookOnlineController.Add(Adult, infant, Children);

            ////Assert - Varifies that the method being tested behaves as expected.

            Assert.AreEqual(TotalPerson, actual);             

            


        }


        [Test]
        public void Test()
        {
            driver.Url = "http://localhost/hotelmanager";
            driver.FindElement(By.Id("shared-room-button")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("check-availability")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("booking-date")).SendKeys("26/11/2018-30/11/2018");
            driver.FindElement(By.Id("room-type")).SendKeys("Single Room");
            driver.FindElement(By.Id("adult")).SendKeys("2");
            driver.FindElement(By.Id("infant")).SendKeys("1");
            driver.FindElement(By.Id("children")).SendKeys("1");
            driver.FindElement(By.Id("total-person")).SendKeys("4");           
                                                                  
        }

        [Test1]
        public void Test1()
        {
            driver.FindElement(By.Id("nextbutton")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("First-name")).SendKeys("Reena");
            driver.FindElement(By.Id("Home-Country")).SendKeys("India");
            driver.FindElement(By.Id("Phone-number")).SendKeys("0220595689");
            driver.FindElement(By.Id("Address")).SendKeys("Taranaki street, Wellington");
            driver.FindElement(By.Id("Sur-name")).SendKeys("Lather");
            driver.FindElement(By.Id("Nationality")).SendKeys("Indian");
            driver.FindElement(By.Id("Email-Address")).SendKeys("reena@gmail.com");
            driver.FindElement(By.Id("additional-message")).SendKeys("Hello");

        }
        [Test2]
        public void Test2()
        {
            driver.FindElement(By.Id("nextbutton")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("cardnumber")).SendKeys("4135 6879");
            driver.FindElement(By.Id("security-code")).SendKeys("567");
            driver.FindElement(By.Id("ExpireMonth")).SendKeys("05");
            driver.FindElement(By.Id("Expire-Year")).SendKeys("2020");
            driver.FindElement(By.Id("nextbutton")).SendKeys(Keys.Enter);

        }
        [TestCleanup]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }

    internal class Test1Attribute : Attribute
    {
    }

    internal class Test2Attribute : Attribute
    {
    }
}
