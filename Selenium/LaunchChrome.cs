using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitSelenium.Selenium
{

    internal class LaunchChrome
    {
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
        }
        [Test]
        public void testcase1()
        {
            //string currenturl = driver.Url;
            // Console.WriteLine(currenturl);
        }
        [TearDown]
        public void tearDownbrowser()
        {

        }
    }
}
