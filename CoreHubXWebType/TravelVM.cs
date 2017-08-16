using System;
using Newtonsoft.Json;


namespace CoreHubXWebType
{
    public class TravelVM
    {

        [JsonProperty("Callsign")]
        public string Callsign;
        [JsonProperty("Country")]
        public string Country;
        [JsonProperty("Iata")]
        public string Iata;
        [JsonProperty("Icao")]
        public string Icao;
        [JsonProperty("Id")]
        public int Id;
        [JsonProperty("Name")]
        public string Name;
        [JsonProperty("Type")]
        public string Type;

    }
}
