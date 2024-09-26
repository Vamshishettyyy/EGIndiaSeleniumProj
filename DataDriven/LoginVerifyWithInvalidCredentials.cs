using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NunitSelenium.Utilities;
using NUnitSeleniumC_Training.Utilities;
using OpenQA.Selenium;

namespace NunitSelenium.DataDriven
{

    internal class LoginVerifyWithInvalidCredentials : Base
    {

        [TestCase("ad", "admin123")]
        [TestCase("ad0", "ad")]
        [TestCase("adm", "ghhjm")]
        public void LoginTest(string username, string password)
        {
            Thread.Sleep(3000);

             
            IWebElement Username = driver.FindElement(By.Name("username"));
            
            Username.SendKeys(username);


            Thread.Sleep(1000);

            IWebElement Password = driver.FindElement(By.Name("password"));
            
            Password.SendKeys(password);


            IWebElement LoginButton = driver.FindElement(By.XPath("//button[@type = 'submit']"));
            LoginButton.Click();

            Thread.Sleep(1000);

            IWebElement Errmsg = driver.FindElement(By.XPath("//div[@class='oxd-alert-content oxd-alert-content--error']"));

            string errmsg = Errmsg.Text;

            Console.WriteLine(errmsg);

            Assert.AreEqual("Invalid credentials", errmsg);


        }

    }
}
