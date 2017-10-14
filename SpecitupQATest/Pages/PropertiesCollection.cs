using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecitupQATest.Pages
{

    public enum PropertyType
    {
        Id,
        Name,
        ClassName,
        HRef

    }


    public class PropertiesCollection
    {

        //Auto-implemented Poperty
        public static IWebDriver driver { get; set; }
           
    }
}
