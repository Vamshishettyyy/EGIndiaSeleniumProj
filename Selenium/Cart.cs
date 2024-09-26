using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitSelenium.Selenium
{
    internal class Cart
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //Initialize web driver
            driver = new EdgeDriver();
            //Launch browser
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        }
        [Test]
        public void testcase1()
        {
            Thread.Sleep(4000);

            IWebElement Username = driver.FindElement(By.Name("user-name"));
            Username.SendKeys("standard_user");

            Thread.Sleep(4000);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("secret_sauce");

            IWebElement LoginButton = driver.FindElement(By.XPath("//input[@id='login-button']"));
            LoginButton.Click();

            Thread.Sleep(4000);

            // Step 2: Add an item to the cart
            IWebElement AddToCartButton = driver.FindElement(By.XPath("(//button[@id='add-to-cart-sauce-labs-backpack'])[1]"));
            AddToCartButton.Click();

            Thread.Sleep(4000);

            // Step 3: Navigate to the cart and verify item is added
            IWebElement CartButton = driver.FindElement(By.XPath("(//a[@class='shopping_cart_link'])[1]"));
            CartButton.Click();

            Thread.Sleep(4000);

            // Step 4: Checkout
            IWebElement CheckoutButton = driver.FindElement(By.XPath("//button[@id='checkout']"));
            CheckoutButton.Click();
            Thread.Sleep(4000);    

            //information 


            IWebElement FirstName = driver.FindElement(By.Name("firstName"));
            FirstName.SendKeys("Vamshiii");

            Thread.Sleep(3000);

            IWebElement LastName = driver.FindElement(By.Name("lastName"));
            LastName.SendKeys("Shettyyyy");

            Thread.Sleep(3000);

            IWebElement postalCode = driver.FindElement(By.XPath("//input[@id='postal-code']"));
            postalCode.SendKeys("575007");

            Thread.Sleep(3000);
            //continue button

            IWebElement ContinueButton = driver.FindElement(By.XPath("//input[@id='continue']"));
            ContinueButton.Click();
            Thread.Sleep(4000);

            ////button[@id='finish']

            IWebElement FinishButton = driver.FindElement(By.XPath("//button[@id='finish'] "));
             FinishButton.Click();
            Thread.Sleep(4000);


            IWebElement confirmationMessage = driver.FindElement(By.XPath("//h2[contains(text(), 'Thank you for your order!')]"));
            Assert.IsNotNull(confirmationMessage, "Order confirmation message not found!");

            Thread.Sleep(4000);


        }
        [TearDown]
        public void tearDownrowser()
        {
            driver.Close();
        }
    }
}
