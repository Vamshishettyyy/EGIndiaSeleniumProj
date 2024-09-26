﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitSelenium.Selenium
{
    internal class Assign1
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //Initialize web driver
            driver = new EdgeDriver();
            //Launch browser
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/register");
            driver.Manage().Window.Maximize();

        }
        [Test]
        public void testcase1()
        {
            Thread.Sleep(3000);

            IWebElement Gender = driver.FindElement(By.XPath("//input[@id='gender-female']"));
            Gender.Click();

            Thread.Sleep(3000);

            IWebElement FirstName = driver.FindElement(By.Name("FirstName"));
            FirstName.SendKeys("Vamshiii");

            Thread.Sleep(3000);

            IWebElement LastName = driver.FindElement(By.Name("LastName"));
            LastName.SendKeys("Shettyyyy");

            Thread.Sleep(3000);

            IWebElement Email = driver.FindElement(By.Name("Email"));
            Email.SendKeys("Vamshithakv91833@gmail.com");

            Thread.Sleep(3000);

            IWebElement Password = driver.FindElement(By.Name("Password"));
            Password.SendKeys("Vamshi@1234");

            Thread.Sleep(3000);

            IWebElement ConfirmPassword = driver.FindElement(By.Name("ConfirmPassword"));
            ConfirmPassword.SendKeys("Vamshi@1234");

            Thread.Sleep(3000);

            IWebElement Register = driver.FindElement(By.XPath("//input[@id='register-button']"));
            Register.Click();

        }
        [TearDown]
        public void tearDownbrowser()
        {
            driver.Close();
        }
    }
}
