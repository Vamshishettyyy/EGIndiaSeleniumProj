using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace NunitSelenium.Selenium
{
    internal class Facebook
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

            driver.Navigate().GoToUrl("https://www.facebook.com/login/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void FBUsernameAction()
        {
        new Actions(driver).KeyDown(Keys.Shift).SendKeys("abcd2gmail" ).KeyUp(Keys.Shift).SendKeys( ".").KeyDown(Keys.Shift).SendKeys("com").KeyUp(Keys.Shift).KeyDown(Keys.Tab).KeyUp(Keys.Tab).Perform();
            Thread.Sleep(3000);
            new Actions(driver).KeyDown(Keys.Shift).SendKeys("xyz2").KeyUp(Keys.Shift).SendKeys("1234").Perform();
         Thread.Sleep(3000);

        }
       
        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
