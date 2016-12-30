using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sjkp.flightradar24.api.Models
{
    class Class1
    {
    }


    public class Rootobject
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
        public Time2 time { get; set; }
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
        public string _default { get; set; }
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
        public Status1 status { get; set; }
        public Eventtime eventTime { get; set; }
    }

    public class Status1
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
        public Code1 code { get; set; }
        public string url { get; set; }
    }

    public class Code1
    {
        public string iata { get; set; }
        public string icao { get; set; }
    }

    public class Airport
    {
        public Origin origin { get; set; }
        public Destination destination { get; set; }
        public object real { get; set; }
    }

    public class Origin
    {
        public string name { get; set; }
        public Code2 code { get; set; }
        public Position position { get; set; }
        public Timezone timezone { get; set; }
        public bool visible { get; set; }
        public string website { get; set; }
        public Info info { get; set; }
    }

    public class Code2
    {
        public string iata { get; set; }
        public string icao { get; set; }
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

    public class Destination
    {
        public string name { get; set; }
        public Code3 code { get; set; }
        public Position1 position { get; set; }
        public Timezone1 timezone { get; set; }
        public bool visible { get; set; }
        public string website { get; set; }
        public Info1 info { get; set; }
    }

    public class Code3
    {
        public string iata { get; set; }
        public string icao { get; set; }
    }

    public class Position1
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public string altitude { get; set; }
        public Country1 country { get; set; }
        public Region1 region { get; set; }
    }

    public class Country1
    {
        public string name { get; set; }
        public string code { get; set; }
    }

    public class Region1
    {
        public string city { get; set; }
    }

    public class Timezone1
    {
        public string name { get; set; }
        public int offset { get; set; }
        public string offsetHours { get; set; }
        public string abbr { get; set; }
        public string abbrName { get; set; }
        public bool isDst { get; set; }
    }

    public class Info1
    {
        public object terminal { get; set; }
        public object baggage { get; set; }
        public object gate { get; set; }
    }

    public class Flighthistory
    {
        public Aircraft1[] aircraft { get; set; }
        public Flight[] flight { get; set; }
    }

    public class Aircraft1
    {
        public Identification1 identification { get; set; }
        public Airport1 airport { get; set; }
        public Time time { get; set; }
    }

    public class Identification1
    {
        public string id { get; set; }
        public Number1 number { get; set; }
    }

    public class Number1
    {
        public string _default { get; set; }
    }

    public class Airport1
    {
        public Origin1 origin { get; set; }
        public Destination1 destination { get; set; }
    }

    public class Origin1
    {
        public string name { get; set; }
        public Code4 code { get; set; }
        public Position2 position { get; set; }
        public Timezone2 timezone { get; set; }
        public bool visible { get; set; }
        public string website { get; set; }
    }

    public class Code4
    {
        public string iata { get; set; }
        public string icao { get; set; }
    }

    public class Position2
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public string altitude { get; set; }
        public Country2 country { get; set; }
        public Region2 region { get; set; }
    }

    public class Country2
    {
        public string name { get; set; }
        public string code { get; set; }
    }

    public class Region2
    {
        public string city { get; set; }
    }

    public class Timezone2
    {
        public string name { get; set; }
        public int offset { get; set; }
        public string offsetHours { get; set; }
        public string abbr { get; set; }
        public string abbrName { get; set; }
        public bool isDst { get; set; }
    }

    public class Destination1
    {
        public string name { get; set; }
        public Code5 code { get; set; }
        public Position3 position { get; set; }
        public Timezone3 timezone { get; set; }
        public bool visible { get; set; }
        public string website { get; set; }
    }

    public class Code5
    {
        public string iata { get; set; }
        public string icao { get; set; }
    }

    public class Position3
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public string altitude { get; set; }
        public Country3 country { get; set; }
        public Region3 region { get; set; }
    }

    public class Country3
    {
        public string name { get; set; }
        public string code { get; set; }
    }

    public class Region3
    {
        public string city { get; set; }
    }

    public class Timezone3
    {
        public string name { get; set; }
        public int offset { get; set; }
        public string offsetHours { get; set; }
        public string abbr { get; set; }
        public string abbrName { get; set; }
        public bool isDst { get; set; }
    }

    public class Time
    {
        public TimeDetails real { get; set; }
    }

    public class TimeDetails
    {
        public int departure { get; set; }
    }

    public class Flight
    {
        public Identification2 identification { get; set; }
        public Aircraft2 aircraft { get; set; }
        public Airport2 airport { get; set; }
        public Time1 time { get; set; }
    }

    public class Identification2
    {
        public string id { get; set; }
    }

    public class Aircraft2
    {
        public Model1 model { get; set; }
        public string registration { get; set; }
    }

    public class Model1
    {
        public string code { get; set; }
        public string text { get; set; }
    }

    public class Airport2
    {
        public Origin2 origin { get; set; }
        public Destination2 destination { get; set; }
    }

    public class Origin2
    {
        public string name { get; set; }
        public Code6 code { get; set; }
        public Position4 position { get; set; }
        public Timezone4 timezone { get; set; }
        public bool visible { get; set; }
        public string website { get; set; }
    }

    public class Code6
    {
        public string iata { get; set; }
        public string icao { get; set; }
    }

    public class Position4
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public string altitude { get; set; }
        public Country4 country { get; set; }
        public Region4 region { get; set; }
    }

    public class Country4
    {
        public string name { get; set; }
        public string code { get; set; }
    }

    public class Region4
    {
        public string city { get; set; }
    }

    public class Timezone4
    {
        public string name { get; set; }
        public int offset { get; set; }
        public string offsetHours { get; set; }
        public string abbr { get; set; }
        public string abbrName { get; set; }
        public bool isDst { get; set; }
    }

    public class Destination2
    {
        public string name { get; set; }
        public Code7 code { get; set; }
        public Position5 position { get; set; }
        public Timezone5 timezone { get; set; }
        public bool visible { get; set; }
        public string website { get; set; }
    }

    public class Code7
    {
        public string iata { get; set; }
        public string icao { get; set; }
    }

    public class Position5
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public string altitude { get; set; }
        public Country5 country { get; set; }
        public Region5 region { get; set; }
    }

    public class Country5
    {
        public string name { get; set; }
        public string code { get; set; }
    }

    public class Region5
    {
        public string city { get; set; }
    }

    public class Timezone5
    {
        public string name { get; set; }
        public int offset { get; set; }
        public string offsetHours { get; set; }
        public string abbr { get; set; }
        public string abbrName { get; set; }
        public bool isDst { get; set; }
    }

    public class Time1
    {
        public Real1 real { get; set; }
        public Historical historical { get; set; }
    }

    public class Real1
    {
        public int departure { get; set; }
    }

    public class Historical
    {
        public int flighttime { get; set; }
    }

    public class Time2
    {
        public Scheduled scheduled { get; set; }
        public TimeDetails real { get; set; }
        public Estimated estimated { get; set; }
        public Other other { get; set; }
        public Historical1 historical { get; set; }
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

    public class Historical1
    {
        public string flighttime { get; set; }
        public string delay { get; set; }
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
