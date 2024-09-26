using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Edge;

namespace NunitSelenium.Selenium
{
    internal class IFrameContent
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

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/iframe");
            driver.Manage().Window.Maximize();
        }

        [Test]
       public void testcase1()
        {
            IWebElement frame = driver.FindElement(By.XPath("//iframe[@id='mce_0_ifr']"));
            driver.SwitchTo().Frame(frame);
            Thread.Sleep(3000);

            IWebElement content = driver.FindElement(By.XPath("//p[normalize-space()='Your content goes here.']"));
            Thread.Sleep(3000);
            content.Clear();
            content.SendKeys("Hello World");
            Thread.Sleep(1000);
            
        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }

    }
}
