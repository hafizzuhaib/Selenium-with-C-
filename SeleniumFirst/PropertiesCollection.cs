using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    public class PropertiesCollection
    {
        public enum PropertiesType
        {
            Id,
            Name,
            LinkText,
            CssName,
            ClassName
        }
        public static IWebDriver driver { get; set; }
    }
}
