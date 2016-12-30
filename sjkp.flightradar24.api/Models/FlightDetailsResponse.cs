using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sjkp.flightradar24.api.Models
{
    public class FlightDetailsResponse
    {
        public Identification identification { get; set; }
        public Status status { get; set; }
        public string level { get; set; }
        public Aircraft aircraft { get; set; }
        public Airline airline { get; set; }
        public Owner owner { get; set; }
        public object airspace { get; set; }
        public Airport airport { get; set; }
        public Flighthistory flightHistory { get; set; }
        public object ems { get; set; }
        public string[] availability { get; set; }
        public Time time { get; set; }
        public Trail[] trail { get; set; }
        public int firstTimestamp { get; set; }
        public string s { get; set; }
    }

    public class Identification
    {
        public string id { get; set; }
        public long row { get; set; }
        public Number number { get; set; }
        public string callsign { get; set; }
    }

    public class Number
    {       
        public string @default { get; set; }
        public object alternative { get; set; }
    }

    public class Status
    {
        public bool live { get; set; }
        public string text { get; set; }
        public string icon { get; set; }
        public object estimated { get; set; }
        public bool ambiguous { get; set; }
        public Generic generic { get; set; }
    }

    public class Generic
    {
        public StatusDetails status { get; set; }
        public Eventtime eventTime { get; set; }
    }

    public class StatusDetails
    {
        public string text { get; set; }
        public string color { get; set; }
        public string type { get; set; }
    }

    public class Eventtime
    {
        public int utc { get; set; }
        public int local { get; set; }
    }

    public class Aircraft
    {
        public Model model { get; set; }
        public string registration { get; set; }
        public string hex { get; set; }
        public object age { get; set; }
        public object msn { get; set; }
        public Images images { get; set; }
    }

    public class Model
    {
        public string code { get; set; }
        public string text { get; set; }
    }

    public class Images
    {
        public Thumbnail[] thumbnails { get; set; }
        public Medium[] medium { get; set; }
        public Large[] large { get; set; }
    }

    public class Thumbnail
    {
        public string src { get; set; }
        public string link { get; set; }
        public string copyright { get; set; }
        public string source { get; set; }
    }

    public class Medium
    {
        public string src { get; set; }
        public string link { get; set; }
        public string copyright { get; set; }
        public string source { get; set; }
    }

    public class Large
    {
        public string src { get; set; }
        public string link { get; set; }
        public string copyright { get; set; }
        public string source { get; set; }
    }

    public class Airline
    {
        public string name { get; set; }
        public string _short { get; set; }
        public Code code { get; set; }
        public string url { get; set; }
    }

    public class Code
    {
        public string iata { get; set; }
        public string icao { get; set; }
    }

    public class Owner
    {
        public string name { get; set; }
        public Code code { get; set; }
        public string url { get; set; }
    }

    public class Airport
    {
        public AirportDetails origin { get; set; }
        public AirportDetails destination { get; set; }
        public object real { get; set; }
    }

    public class AirportDetails
    {
        public string name { get; set; }
        public Code code { get; set; }
        public Position position { get; set; }
        public Timezone timezone { get; set; }
        public bool visible { get; set; }
        public string website { get; set; }
        public Info info { get; set; }
    }


    public class Position
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public string altitude { get; set; }
        public Country country { get; set; }
        public Region region { get; set; }
    }

    public class Country
    {
        public string name { get; set; }
        public string code { get; set; }
    }

    public class Region
    {
        public string city { get; set; }
    }

    public class Timezone
    {
        public string name { get; set; }
        public int offset { get; set; }
        public string offsetHours { get; set; }
        public string abbr { get; set; }
        public string abbrName { get; set; }
        public bool isDst { get; set; }
    }

    public class Info
    {
        public string terminal { get; set; }
        public object baggage { get; set; }
        public object gate { get; set; }
    }
    public class Flighthistory
    {
        public Aircraft[] aircraft { get; set; }
        public Flight[] flight { get; set; }
    }

    public class Time
    {
        public TimeDetails scheduled { get; set; }
        public TimeDetails real { get; set; }
        public TimeDetails estimated { get; set; }
        public Other other { get; set; }
        public Historical historical { get; set; }
    }

    public class TimeDetails
    {
        public int? departure { get; set; }
        public int? arrival { get; set; }
    }

    public class Flight
    {
        public Identification identification { get; set; }
        public Aircraft aircraft { get; set; }
        public Airport airport { get; set; }
        public Time time { get; set; }
    }








    public class Historical
    {
        public int flighttime { get; set; }

        public string delay { get; set; }
    }



    public class Scheduled
    {
        public int departure { get; set; }
        public int arrival { get; set; }
    }


    public class Estimated
    {
        public int departure { get; set; }
        public int arrival { get; set; }
    }

    public class Other
    {
        public int eta { get; set; }
        public int updated { get; set; }
    }

    public class Trail
    {
        public float lat { get; set; }
        public float lng { get; set; }
        public int alt { get; set; }
        public int spd { get; set; }
        public int ts { get; set; }
        public int hd { get; set; }
    }

}
