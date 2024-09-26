using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Edge;

namespace NunitSelenium.Selenium
{
    internal class Windows
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

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void windowHandellingScenarios()

        {
       //fetch window handel of parent page!!


            string currWindow = driver.CurrentWindowHandle;

            Assert.That(currWindow, Is.Not.Null);

            IWebElement windowInput = driver.FindElement(By.XPath("(//a[normalize-space()='Click Here'])[1]"));

            windowInput.Click();
            Thread.Sleep(3000);

            IList<string> winodowNames =new List<string>(driver.WindowHandles);


            //move the control to child window.

            driver.SwitchTo().Window(winodowNames[1]);


            string title = driver.Title;

            Assert.That(title, Is.EqualTo("New Window"));

            Thread.Sleep(4000);

            driver.Close();

            driver.SwitchTo().Window(winodowNames[0]);


            string  Parenttitle = driver.Title;

            Assert.That(Parenttitle, Is.EqualTo("The Internet"));

            Thread.Sleep(4000);

            Thread.Sleep(4000);

        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
