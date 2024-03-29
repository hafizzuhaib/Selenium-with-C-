﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    public class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }


        public EAPageObject Login(string userName, string password)
        {
            SeleniumSetMethod.EnterText(txtUserName, userName);

            SeleniumSetMethod.EnterText(txtPassword, password);

           // SeleniumSetMethod.Click(btnLogin);


            //txtUserName.SendKeys(userName);
            //txtPassword.SendKeys(password);
            btnLogin.Submit();

            return new EAPageObject();
        }
    }
}
