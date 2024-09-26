/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Edge;
 using OpenQA.Selenium.Firefox;
using System.Configuration;
namespace NunitSelenium.Utilities
{

    internal class Base
    {
       /* public IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
        string browserName = ConfigurationManager.AppSettings["browser"] ?? "defaultBrowser";
        InitBrowser(browserName);
            Thread.Sleep(3000);

            // launch the chrome browser
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }


        public void InitBrowser(string browserName)
        {
            switch (browserName)
            {
            case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                break;
            case "Edge":
                  new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                  driver = new EdgeDriver();
                break;
            }
        }
        [TearDown]
        public void tearDownbrowser()
        {
           //driver.Close();
            public void TearDown()
            {
                if (driver != null)
                {
                    driver.Quit();
                    driver = null;
                }
            }

        }
    } 
}
    */

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System.Configuration;


namespace NUnitSeleniumC_Training.Utilities
{
    public class Base
    {
        public IWebDriver driver;
        
        [SetUp]
        public void StartBrowser()
        {

            string browserName = ConfigurationManager.AppSettings["browser"];
            InitBrowser(browserName);
            // launch the chrome browser
            driver.Navigate().GoToUrl("https://www.youtube.com/");
            driver.Manage().Window.Maximize();
        }


        public void InitBrowser(string browserName)
        {

            switch (browserName)
            {

                case "Firefox":
                    // confifgure the web driver manager to set up the chrome capabilities
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    // intialize the web driver 
                    driver = new FirefoxDriver();
                    break;

                case "Chrome":
                    // confifgure the web driver manager to set up the chrome capabilities
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    // intialize the web driver 
                    driver = new ChromeDriver();
                    break;

                case "Edge":
                    // confifgure the web driver manager to set up the chrome capabilities
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    // intialize the web driver 
                    driver = new EdgeDriver();
                    break;



            }


        }
        [TearDown]
        public void TearDown()
        {

            /* if (driver != null)
             {
                 driver.Quit();
                 driver.Dispose();
                 driver = null;

             } */
            driver.Close();




        }


    }

}


//"https://parabank.parasoft.com/parabank/register.html"



