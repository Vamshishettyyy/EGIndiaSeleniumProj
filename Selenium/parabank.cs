using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NunitSelenium.Utilities;
using NUnitSeleniumC_Training.Utilities;
using OpenQA.Selenium;

namespace NunitSelenium.Selenium
{
    [TestFixture]
   // [Parallelizable]
    [Allure.NUnit.AllureNUnit]
    internal class ParaBank:Base
    {

        [Test,Category("register"),Order(2)]
      //  [Parallelizable(ParallelScope.Self)]
        public void RegisterNewUser()
        {
            Thread.Sleep(2000);
          IWebElement RegisterButton = driver.FindElement(By.XPath("//a[normalize-space()='Register']"));
           RegisterButton.Click();
            Thread.Sleep(2000);
            // Filling in the registration form fields
            driver.FindElement(By.XPath("//input[@id='customer.firstName']")).SendKeys("Vamshi"); 
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='customer.lastName']")).SendKeys("Shetty");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='customer.address.street']")).SendKeys("123 Main St");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='customer.address.city']")).SendKeys("Mangalore");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='customer.address.state']")).SendKeys("Karnataka");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='customer.address.zipCode']")).SendKeys("575005");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='customer.phoneNumber']")).SendKeys("1234567890");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='customer.ssn']")).SendKeys("123-45-6789");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='customer.username']")).SendKeys("vamshishetty");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='customer.password']")).SendKeys("password123");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='repeatedPassword']")).SendKeys("password123");
            Thread.Sleep(1000);

            //clicking the register button
            driver.FindElement(By.XPath("//input[@value='Register']")).Click();

            Thread.Sleep(2000);
            
           
            IWebElement FileUploadMsg = driver.FindElement(By.XPath("//p[contains(text(),'Your account was created successfully. You are now')]"));

            string textmsg = FileUploadMsg.Text;

            string expectedtext = "Your account was created successfully. You are now logged in.";

            Console.WriteLine(textmsg);

            Assert.AreEqual(textmsg, expectedtext);
            Thread.Sleep(2000);

        }
        [Test,Category("login"),Order(1)]
       // [Parallelizable(ParallelScope.Self)]
        public void loginUser()
        {
            Thread.Sleep(2000);
            IWebElement Ussername = driver.FindElement(By.XPath("//input[@name='username']"));
            Ussername.SendKeys("vamppps1234");

            IWebElement Password = driver.FindElement(By.XPath("//input[@name='password']"));
            Password.SendKeys("password123");
            Thread.Sleep(2000);
            IWebElement LoginButton = driver.FindElement(By.XPath("//input[@value='Log In']"));
            LoginButton.Click();
            Thread.Sleep(2000);
        }


    }
}