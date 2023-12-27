using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
   
    public class Tests
    {
        //Create Reference for the browser
       // IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Initialize()
        {
            
            PropertiesCollection.driver = new ChromeDriver();

            var google = "https://demosite.executeautomation.com/";
            PropertiesCollection.driver.Navigate().GoToUrl(google);
            Console.WriteLine("Open URL");
        }
        [TestCase]
        public void ExecuteTest()
        {

            LoginPageObject pageLogin = new LoginPageObject();

            EAPageObject pageEA = pageLogin.Login("Zuhaib", "Lahore");

            pageEA.FillUserForm("TitleId", "Initial","Zuhaib","Hafiz");
            
            
            
            
            //EAPageObject page = new EAPageObject();

            //page.txtInitial.SendKeys("Zuhaib");
            
            //page.btnSave.Click();   

            ////Title
            //SeleniumSetMethod.SelectDropDown("TitleId", "Mr.", PropertiesCollection.PropertiesType.Id);

            ////Initial
            //SeleniumSetMethod.EnterText("Initial", "Zuhaib", PropertiesCollection.PropertiesType.Name);

            //Console.WriteLine("This value from My Ttile is: " + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertiesCollection.PropertiesType.Id));

            //Console.WriteLine("This value from My Initial is : " + SeleniumGetMethods.GetText("Initial", PropertiesCollection.PropertiesType.Name));


            ////Click
            //SeleniumSetMethod.Click("Save", PropertiesCollection.PropertiesType.Name);

        }
        [TearDown]
        public void CleanUp()
        {
           // PropertiesCollection.driver.Close();
        }
    }
}