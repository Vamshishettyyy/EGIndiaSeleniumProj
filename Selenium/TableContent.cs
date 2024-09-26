using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;

namespace NunitSelenium.Selenium
{
    internal class WebTables
    {
        EdgeDriver edgeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

            // initialized driver
            edgeDriver = new EdgeDriver();

           edgeDriver.Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");

           edgeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {
            IWebElement TableElement = edgeDriver.FindElement(By.XPath("//table[@id='table1']"));

            List<IWebElement> AllRows = new List<IWebElement>(TableElement.FindElements(By.XPath("//table[@id='table1']/tbody/tr")));
            List<IWebElement> AllCols = new List<IWebElement>(TableElement.FindElements(By.XPath("//table[@id='table1']/tbody/tr[1]/td")));

            List<IWebElement> ALLData = new List<IWebElement>(TableElement.FindElements(By.XPath("//table[@id='table1']/tbody/tr/td")));

            foreach (IWebElement row in ALLData)
            {
                Console.WriteLine(row.Text);
            }

            Console.WriteLine(AllRows.Count());
            Console.WriteLine(AllCols.Count());
        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            edgeDriver.Dispose();
        }
    }
}
