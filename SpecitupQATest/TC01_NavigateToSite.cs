using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
//using Selenium_Test.Pages;
using NUnit.Framework;
using SpecitupQATest;
using SpecitupQATest.Pages;

namespace SpecitupQATest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    //[TestClass]
    public class TC01_NavigateToSite
    {
        public TC01_NavigateToSite()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes

        #endregion

        #region variables

        string testSite = "https://specitupv3test.cloudapp.net/Account/Login";

        #endregion

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            //PropertiesCollection.driver.Navigate().GoToUrl(testSite);     
            
        }


        [Test]
        public void TestMethod1()
        {
            IWebDriver _driver = PropertiesCollection.driver;
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(testSite);

            var loginPage = new LoginPage(PropertiesCollection.driver);
            loginPage.LoginToApplication();                       

            var homeDashboardPage = new HomeDashBoardPage(PropertiesCollection.driver);
            //homeDashboardPage.ClickAutoOptionsLink();  
            homeDashboardPage.LogoutFromSite();      

        }

        

        // This closes the driver down after the test has finished.  
        [TearDown]
        public void TearDown()
        {
            ////Chrome.Quit();  
            //PropertiesCollection.driver.Close();
            //Console.WriteLine("Closed the browser.");

        }
    }
}
