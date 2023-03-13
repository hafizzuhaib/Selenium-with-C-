using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SeleniumFirst.PropertiesCollection;

namespace SeleniumFirst
{
    
    class SeleniumSetMethod
    {
        
        // Enter Text
        public static void EnterText(string element, string value, PropertiesType elementtype)
        {
            if (elementtype == PropertiesType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == PropertiesType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        }
        // Click Into Button, CheckBox, Option etc
        public static void Click( string element, PropertiesType elementtype)
        {
            if (elementtype == PropertiesType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            if (elementtype == PropertiesType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
        }

        // Selecting A drop down control
        public static void SelectDropDown(string element, string value, PropertiesType elementtype)
        {
            
            if (elementtype == PropertiesType.Id)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == PropertiesType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
            new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
        }

    }
}
