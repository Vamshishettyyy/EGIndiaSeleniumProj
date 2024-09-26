using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitSelenium.Selenium
{
    internal class WebHandling
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            // intialize the web driver 
            driver = new EdgeDriver();
            // launch the forefox browser

            driver.Navigate().GoToUrl("https://www.cavai.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {
            IWebElement StartswithFooter = driver.FindElement(By.XPath("(//div[starts_with(@class,'Footer__')]"));
            IWebElement ContainsFooter = driver.FindElement(By.XPath("//div[contains(@id,'Combined-Shape')]"));
            IWebElement EndswithFooter = driver.FindElement(By.XPath("//div[ends_with(ends_with(@class.'wrapper'))]"));
            IWebElement multiple = driver.FindElement(By.XPath("//*[@id=\"//*[name()='path' and @id='Combined-Shape']\"]/p"));

        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
