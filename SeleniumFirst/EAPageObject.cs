using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;

namespace SeleniumFirst
{
    public class EAPageObject
    {
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement ddlTitleID { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }


        public void FillUserForm(string title, string initial, string firstName, string middleName)
        {
            SeleniumSetMethod.EnterText(ddlTitleID, title);
            SeleniumSetMethod.EnterText(txtInitial, initial);
            SeleniumSetMethod.EnterText(txtFirstName, firstName);
            SeleniumSetMethod.EnterText(txtMiddleName, middleName);
            SeleniumSetMethod.Click(btnSave);



            //txtInitial.SendKeys(initial);
            //txtFirstName.SendKeys(firstName);
            //txtMiddleName.SendKeys(middleName);
            //btnSave.Click();


        }
    }
}
