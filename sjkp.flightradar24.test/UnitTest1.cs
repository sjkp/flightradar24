using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;
using System.IO;
using sjkp.flightradar24.api;
using System.Threading.Tasks;

namespace sjkp.flightradar24.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {

            var client = new FlightRadar24Client();
            var flight = "DY7015";
            var res = await client.Search(flight);

            var id = res.results.First().id;

            //var data = await client.Details(id);

            RemoteWebDriver driver;
            DesiredCapabilities capability = DesiredCapabilities.PhantomJS();

            driver = new RemoteWebDriver(
              new Uri("http://52.169.181.160:8910"), capability, TimeSpan.FromSeconds(600));// NOTE: connection timeout of 600 seconds or more required for time to launch grid nodes if non are available.
            driver.Manage().Window.Maximize(); // If Linux set window size, max 1920x1080, like driver.Manage().Window.Size = new Size(1920, 1020);
            driver.Navigate().GoToUrl($"https://www.flightradar24.com/{flight}/{id}");

            var s = driver.GetScreenshot();
            var bytes = s.AsByteArray;
            File.WriteAllBytes("flight.jpg", bytes);
            Console.WriteLine("Video: " + driver.SessionId);
            driver.Quit();
        }
    }
}
