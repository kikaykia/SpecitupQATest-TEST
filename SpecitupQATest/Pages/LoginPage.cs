using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SpecitupQATest.Pages;

namespace SpecitupQATest.Pages
{
    public class LoginPage
    {

        #region attributes

        private IWebDriver _driver;



        //[FindsBy(How = How.Id, Using = "EmailAddress")]
        //[CacheLookup]
        //private IWebElement EmailAddress { get; set; }

        //[FindsBy(How = How.Id, Using = "Password")]
        //[CacheLookup]
        //private IWebElement Password { get; set; }

        //[FindsBy(How = How.ClassName, Using = "btn-primary")]
        //[CacheLookup]
        //private IWebElement Submit { get; set; }

        #endregion

        #region constructor

        public LoginPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        #endregion

        #region methods

        public void LoginToApplication()
        {
            //OPTION #1:
            //EmailAddress.SendKeys("kiara.imbong+demohomesv3@gmail.com");
            //Password.SendKeys("qa12345");
            //Submit.Submit();

            //OPTION #2:
            BaseClass.EnterText("EmailAddress", "kiara.imbong+demo2@gmail.com", PropertyType.Id);
            BaseClass.EnterText("Password", "qa12345", PropertyType.Id);
            BaseClass.Click("btn-primary", PropertyType.ClassName);
        }

        //Check if user is directed to the homepage
        public void CheckHomepage()
        {

            //if (isElementPresent(By.linkText("Submit")))
            //{
            //    System.out.println("SUBMIT Link/Button found");
            //}
            //else
            //{
            //    System.out.println("SUBMIT Link/Button not found");
            //}
        }

        #endregion

    }
}
