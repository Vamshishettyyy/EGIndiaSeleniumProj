using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NunitSelenium.Utilities;
using NUnitSeleniumC_Training.Utilities;
using OpenQA.Selenium;

namespace NunitSelenium.DataDriven
{
    internal class Login : Base
    {

        [Test]
        public void testcase1()
        {
            Thread.Sleep(2000);
            IWebElement Ussername = driver.FindElement(By.Name("username"));
            Ussername.SendKeys("Admin");

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("admin123");

            IWebElement LoginButton = driver.FindElement(By.XPath("//button[@type='submit']"));
            LoginButton.Click();

        }
    }
}
