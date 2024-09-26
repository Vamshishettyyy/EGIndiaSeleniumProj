using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitSelenium.Selenium
{
    internal class DoubleClick
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

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop ");
            driver.Manage().Window.Maximize();
        }

        [Test]
         public void testcase1()
        {
            IWebElement draggable = driver.FindElement(By.XPath("//div[@id='column-a']"));
            IWebElement droppable = driver.FindElement(By.XPath("//div[@id='column-b']"));
            new Actions(driver).DragAndDrop(draggable, droppable).Perform();
            Thread.Sleep(3000);
         }
        
        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
