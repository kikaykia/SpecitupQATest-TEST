using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecitupQATest.Pages
{
    public class BaseClass
    {


        #region SetMethods

        #region EnterText
        //Enter Text
        public static void EnterText(string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
            if(elementtype == PropertyType.ClassName)
                PropertiesCollection.driver.FindElement(By.ClassName(element)).SendKeys(value);
        }
        #endregion

        #region Click
        public static void Click(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            if (elementtype == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
            if (elementtype == PropertyType.ClassName)
                PropertiesCollection.driver.FindElement(By.ClassName(element)).Click();

        }
        #endregion

        #region SelectDropDown
        public static void SelectDropDown(string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == PropertyType.Name)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
            if (elementtype == PropertyType.ClassName)
                new SelectElement(PropertiesCollection.driver.FindElement(By.ClassName(element))).SelectByText(value);
            if (elementtype == PropertyType.ClassName)
                new SelectElement(PropertiesCollection.driver.FindElement(By.ClassName(element))).SelectByText(value);
        }
        #endregion

        #endregion


        #region GetMethods

        public static string GetText(IWebDriver driver, string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementtype == PropertyType.Name)
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            else return string.Empty;
        }

        public static string GetTextFromDropDown(IWebDriver driver, string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == PropertyType.Name)
                return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return string.Empty;
        }









        #endregion

    }
        
}
