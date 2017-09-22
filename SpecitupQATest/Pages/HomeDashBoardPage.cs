using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace SpecitupQATest.Pages
{
    public class HomeDashBoardPage
    {
        #region attributes
        
        private IWebDriver driver;

        //[FindsBy(How = How.ClassName, Using = "siuAlert siuAlert-info")]
        //[CacheLookup]
        //private IWebElement HomepageText { get; set; }

        //[FindsBy(How = How.LinkText, Using = "Models")]
        //[CacheLookup]
        //private IWebElement ModelsLink { get; set; }

        //[FindsBy(How = How.LinkText, Using = "Groups")]
        //[CacheLookup]
        //private IWebElement GroupsLink { get; set; }

        //[FindsBy(How = How.LinkText, Using = "Communities")]
        //[CacheLookup]
        //private IWebElement CommunitiesLink { get; set; }

        //[FindsBy(How = How.LinkText, Using = "Phases")]
        //[CacheLookup]
        //private IWebElement PhasesLink { get; set; }
        
        //[FindsBy(How = How.LinkText, Using = "Series")]
        //[CacheLookup]
        //private IWebElement SeriesLink { get; set; }

        //[FindsBy(How = How.LinkText, Using = "Rooms")]
        //[CacheLookup]
        //private IWebElement RoomsLink { get; set; }

        //[FindsBy(How = How.LinkText, Using = "Attributes")]
        //[CacheLookup]
        //private IWebElement AttributesLink { get; set; }
        
        //[FindsBy(How = How.LinkText, Using = "Manual Options")]
        //[CacheLookup]
        //private IWebElement ManualOptionsLink { get; set; }

        ////[FindsBy(How = How.XPath, Using = "/html[@class='js flexbox flexboxlegacy canvas canvastext webgl no-touch geolocation postmessage websqldatabase indexeddb hashchange history draganddrop websockets rgba hsla multiplebgs backgroundsize borderimage borderradius boxshadow textshadow opacity cssanimations csscolumns cssgradients cssreflections csstransforms csstransforms3d csstransitions fontface generatedcontent video audio localstorage sessionstorage webworkers applicationcache svg inlinesvg smil svgclippaths k-webkit k-webkit58']/body/div[@class='container-fluid body-content']/div[@class='row']/div[@class='col-md-9']/div[@class='col-md-3'][1]/div[@class='panel panel-primary']/div[@class='panel-body']/div[@class='list-group']/a[@class='list-group-item'][3]")]
        //[FindsBy(How = How.LinkText, Using = "Auto Options")]
        //[CacheLookup]
        //private IWebElement AutoOptionsLink { get; set; }

        //[FindsBy(How = How.LinkText, Using = "Selling Prices")]
        //[CacheLookup]
        //private IWebElement SellingPricesLink { get; set; }

        //[FindsBy(How = How.LinkText, Using = "Spec")]
        //[CacheLookup]
        //private IWebElement SpecLink { get; set; }

        //[FindsBy(How = How.LinkText, Using = "Rule Groups")]
        //[CacheLookup]
        //private IWebElement RuleGroupsLink { get; set; }

        //[FindsBy(How = How.LinkText, Using = "Rules")]
        //[CacheLookup]
        //private IWebElement RulesLink { get; set; }

        #endregion

        #region constructor

        public HomeDashBoardPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #endregion

        #region methods

        //public void ClickModelsLink()
        //{
        //    ModelsLink.Click();
        //}

        //public void ClickGroupsLink()
        //{
        //    GroupsLink.Click();
        //}

        //public void ClickCommunitiesLink()
        //{
        //    CommunitiesLink.Click();
        //}


        //public void ClickPhasesLink()
        //{
        //    PhasesLink.Click();
        //}
        
        //public void ClickSeriesLink()
        //{
        //    SeriesLink.Click();
        //}

        //public void ClickRoomsLink()
        //{
        //    RoomsLink.Click();
        //}

        //public void ClickAttributesLink()
        //{
        //    AttributesLink.Click();
        //}

        //public void ClickManualOptionsLink()
        //{
        //    ManualOptionsLink.Click();
        //}

        //public void ClickAutoOptionsLink()
        //{
        //    AutoOptionsLink.Click();
        //}

        //public void ClickSellingPricesLink()
        //{
        //    SellingPricesLink.Click();
        //}

        //public void ClickSpecLink()
        //{
        //    SpecLink.Click();
        //}

        //public void ClickRuleGroupsLink()
        //{
        //    RuleGroupsLink.Click();
        //}

        //public void ClickRulesLink()
        //{
        //    RulesLink.Click();
        //}

        #endregion

    }
}
