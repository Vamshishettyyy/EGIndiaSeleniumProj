using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSeleniumC_Training.Utilities;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace NunitSelenium.Selenium
{
    internal class Youtube : Base
    {
        /* [Test]
         public void PlaySong()
         {
             // Find the search box and enter the song name
             var searchBox = driver.FindElement(By.XPath("//input[@id='search']"));
             searchBox.SendKeys("Aaj Ki Raat");
             Thread.Sleep(3000);
             // Click the search button
             var searchButton = driver.FindElement(By.XPath("//button[@id='search-icon-legacy']"));
             searchButton.Click();
             Thread.Sleep(3000);
             // Wait until the search results load and click the first video
             //  wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("a#video-title")));

             //firstVideo.Click();
             // Wait until the search results load and are visible



           // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//a[@id='video-title'][1]")));


            // var firstVideo = driver.FindElement(By.XPath("(//a[@id='video-title'])[1]"));
            // firstVideo.Click();




             // Wait until the search results load and the first video is visible
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
             wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//a[@id='video-title'])[1]")));

             // Scroll the first video into view
             var firstVideo = driver.FindElement(By.XPath("(//a[@id='video-title'])[1]"));
             ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", firstVideo);
             ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", firstVideo);
         }

         // Check if the video is playing by looking for the pause button
         // This can vary depending on your needs and the page structure
         //var isPlaying = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("button[title='Pause (k)']")));
         // Assert.IsNotNull(isPlaying, "Video did not start playing.");
     }
     }
        */

        [Test]
        public void PlaySong()
        {
            // Navigate to YouTube
            driver.Navigate().GoToUrl("https://www.youtube.com");

            // Find the search box and enter the song name
            var searchBox = driver.FindElement(By.XPath("//input[@id='search']"));
            searchBox.SendKeys("Aaj Ki Raat");
            Thread.Sleep(3000);

            // Click the search button
            var searchButton = driver.FindElement(By.XPath("//button[@id='search-icon-legacy']"));
            searchButton.Click();
            Thread.Sleep(3000);

            // Wait until the search results load and the first video is visible
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//a[@id='video-title'])[1]")));

            // Scroll the first video into view
            var firstVideo = driver.FindElement(By.XPath("(//a[@id='video-title'])[1]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", firstVideo);

            // Optional: Add a small delay to let the element adjust
            Thread.Sleep(1000);

            // Try to click the video using JavaScript (in case click interception occurs)
            try
            {
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", firstVideo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error clicking the video: " + ex.Message);
                Assert.Fail("Could not click the video.");
            }

            // Optional: wait a few seconds to let the video load and play
            Thread.Sleep(5000); // Replace with a more precise wait if needed

            // Check if the video is playing by looking for the pause button
            try
            {
                var isPlaying = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("button[aria-label='Pause (k)']")));
                Assert.IsNotNull(isPlaying, "Video did not start playing.");
            }
            catch (WebDriverTimeoutException)
            {
                Assert.Fail("Video did not start playing within the expected time.");
            }
        }
    }
}
//yt - formatted - string[aria - label = 'Aaj Ki Raat | Stree 2 | Tamannaah Bhatia | Sachin-Jigar | Madhubanti | Divya | Amitabh | 15th August by Saregama Music 328,906,504 views 1 month ago 3 minutes, 3 seconds']
//yt-formatted-string[@aria-label='Aaj Ki Raat | Stree 2 | Tamannaah Bhatia | Sachin-Jigar | Madhubanti | Divya | Amitabh | 15th August by Saregama Music 328,906,504 views 1 month ago 3 minutes, 3 seconds']