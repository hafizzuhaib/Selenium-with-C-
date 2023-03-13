using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumFirstProgram
{

    class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {

            //    //IWebDriver driver = new ChromeDriver();
            //    //var google = "https://www.google.com/";
            //    //driver.Navigate().GoToUrl(google);
            //    //IWebElement element = driver.FindElement(By.Name("q"));
            //    //element.SendKeys("executeautomation");
            //    //Console.WriteLine("Hello World!");
            //    //driver.Close();
        }
        [SetUp]
        public void Initialize()
        {
            //var google = "https://www.google.com/";
            //driver.Navigate().GoToUrl(google);
        }
        [TestCase]
        public void ExecuteTest()
        {
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("executeautomation");
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
