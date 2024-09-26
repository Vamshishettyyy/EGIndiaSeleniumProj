using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace NunitSelenium.Selenium
{
    internal class DropDown
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            // intialize the web driver 
            driver = new FirefoxDriver();
            // launch the forefox browser

            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {

           IWebElement DropDown = driver.FindElement(By.Id("dropdown-class-example"));
            Assert.IsNotNull(DropDown);
            var select = new SelectElement(DropDown);

            // select by visible text
            Thread.Sleep(1000);
            select.SelectByText("Option2");

            // select by index select option1
            Thread.Sleep(1000);
            select.SelectByIndex(1);
            //select by value

            Thread.Sleep(1000);
            select.SelectByValue("option3");
        }

        [TearDown]
        public void tearDownbrowser()



        {

            driver.Close();

        }
       
    }
}
