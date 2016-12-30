using Microsoft.VisualStudio.TestTools.UnitTesting;
using sjkp.flightradar24.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sjkp.flightradar24.test
{
    [TestClass]
    public class FlightRadar24ClientTest
    {
        [TestMethod]
        public async Task TestSearch()
        {
            var client = new FlightRadar24Client();

            var res = await client.Search("DY7015");

            var id = res.results.First().id;

            var data = await client.Details(id);
        }
    }
}
