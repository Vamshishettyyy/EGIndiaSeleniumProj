using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitSelenium.Selenium
{
    internal class CopyPasteKeyboard
    {
        /* IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            // intialize the web driver 
            driver = new FirefoxDriver();
            // launch the forefox browser

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/iframe");
            driver.Manage().Window.Maximize();
        }

        [Test]
        IWebElement iframeElement = driver.FindElement(By.XPath(" //iframe[@id='mce_0_ifr']")); 
        driver.SwitchTo().Frame(iframeElement);

        // Step 2: Identify the text area inside the iframe and clear existing text
        IWebElement textArea = driver.FindElement(By.Id("tinymce"));
        textArea.Clear();  // Clear any existing text

            // Step 3: Enter new text into the text area
            textArea.SendKeys("Hello World!");

            // Step 4: Switch back to the default content (main page)
            driver.SwitchTo().DefaultContent();


        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }*/
    }
}
