using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using System.IO;
using OpenQA.Selenium.Support.UI;

namespace sjkp.flightradar24.test
{
    [TestClass]
    public class Tiimo
    {
        [TestMethod]
        public void TiimoLogin()
        {
            RemoteWebDriver driver;
            DesiredCapabilities capability = DesiredCapabilities.PhantomJS();
            
            driver = new RemoteWebDriver(
              new Uri("http://localhost:8910"), capability, TimeSpan.FromSeconds(600));// NOTE: connection timeout of 600 seconds or more required for time to launch grid nodes if non are available.
            driver.Manage().Window.Maximize(); // If Linux set window size, max 1920x1080, like driver.Manage().Window.Size = new Size(1920, 1020);
            driver.Navigate().GoToUrl("https://tiimo.dk");
            

            driver.ExecuteScript(@"
var s = document.createElement(""style"");
s.textContent = ""* {transition-property: none !important;-o-transition-property: none !important;-moz-transition-property: none !important;-ms-transition-property: none !important;-webkit-transition-property: none !important;transform: none !important;-o-transform: none !important;-moz-transform: none !important;-ms-transform: none !important;-webkit-transform: none !important;animation: none !important;-o-animation: none !important;-moz-animation: none !important;-ms-animation: none !important;-webkit-animation: none !important;}"";
var head = document.getElementsByTagName(""head"");
head[0].appendChild(s);
");
            IWebElement query = driver.FindElement(By.XPath("//a[contains(text(),'Login')]"));
            query.Click();

            IWebElement input = driver.FindElement(By.Name("email"));
            input.SendKeys("test@sjkp.dk");
            IWebElement pass = driver.FindElement(By.XPath("//input[@placeholder='Adgangskode']"));
            pass.SendKeys("Simon123");
            pass.Submit();

            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.ClassName("tiimo-monthandyear")));
            var logs = driver.Manage().Logs.AvailableLogTypes;
            
            

            var s = driver.GetScreenshot();            
            var bytes = s.AsByteArray;
            File.WriteAllBytes("output.jpg", bytes);
            Console.WriteLine("Video: " + driver.SessionId);
            driver.Quit();

            
        }
    }
}
