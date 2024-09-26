using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NunitSelenium.Utilities;
using OpenQA.Selenium;
using System.Configuration;
using WebDriverManager.DriverConfigs.Impl;
using NUnitSeleniumC_Training.Utilities;
namespace NunitSelenium.DataDriven
{
    internal class TestPar :Base
    {
        [Test]
        [TestCase("Admin", "admin123")]
        [TestCase("Admin", "admin123")]
        [TestCase("Admin", "admin123")]
        public void LoginTestWithMultipleCredentials(string user, string pass)
        {
            
            IWebElement usernameField = driver.FindElement(By.Name("username")); 
            IWebElement passwordField = driver.FindElement(By.Name("password")); 
            Thread.Sleep(3000);

            usernameField.Clear();
            usernameField.SendKeys(user);
            Thread.Sleep(3000);
            passwordField.Clear();
            passwordField.SendKeys(pass);
            Thread.Sleep(3000);
            IWebElement loginButton = driver.FindElement(By.XPath("//button[@type='submit']")); // Replace with actual locator
            loginButton.Click();

            
            System.Threading.Thread.Sleep(3000);
        }
    }
}
