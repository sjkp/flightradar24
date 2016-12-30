using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sjkp.flightradar24.api.Models
{

    public class SearchResponse
    {
        public Result[] results { get; set; }        
        public Stats stats { get; set; }
    }

    public class Stats
    {
        public Total total { get; set; }
        public Count count { get; set; }
    }

    public class Total
    {
        public int all { get; set; }
        public int airport { get; set; }
        public int _operator { get; set; }
        public int live { get; set; }
        public int schedule { get; set; }
        public int aircraft { get; set; }
    }

    public class Count
    {
        public int airport { get; set; }
        public int _operator { get; set; }
        public int live { get; set; }
        public int schedule { get; set; }
        public int aircraft { get; set; }
    }

    public class Result
    {
        public string id { get; set; }
        public string label { get; set; }
        public Detail detail { get; set; }
        public string type { get; set; }
        public string match { get; set; }
        public string name { get; set; }
    }

    public class Detail
    {
        public string image { get; set; }
        public string iata { get; set; }
        public float lat { get; set; }
        public float lon { get; set; }
        public string reg { get; set; }
        public string callsign { get; set; }
        public string flight { get; set; }
    }

}

